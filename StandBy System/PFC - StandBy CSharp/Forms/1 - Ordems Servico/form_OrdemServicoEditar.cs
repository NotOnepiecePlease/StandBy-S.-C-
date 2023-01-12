using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Forms.Pagamento;
using PFC___StandBy_CSharp.Forms.Pagamento_e_Compras;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.PreencherComponentes;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_6___Usada_por_Varias_Telas;
using PFC___StandBy_CSharp.Utils;
using Syncfusion.Windows.Forms.Tools;
using static PFC___StandBy_CSharp.Enum.Enum;

namespace PFC___StandBy_CSharp.Forms._1___Ordems_Servico
{
    public partial class form_OrdemServicoEditar : Form
    {
        private BuscarDados bd = new BuscarDados();
        private AlterarDados ad = new AlterarDados();
        private PreencherComboBoxCliente preencherCombobox = new PreencherComboBoxCliente();
        private DataTable dt;
        private MensagensSucesso mSucesso = new MensagensSucesso();
        private bool isServicoSemChecklistCondFisicas = false;

        public form_OrdemServicoEditar(int _idCliente, bool _isServicoSemChecklistCondFisicas)
        {
            InitializeComponent();
            isServicoSemChecklistCondFisicas = _isServicoSemChecklistCondFisicas;
            CarregarComboxClientes();
            SetarComboboxComUltimoClienteAdicionado(dt, _idCliente);
            InicializarOpcoesCombobox();
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtServicoValor);
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtPecaValor);
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtLucroValor);
        }

        private void InicializarOpcoesCombobox()
        {
            PreencherComboboxServicos p = new PreencherComboboxServicos();
            //info aparelho
            p.PreencherInfoAparelho(this);
            //cond fisicas
            p.PreencherInfoCondFisicas(this);
        }

        private void SetarComboboxComUltimoClienteAdicionado(DataTable _dt, int _id)
        {
            //Pego a linha que tem o ultimo ID cadastrado
            DataRow[] rows = _dt.Select($"ID ='{_id}'");
            //Seto a index da combobox para a index dessa linha que peguei acima.
            cmbCliente.SelectedIndex = _dt.Rows.IndexOf(rows[0]);
        }

        public void CarregarComboxClientes()
        {
            cmbCliente.SelectedIndexChanged -= cmbCliente_SelectedIndexChanged;
            preencherCombobox.CarregarComboxClientes(cmbCliente, ref dt);
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxBaseDataBound combobox = cmbCliente as ComboBoxBaseDataBound;
            if (combobox.SelectedIndex != -1)
            {
                DataRowView drv = combobox.Items[combobox.SelectedIndex] as DataRowView;
                //lblIdCliente.Text = listClientesComId.ElementAt(multiColumnComboBox1.SelectedIndex).ID.ToString();
                lblIdCliente.Text = drv.Row[0].ToString();
            }
        }

        private void AbrirRichtextExterna(RichTextBox _richText)
        {
            form_RichTextboxExterno formRTB = new form_RichTextboxExterno(ref _richText);
            formRTB.txtRichtextExterna.Text = _richText.Text;
            formRTB.ShowDialog();
        }

        private void txtRelatoCliente_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtRelatoCliente);
        }

        private void txtObservacoes_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtObservacoes);
        }

        private void txtCondicoesBalcao_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtCondicoesBalcao);
        }

        private void txtSolucao_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtSolucao);
        }

        private void txtServicoValor_TextChange(object sender, EventArgs e)
        {
            if (txtServicoValor.Text.Trim() != "R$" && txtServicoValor.Text.Trim() != "R" &&
                !string.IsNullOrWhiteSpace(txtServicoValor.Text))
            {
                float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
                txtValorAvista.Text = $"{servicoValor:C}";

                txtValorCartao.Text = $"{servicoValor * 1.05f:C}";
                CalcularLucro();
            }
        }

        private void txtServicoValor_Leave(object sender, EventArgs e)
        {
            //float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
            //txtValorAvista.Text = $"{servicoValor:C}";
        }

        private void txtValorAvista_TextChange(object sender, EventArgs e)
        {
            float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
            int parcelas = int.Parse(txtParcelas.Text);
            txtValorParcelaIndividual.Text = $"{servicoValor / parcelas:C}";
        }

        private void txtParcelas_TextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtParcelas.Text))
            {
                float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
                int parcelas = int.Parse(txtParcelas.Text);
                txtValorParcelaIndividual.Text = $"{servicoValor / parcelas:C}";
            }
            else
            {
                txtValorParcelaIndividual.Text = "";
            }
        }

        public void CalcularLucro()
        {
            float valorServico = 0.0f;
            float valorPeca = 0.0f;
            float lucro = valorServico - valorPeca;
            try
            {
                valorServico = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
                valorPeca = float.Parse(txtPecaValor.Text.TrimStart('R', '$').Trim());
                lucro = valorServico - valorPeca;
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.ToString());
            }

            if (lucro > 0)
            {
                txtLucroValor.ForeColor = Color.LimeGreen;
                sepLucro.ForeColor = Color.LimeGreen;
                sepLucro.LineColor = Color.LimeGreen;
                //sepLucro.LineFocusedColor = Color.LimeGreen;
                //txtLucroValor.Font = new Font(this.Font.Name, 11, FontStyle.Bold);
                txtLucroValor.Text = $"{lucro:C}";
            }
            else if (lucro == 0)
            {
                txtLucroValor.ForeColor = Color.White;
                sepLucro.ForeColor = Color.White;
                sepLucro.LineColor = Color.White;
                //txtLucroValor.LineFocusedColor = Color.White;
                txtLucroValor.Text = $"{lucro:C}";
            }
            else if (lucro < 0)
            {
                txtLucroValor.ForeColor = Color.Red;
                sepLucro.ForeColor = Color.Red;
                sepLucro.LineColor = Color.Red;
                //txtLucroValor.LineFocusedColor = Color.Red;
                txtLucroValor.Text = $"{lucro:C}";
            }
        }

        private void txtPecaValor_TextChange(object sender, EventArgs e)
        {
            CalcularLucro();
        }

        private void form_OrdemServicoEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCheckListENTRADA_Click(object sender, EventArgs e)
        {
            if (isServicoSemChecklistCondFisicas == true)
            {
                var escolha = MessageBox.Show("Deseja inserir um checklist de entrada?", " ", MessageBoxButtons.YesNo);
                if (escolha == DialogResult.Yes)
                {
                    //Abrir form
                    form_InserirEditarChecklist form =
                        new form_InserirEditarChecklist(Checklist.ENTRADA, true);
                    form.lblIdServico.Text = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Inserir checklist - Entrada";
                    form.lblTituloChecklist.Text = "Checklist - ENTRADA";
                    form.lblOrdemServico.Text = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text = dtpDataServico.EditValue.ToString();
                    form.ShowDialog();
                }
            }
            else
            {
                var escolha = MessageBox.Show("Deseja alterar um checklist de entrada?", " ", MessageBoxButtons.YesNo);
                if (escolha == DialogResult.Yes)
                {
                    //Abrir form
                    form_InserirEditarChecklist form =
                        new form_InserirEditarChecklist(Checklist.ENTRADA, false);
                    form.lblIdServico.Text = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Alterar checklist - Entrada";
                    form.lblTituloChecklist.Text = "Checklist - ENTRADA";
                    form.lblOrdemServico.Text = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text = dtpDataServico.EditValue.ToString();
                    form.ShowDialog();
                }
            }

            this.Close();
        }

        private void btnChecklistSAIDA_Click(object sender, EventArgs e)
        {
            if (isServicoSemChecklistCondFisicas == true)
            {
                var escolha = MessageBox.Show("Deseja inserir um checklist de saida?", " ", MessageBoxButtons.YesNo);
                if (escolha == DialogResult.Yes)
                {
                    //Abrir form
                    form_InserirEditarChecklist form =
                        new form_InserirEditarChecklist(Checklist.SAIDA, true);
                    form.lblIdServico.Text = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Inserir checklist - Saida";
                    form.lblTituloChecklist.Text = "Checklist - SAIDA";
                    form.lblOrdemServico.Text = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text = dtpDataServico.EditValue.ToString();
                    form.ShowDialog();
                }
            }
            else
            {
                var escolha = MessageBox.Show("Deseja alterar um checklist de saida?", " ", MessageBoxButtons.YesNo);
                if (escolha == DialogResult.Yes)
                {
                    //Abrir form
                    form_InserirEditarChecklist form =
                        new form_InserirEditarChecklist(Checklist.SAIDA, false);
                    form.lblIdServico.Text = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Alterar checklist - Saida";
                    form.lblTituloChecklist.Text = "Checklist - SAIDA";
                    form.lblOrdemServico.Text = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text = dtpDataServico.EditValue.ToString();
                    form.ShowDialog();
                }
            }
        }

        private void cmbTipoAparelho_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTipoAparelho.ImageOptions.SvgImage = svgCollection[cmbTipoAparelho.Text];
        }

        private void btnSalvarOrdemServico_Click(object sender, EventArgs e)
        {
            ad.AtualizarServico(this);
            ad.AtualizarCondicoesFisicas(this);
            mSucesso.AlterarServicoSucesso();
            this.Close();
        }

        private void btnConcluirServico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTipoAparelho.Text))
            {
                MessageBox.Show(
                    "Serviço só pode ser concluido quando você selecionar o tipo do aparelho.\nPara especificar o tipo basta selecionar no campo abaixo dos botoes de inserir checklist.",
                    "Tipo do aparelho inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ad.AtualizarServico(this);
            EfetuarPagamento();
            ConcluirServico();
            this.Close();
        }

        private void EfetuarPagamento()
        {
            form_Pagamento formPagamento = new form_Pagamento(Convert.ToInt32(lblIdServico.Text));
            formPagamento.txtValorServico.Text = txtServicoValor.Text;
            formPagamento.txtServicoExecutado.Text = txtSolucao.Text;
            formPagamento.lblIdServico.Text = lblIdServico.Text;
            formPagamento.ShowDialog();
        }

        private void ConcluirServico()
        {
            Aparelho tipoAparelho = Aparelho.VAZIO;
            switch (cmbTipoAparelho.Text)
            {
                case "Celular":
                    tipoAparelho = Aparelho.Celular;
                    break;

                case "Notebook":
                    tipoAparelho = Aparelho.Notebook;
                    break;

                case "Computador":
                    tipoAparelho = Aparelho.Computador;
                    break;
            }

            if (tipoAparelho != Aparelho.VAZIO)
            {
                if (MessageBox.Show("Gostaria de imprimir a O.S de Saida apos a conclusão do serviço?",
                        "Deseja imprimir OS - Saida?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(lblIdCliente.Text);
                    form_OrdemServicoSaida formSaida =
                        new form_OrdemServicoSaida(tipoAparelho, idCliente, false, new[] { 255, 0, 103 });
                    formSaida.lblIdServico.Text = lblIdServico.Text;
                    formSaida.lblIdCliente.Text = lblIdCliente.Text;
                    formSaida.lblIdChecklist.Text = lblIdChecklist.Text;
                    formSaida.lblIdCondicoesFisicas.Text = lblIdCondicoesFisicas.Text;
                    formSaida.ShowDialog();
                    return;
                }

                ad.AtualizarServico(this);
                ad.AtualizarCondicoesFisicas(this);
                ad.ConcluirServicos(Convert.ToInt32(lblIdServico.Text));
                this.Close();
            }
        }

        private void btnConcluirImprimir_Click(object sender, EventArgs e)
        {
        }

        private void cmbStatusServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxStatus.MudarCor(cmbStatusServico);
        }

        private void btnAbrirListaCompras_Click(object sender, EventArgs e)
        {
            AbrirFormaCompras();
            txtPecaValor.Text = $"{bd.BuscarTotalPecas(Convert.ToInt32(lblIdServico.Text)):C}";
        }

        private void AbrirFormaCompras()
        {
            int ordemServico = Convert.ToInt32(lblOrdemServico.Text.TrimStart('O', 'S', ' ').Trim());
            int idServico = Convert.ToInt32(lblIdServico.Text);
            form_Compras formCompra = new form_Compras(ordemServico, idServico);
            formCompra.lblIdServico.Text = lblIdServico.Text;
            formCompra.cmbOrdemServico.Enabled = false;
            formCompra.ShowDialog();
        }

        private void txtPecaValor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir novas peças para esse servico?", "Novas peças", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AbrirFormaCompras();
            }
        }
    }
}