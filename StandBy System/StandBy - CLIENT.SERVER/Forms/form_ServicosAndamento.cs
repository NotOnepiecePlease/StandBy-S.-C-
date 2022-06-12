//using StandBy___CLIENT.SERVER.Dados;
//using StandBy___CLIENT.SERVER.PreencherComponentes;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_ServicosAndamento : Form
    {
        private readonly PreencherTableOrdensServicos preencherTableOrdensServ = new PreencherTableOrdensServicos();
        private readonly BuscarDados bd = new BuscarDados();

        public form_ServicosAndamento()
        {
            InitializeComponent();
            preencherTableOrdensServ.Preencher(table_ServicosAndamento);
            timerAtualizarTabela.Start();
        }

        private void toolsANALISAR_Click(object sender, EventArgs e)
        {
            VerInformacoesServico();
        }

        private void VerInformacoesServico()
        {
            string telCliente = bd.BuscarTelefoneCliente(Convert.ToInt32(table_ServicosAndamento.SelectedCells[1].Value.ToString()));
            string telRecCliente = bd.BuscarTelefoneRecadoCliente(Convert.ToInt32(table_ServicosAndamento.SelectedCells[1].Value.ToString()));
            float lucro = float.Parse(table_ServicosAndamento.SelectedCells[10].Value.ToString());
            form_ServicosEdit frmTodosServicos = new form_ServicosEdit();

            //Operador de coalescência nulla, a celular 14 tava quase sempre retornando null
            object acessoriosCliente = table_ServicosAndamento.SelectedCells[14].Value ?? "----";
            try
            {
                string cpfCliente = bd.BuscarCPFCliente(Convert.ToInt32(table_ServicosAndamento.SelectedCells[1].Value.ToString()));
                frmTodosServicos.txtCpfCnpjCliente.Text = cpfCliente;
                frmTodosServicos.txtAcessoriosServico.Text = acessoriosCliente.ToString();
            }
            catch (Exception)
            {
                // ignored
            }

            frmTodosServicos.lblIDservico.Text = table_ServicosAndamento.SelectedCells[0].Value.ToString();
            frmTodosServicos.lblIDcliente.Text = table_ServicosAndamento.SelectedCells[1].Value.ToString();
            frmTodosServicos.txtDataServico.Text = Convert.ToDateTime(table_ServicosAndamento.SelectedCells[2].Value.ToString()).ToShortDateString();
            frmTodosServicos.txtNomeCliente.Text = table_ServicosAndamento.SelectedCells[3].Value.ToString();

            frmTodosServicos.txtTelefonePrincipal.Text = telCliente;
            frmTodosServicos.txtTelefoneRecado.Text = telRecCliente;
            frmTodosServicos.txtAparelhoServico.Text = table_ServicosAndamento.SelectedCells[4].Value.ToString();
            frmTodosServicos.txtDefeitoServico.Text = table_ServicosAndamento.SelectedCells[5].Value.ToString();
            frmTodosServicos.txtSenhaServico.Text = table_ServicosAndamento.SelectedCells[7].Value.ToString();
            frmTodosServicos.txtSituacaoServico.Text = table_ServicosAndamento.SelectedCells[6].Value.ToString();

            frmTodosServicos.txtValorServico.Text = table_ServicosAndamento.SelectedCells[8].Value.ToString();
            frmTodosServicos.txtPecaValor.Text = table_ServicosAndamento.SelectedCells[9].Value.ToString();
            frmTodosServicos.txtLucroValor.Text = table_ServicosAndamento.SelectedCells[10].Value.ToString();
            frmTodosServicos.txtServicoFeito.Text = table_ServicosAndamento.SelectedCells[11].Value.ToString();

            if (table_ServicosAndamento.SelectedCells[12].Value == DBNull.Value)
            {
                //MessageBox.Show("Sem data");
                frmTodosServicos.dtpDataEditPrevisao.FormatCustom = " ";
                frmTodosServicos.dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
                frmTodosServicos.chkSemData.Checked = true;
            }
            else
            {
                frmTodosServicos.dtpDataEditPrevisao.Value = Convert.ToDateTime(table_ServicosAndamento.SelectedCells[12].Value.ToString());
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
            frmTodosServicos.pictureSenhaPadrao.Image = ConvertByteArrayToImage(bd.BuscarImagem(table_ServicosAndamento.SelectedCells[0].Value.ToString()));
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

        public void AtualizarCoresCelulasTabela()
        {
            foreach (DataGridViewRow row in table_ServicosAndamento.Rows)
            {
                try
                {
                    if (row.Cells[12].Value != DBNull.Value && Convert.ToInt32(row.Cells[13].Value) == 1)
                    {
                        //row.Cells[12] = é a coluna sv_previsao_entrega
                        DateTime dataEntrega = Convert.ToDateTime(row.Cells[12].Value);
                        DateTime dataAtual = DateTime.Now;

                        TimeSpan DiasParaEntrega = dataEntrega.Subtract(dataAtual);

                        //0 = sem cor
                        //1 = verde
                        //2 = amarelo/laranja
                        //3 = vermelho
                        if (DiasParaEntrega.TotalHours < 0)
                        //if (Convert.ToInt32(row.Cells[2].Value) == 3)
                        {
                            row.Cells[2].Style.BackColor = Color.Red;
                            row.Cells[2].Style.ForeColor = Color.Black;
                        }
                        else if (DiasParaEntrega.TotalHours >= 0 && DiasParaEntrega.TotalHours <= 12)
                        //else if (Convert.ToInt32(row.Cells[2].Value) == 2)
                        {
                            row.Cells[2].Style.BackColor = Color.Orange;
                            row.Cells[2].Style.ForeColor = Color.Black;
                        }
                        else if (DiasParaEntrega.TotalHours > 12)
                        //else if (Convert.ToInt32(row.Cells[2].Value) == 1)
                        {
                            row.Cells[2].Style.BackColor = Color.Lime;
                            row.Cells[2].Style.ForeColor = Color.Black;
                        }
                        else
                        {
                            row.Cells[2].Style.BackColor = Color.FromArgb(30, 30, 46);
                            row.Cells[2].Style.ForeColor = Color.Gray;
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void table_ServicosAndamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AtualizarCoresCelulasTabela();
        }

        private void timerAtualizarTabela_Tick(object sender, EventArgs e)
        {
            preencherTableOrdensServ.Preencher(table_ServicosAndamento);
            table_ServicosAndamento.ClearSelection();
        }

        private void table_ServicosAndamento_MouseLeave(object sender, EventArgs e)
        {
            table_ServicosAndamento.ClearSelection();
            timerAtualizarTabela.Start();
        }

        private void table_ServicosAndamento_MouseEnter(object sender, EventArgs e)
        {
            timerAtualizarTabela.Stop();
        }

        private void table_ServicosAndamento_DoubleClick(object sender, EventArgs e)
        {
            VerInformacoesServico();
        }
    }
}