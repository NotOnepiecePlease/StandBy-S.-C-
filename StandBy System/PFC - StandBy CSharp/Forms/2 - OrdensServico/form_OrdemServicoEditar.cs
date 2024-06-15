﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Forms.Pagamento;
using PFC___StandBy_CSharp.Forms.Pagamento_e_Compras;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.PreencherComponentes;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_6___Usada_por_Varias_Telas;
using PFC___StandBy_CSharp.Utils;
using Syncfusion.Windows.Forms.Tools;
using static PFC___StandBy_CSharp.Enums.EnumStandby;

namespace PFC___StandBy_CSharp.Forms._1___Ordems_Servico
{
    public partial class form_OrdemServicoEditar : Form
    {
        private BuscarDados bd = new BuscarDados();
        private AlterarDados ad = new AlterarDados();
        private PreencherComboBoxCliente preencherCombobox = new PreencherComboBoxCliente();
        private BuscarDados buscarDados = new BuscarDados();
        private DataTable dt;
        private MensagensSucesso mSucesso = new MensagensSucesso();
        private bool isServicoSemChecklistCondFisicas = false;

        public form_OrdemServicoEditar(int _idCliente, bool _isServicoSemChecklistCondFisicas)
        {
            InitializeComponent();
            isServicoSemChecklistCondFisicas = _isServicoSemChecklistCondFisicas;
            CarregarComboxClientes();
            SetarComboboxDeCliente(dt, _idCliente);
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

        private void SetarComboboxDeCliente(DataTable _dt, int _id)
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

                lblIdCliente.Text      = drv.Row[0].ToString();
                lblCPF.Text            = drv.Row[2].ToString();
                lblTelefone.Text       = drv.Row[3].ToString();
                lblTelefoneRecado.Text = drv.Row[4].ToString();
                lblRua.Text            = drv.Row[6].ToString();
                lblBairro.Text         = drv.Row[7].ToString();
                lblCidade.Text         = drv.Row[8].ToString();

                //lblCEP.Text            = drv.Row[5].ToString();
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
                valorPeca    = float.Parse(txtPecaValor.Text.TrimStart('R', '$').Trim());
                lucro        = valorServico - valorPeca;
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.ToString());
            }

            if (lucro > 0)
            {
                txtLucroValor.ForeColor = Color.LimeGreen;
                sepLucro.ForeColor      = Color.LimeGreen;
                sepLucro.LineColor      = Color.LimeGreen;

                //sepLucro.LineFocusedColor = Color.LimeGreen;
                //txtLucroValor.Font = new Font(this.Font.Name, 11, FontStyle.Bold);
                txtLucroValor.Text = $"{lucro:C}";
            }
            else if (lucro == 0)
            {
                txtLucroValor.ForeColor = Color.White;
                sepLucro.ForeColor      = Color.White;
                sepLucro.LineColor      = Color.White;

                //txtLucroValor.LineFocusedColor = Color.White;
                txtLucroValor.Text = $"{lucro:C}";
            }
            else if (lucro < 0)
            {
                txtLucroValor.ForeColor = Color.Red;
                sepLucro.ForeColor      = Color.Red;
                sepLucro.LineColor      = Color.Red;

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
                this.Dispose();
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
                    form.lblIdServico.Text       = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Inserir checklist - Entrada";
                    form.lblTituloChecklist.Text = "Checklist - ENTRADA";
                    form.lblOrdemServico.Text    = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text         = dtpDataServico.EditValue.ToString();
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
                    form.lblIdServico.Text       = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Alterar checklist - Entrada";
                    form.lblTituloChecklist.Text = "Checklist - ENTRADA";
                    form.lblOrdemServico.Text    = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text         = dtpDataServico.EditValue.ToString();
                    form.ShowDialog();
                }
            }

            //this.Close();
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
                    form.lblIdServico.Text       = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Inserir checklist - Saida";
                    form.lblTituloChecklist.Text = "Checklist - SAIDA";
                    form.lblOrdemServico.Text    = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text         = dtpDataServico.EditValue.ToString();
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
                    form.lblIdServico.Text       = lblIdServico.Text;
                    form.btnSalvarChecklist.Text = "Alterar checklist - Saida";
                    form.lblTituloChecklist.Text = "Checklist - SAIDA";
                    form.lblOrdemServico.Text    = lblOrdemServico.Text.TrimStart('O', 'S').Trim();
                    form.lblDataCad.Text         = dtpDataServico.EditValue.ToString();
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
            if (string.IsNullOrWhiteSpace(cmbTipoAparelho.Text))
            {
                MessageBox.Show(@"Voce esqueceu de selecionar o tipo do aparelho", "ALERTA!", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                return;
            }

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
                    "Serviço só pode ser concluido quando você selecionar o tipo do aparelho.\nPara especificar o tipo basta selecionar no campo abaixo dos botoes de inserir checklist."
                    ,
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
            formPagamento.txtValorServico.Text     = txtServicoValor.Text;
            formPagamento.txtServicoExecutado.Text = txtSolucao.Text;
            formPagamento.lblIdServico.Text        = lblIdServico.Text;
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
                    form_OrdemServicoSaida formSaida = new form_OrdemServicoSaida();

                    //form_OrdemServicoSaida formSaida = new form_OrdemServicoSaida(tipoAparelho, idCliente, false, new[] { 255, 0, 103 });
                    formSaida.lblOrdemServico.Text          = lblOrdemServico.Text;
                    formSaida.lblDataOrdemServico.Text      = lblDataOrdemServico.Text;
                    formSaida.lblIdServico.Text             = lblIdServico.Text;
                    formSaida.lblIdCliente.Text             = lblIdCliente.Text;
                    formSaida.lblIdChecklist.Text           = lblIdChecklist.Text;
                    formSaida.lblIdCondicoesFisicas.Text    = lblIdCondicoesFisicas.Text;
                    formSaida.btnSalvarOrdemServico.Visible = false;
                    formSaida.ShowDialog();
                    return;
                }

                ad.AtualizarServico(this);
                ad.AtualizarCondicoesFisicas(this);
                ad.ConcluirServicos(Convert.ToInt32(lblIdServico.Text));
                this.Close();
            }
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
            formCompra.lblIdServico.Text       = lblIdServico.Text;
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

        private void FuncaoDesabilitada(object sender, EventArgs e)
        {
            MessageBox.Show("Função desabilitada no momento.", "Função desabilitada", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void form_OrdemServicoEditar_Shown(object sender, EventArgs e)
        {
            //BuscarInformacoesCliente();
        }

        //private void BuscarInformacoesCliente()
        //{
        //    foreach (DataRowView VARIABLE in cmbCliente.Items)
        //    {
        //        txtCPFCliente.Text        = VARIABLE.Row["Cpf"].ToString();
        //        txtTelefonePrincipal.Text = VARIABLE.Row["⠀⠀⠀Telefone⠀⠀"].ToString();
        //        txtTelefoneRecado.Text    = VARIABLE.Row["Recado"].ToString();
        //    }
        //}

        private void picSenhaPattern_Click(object sender, EventArgs e)
        {
            standby_orgContext context = new standby_orgContext();
            var senhaPadrao = context.tb_servicos.FirstOrDefault(x => x.sv_id == Convert.ToInt32(lblIdServico.Text))
                .sv_senha_pattern;

            if (senhaPadrao == null || senhaPadrao[0] == 0x00 && picSenhaPattern.Image == null)
            {
                form_PasswordPattern formPass = new form_PasswordPattern(this, new[] { 255, 0, 103 });
                formPass.ShowDialog();
            }
            else
            {
                VerSenhaPattern();
                var senhaRecemAdd = context.tb_servicos
                    .FirstOrDefault(x => x.sv_id == Convert.ToInt32(lblIdServico.Text)).sv_senha_pattern;
                picSenhaPattern.Image =
                    ConvertImage.ConvertByteArrayToImage(buscarDados.BuscarImagem(lblIdServico.Text));
                
            }

            //var isExisteSenhaPadrao = context.tb_servicos.Any(x => x.sv_id == Convert.ToInt32(lblIdServico.Text) && x.sv_senha_pattern != null);
            //if (isExisteSenhaPadrao == false)
            //{
            //    form_PasswordPattern pp = new form_PasswordPattern(this, new[] { 255, 0, 103 });
            //    pp.ShowDialog();
            //}
            //else
            //{
            //    VerSenhaPattern();
            //}
        }

        private void VerSenhaPattern()
        {
            using (form_PasswordPatternExibir passShow = new form_PasswordPatternExibir(new[] { 255, 0, 103 }))
            {
                passShow.pictureBox1.Image =
                    ConvertImage.ConvertByteArrayToImage(buscarDados.BuscarImagem(lblIdServico.Text));
                if (passShow.pictureBox1.Image == null)
                {
                    passShow.lblSemPadrao.Visible       = true;
                    passShow.lblDesejaCadastrar.Visible = true;
                    passShow.btnSim.Visible             = true;
                    passShow.btnNao.Visible             = true;
                    passShow.lblIDServico.Text          = lblIdServico.Text;
                }
                else
                {
                    passShow.lblSemPadrao.Visible       = false;
                    passShow.lblDesejaCadastrar.Visible = false;
                    passShow.btnSim.Visible             = false;
                    passShow.btnNao.Visible             = false;
                    passShow.lblIDServico.Text          = lblIdServico.Text;
                }

                passShow.ShowDialog();
            }
        }
    }
}