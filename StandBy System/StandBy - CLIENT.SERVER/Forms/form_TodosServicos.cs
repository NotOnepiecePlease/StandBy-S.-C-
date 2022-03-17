//using StandBy___CLIENT.SERVER.Dados;
//using StandBy___CLIENT.SERVER.PreencherComponentes;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_3___ServicosConcluidos;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_TodosServicos : Form
    {
        //PreencherTableTodosServicos preencherTableConcluidos = new PreencherTableTodosServicos();
        private readonly PreencherTableConcluidos preencherTableConcluidos = new PreencherTableConcluidos();

        private readonly AlterarDados ad = new AlterarDados();
        private readonly BuscarDados bd = new BuscarDados();

        public form_TodosServicos()
        {
            InitializeComponent();
            preencherTableConcluidos.Preencher(table_TodosServicos, 1, 50);
            //preencherTableConcluidos.Preencher(table_TodosServicos);
        }

        private void toolsVerServico_Click(object sender, EventArgs e)
        {
            verServico();

            //MessageBox.Show(table_TodosServicos.SelectedCells[1].Value.ToString());
        }

        private void verServico()
        {
            // 0 - idServico
            // 1 - idCliente
            // 2 - Data
            // 3 - Nome
            // 4 - Aparelho
            // 5 - Defeito
            // 6 - Situacao
            // 7 - Senha
            // 8 - valorServico
            // 9 - valorPeca
            //10 - lucro
            //11 - servico
            //12 - STATUS
            //13 - DataConclusao
            //14 - sv_acessorios
            //15 - sv_previsao_entrega

            string _TELCliente = bd.BuscarTelefoneCliente(Convert.ToInt32(table_TodosServicos.SelectedCells[1].Value.ToString()));
            string _TEL_RECCliente = bd.BuscarTelefoneRecadoCliente(Convert.ToInt32(table_TodosServicos.SelectedCells[1].Value.ToString()));
            float lucro = float.Parse(table_TodosServicos.SelectedCells[10].Value.ToString());
            form_ServicosEdit frmTodosServicos = new form_ServicosEdit();

            //Operador de coalescência nulla, a celular 14 tava quase sempre retornando null
            object acessoriosCliente = table_TodosServicos.SelectedCells[14].Value ?? "----";
            try
            {
                string _CPFCliente = bd.BuscarCPFCliente(Convert.ToInt32(table_TodosServicos.SelectedCells[1].Value.ToString()));
                frmTodosServicos.txtCpfCnpjCliente.Text = _CPFCliente;
                frmTodosServicos.txtAcessoriosServico.Text = acessoriosCliente.ToString();
            }
            catch (Exception)
            {
            }

            frmTodosServicos.lblIDservico.Text = table_TodosServicos.SelectedCells[0].Value.ToString();
            frmTodosServicos.lblIDcliente.Text = table_TodosServicos.SelectedCells[1].Value.ToString();
            frmTodosServicos.txtDataServico.Text = Convert.ToDateTime(table_TodosServicos.SelectedCells[2].Value.ToString()).ToShortDateString();
            frmTodosServicos.txtNomeCliente.Text = table_TodosServicos.SelectedCells[3].Value.ToString();
            frmTodosServicos.txtAcessoriosServico.Text = table_TodosServicos.SelectedCells[14].Value.ToString();

            frmTodosServicos.txtTelefonePrincipal.Text = _TELCliente;
            frmTodosServicos.txtTelefoneRecado.Text = _TEL_RECCliente;
            frmTodosServicos.txtAparelhoServico.Text = table_TodosServicos.SelectedCells[4].Value.ToString();
            frmTodosServicos.txtDefeitoServico.Text = table_TodosServicos.SelectedCells[5].Value.ToString();
            frmTodosServicos.txtSenhaServico.Text = table_TodosServicos.SelectedCells[7].Value.ToString();
            frmTodosServicos.txtSituacaoServico.Text = table_TodosServicos.SelectedCells[6].Value.ToString();

            frmTodosServicos.txtValorServico.Text = table_TodosServicos.SelectedCells[8].Value.ToString();
            frmTodosServicos.txtPecaValor.Text = table_TodosServicos.SelectedCells[9].Value.ToString();
            frmTodosServicos.txtLucroValor.Text = table_TodosServicos.SelectedCells[10].Value.ToString();
            frmTodosServicos.txtServicoFeito.Text = table_TodosServicos.SelectedCells[11].Value.ToString();

            if (table_TodosServicos.SelectedCells[15].Value == DBNull.Value)
            {
                //MessageBox.Show("Sem data");
                frmTodosServicos.dtpDataEditPrevisao.FormatCustom = " ";
                frmTodosServicos.dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
                frmTodosServicos.chkSemData.Checked = true;
            }
            else
            {
                frmTodosServicos.dtpDataEditPrevisao.Value = Convert.ToDateTime(table_TodosServicos.SelectedCells[15].Value.ToString());
                frmTodosServicos.dtpDataEditPrevisao.Value = DateTime.Now;
                frmTodosServicos.chkSemData.Checked = false;
            }

            if (lucro > 0)
            {
                frmTodosServicos.txtLucroValor.ForeColor = Color.LimeGreen;
            }
            else if (lucro == 0)
            {
                frmTodosServicos.txtLucroValor.ForeColor = Color.White;
            }
            else
            {
                frmTodosServicos.txtLucroValor.ForeColor = Color.Red;
            }

            //frmTodosServicos.LabelResize();

            //Pegar a senha de padrao no banco e por no componente
            frmTodosServicos.pictureSenhaPadrao.Image = ConvertByteArrayToImage(bd.BuscarImagem(table_TodosServicos.SelectedCells[0].Value.ToString()));
            frmTodosServicos.pictureSenhaPadrao.BorderRadius = 0;

            frmTodosServicos.ShowDialog();
        }

        private Image ConvertByteArrayToImage(byte[] data)
        {
            if (data[0] != 0)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void timerAtualizarTabela_Tick(object sender, EventArgs e)
        {
            preencherTableConcluidos.Preencher(table_TodosServicos, 1, 50);
            table_TodosServicos.ClearSelection();
        }

        private void table_TodosServicos_MouseEnter(object sender, EventArgs e)
        {
            timerAtualizarTabela.Stop();
        }

        private void table_TodosServicos_MouseLeave(object sender, EventArgs e)
        {
            timerAtualizarTabela.Start();
        }

        private void txtPesquisarConcluidos_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}