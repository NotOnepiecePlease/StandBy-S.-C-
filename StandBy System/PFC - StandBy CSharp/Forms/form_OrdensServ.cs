using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.PreencherComponentes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_OrdensServ : Form
    {

        BuscarDados bd = new BuscarDados();
        InserirDados id = new InserirDados();
        AlterarDados ad = new AlterarDados();
        DeletarDados dd = new DeletarDados();
        PreencherComboBoxCliente pc = new PreencherComboBoxCliente();
        MensagensErro me = new MensagensErro();
        MensagensSucesso ms = new MensagensSucesso();
        PreencherTableOrdensServicos preencherTableServ = new PreencherTableOrdensServicos();
        int[] corGeral = new int[3] { 0, 0, 0 };
        public form_OrdensServ(int[] corRGB)
        {
            InitializeComponent();
            preencherTableServ.Preencher(table_OrdensServicos);
            pc.Preencher(cmbClientes);
            corGeral = corRGB;
            MudarTodasCores();
            //cmbClientes.SelectedIndex = 0;
            cmbClientes.SelectedIndex = cmbClientes.Items.Count - 1;
            table_OrdensServicos.ClearSelection();
            //VerificarAtraso();
            //timer1.Start();
        }

        private void table_OrdensServicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //AtualizarAtrasosCores();
        }

        public void AtualizarAtrasosCores()
        {
            foreach (DataGridViewRow row in table_OrdensServicos.Rows)
            {
                if (row.Cells[12].Value != DBNull.Value && Convert.ToInt32(row.Cells[13].Value) == 1)
                {
                    DateTime dataEntrega = Convert.ToDateTime(row.Cells[12].Value);
                    DateTime dataAtual = DateTime.Now;

                    TimeSpan DiasParaEntrega = dataEntrega.Subtract(dataAtual);

                    //MessageBox.Show("Horas: " + DiasParaEntrega.TotalHours + "//Data: "+ Convert.ToDateTime(row.Cells[12].Value));
                    //int DiasParaEntrega = (int)Convert.ToDateTime(row.Cells[12].Value).Subtract(DateTime.Now.Date).TotalDays;
                    //DateTime data = DateTime.Now.Date.s  Convert.ToDateTime(row.Cells[12].Value);

                    if (DiasParaEntrega.TotalHours < 0)
                    {
                        row.Cells[2].Style.BackColor = Color.Red;
                        row.Cells[2].Style.ForeColor = Color.Black;
                    }
                    else if (DiasParaEntrega.TotalHours >= 0 && DiasParaEntrega.TotalHours <= 12)
                    {
                        row.Cells[2].Style.BackColor = Color.Orange;
                        row.Cells[2].Style.ForeColor = Color.Black;
                    }
                    else if (DiasParaEntrega.TotalHours > 12)
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
        }
        private void VerificarAtraso()
        {
            foreach (DataGridViewRow row in table_OrdensServicos.Rows)
            {
                if (Convert.ToString(row.Cells[7].Value) == "teemo")
                {
                    // Se for negativo, fica vermelho
                    //row.Cells[12].Value = "DONE";
                    MessageBox.Show(Convert.ToString(row.Cells[3].Value));
                    //row.Cells[3].Style.BackColor = Color.Red;
                    row.Cells[7].Style.BackColor = Color.Red;

                    //table_OrdensServicos.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
                }
            }
            //table_OrdensServicos.BackgroundColor = Color.Red;
        }

        public void MudarTodasCores()
        {
            btnCadastrarOrdem.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnPesquisarCliente.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSituacaoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPesquisarCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //table_OrdensServicos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //cmbClientes.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            contextMenuStrip1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        public void refreshTable()
        {
            preencherTableServ.Preencher(table_OrdensServicos);
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                preencherTableServ.PreencherServicosPorNomeCliente(table_OrdensServicos, txtPesquisarCliente.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex + "");
            }
        }

        private void btnCadastrarOrdem_Click(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            {
                MessageBox.Show("Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                form_DiaEntrega formPrevisaoEntrega = new form_DiaEntrega(this, corGeral);
                formPrevisaoEntrega.ShowDialog();
            }



            //if (txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            //{
            //    MessageBox.Show("Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    //Pego a ID do cliente no banco de dados pelo nome dele na combobox.
            //    int _idCliente = bd.BuscarIdCliente(cmbClientes.SelectedItem.ToString());
            //    //Pego a data de hoje.
            //    DateTime data = DateTime.Now;

            //    try
            //    {
            //        //Insiro o servico com os dados.
            //        if (txtSenhaOrdens.Text.Equals("Digite a senha do celular"))
            //        {
            //            id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, "------------", txtSituacaoOrdens.Text);
            //        }
            //        else
            //        {
            //            id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, txtSenhaOrdens.Text, txtSituacaoOrdens.Text);
            //        }


            //        //Reseto os campos.
            //        txtAparelhoOrdens.Text = "";
            //        txtDefeitoOrdens.Text = "";
            //        txtSenhaOrdens.Text = "";
            //        txtSituacaoOrdens.Text = "";

            //        //Mensagem de Conclusao
            //        ms.InserirServicoSucesso();

            //        //Atualizo a tabela
            //        preencherTableServ.Preencher(table_OrdensServicos);
            //    }
            //    catch (Exception ex)
            //    {
            //        //Mensagem de Erro
            //        me.ErroInserirServico(ex);
            //    }
            //}
        }

        private void txtAparelhoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text == "Modelo do aparelho")
            {
                txtAparelhoOrdens.Text = "";
                txtAparelhoOrdens.Font = new Font(txtAparelhoOrdens.Font, FontStyle.Regular);
                txtAparelhoOrdens.LineIdleColor = Color.White;
                txtAparelhoOrdens.ForeColor = Color.White;
            }
        }

        private void txtAparelhoOrdens_Leave(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text == "" || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            {
                txtAparelhoOrdens.Text = "Modelo do aparelho";
                txtAparelhoOrdens.Font = new Font(txtAparelhoOrdens.Font, FontStyle.Italic);
                txtAparelhoOrdens.ForeColor = Color.Silver;
                txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtDefeitoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtDefeitoOrdens.Text == "Digite o defeito")
            {
                txtDefeitoOrdens.Text = "";
                txtDefeitoOrdens.Font = new Font(txtDefeitoOrdens.Font, FontStyle.Regular);
                txtDefeitoOrdens.LineIdleColor = Color.White;
                txtDefeitoOrdens.ForeColor = Color.White;
            }
        }

        private void txtDefeitoOrdens_Leave(object sender, EventArgs e)
        {
            if (txtDefeitoOrdens.Text == "" || string.IsNullOrWhiteSpace(txtDefeitoOrdens.Text))
            {
                txtDefeitoOrdens.Text = "Digite o defeito";
                txtDefeitoOrdens.Font = new Font(txtDefeitoOrdens.Font, FontStyle.Italic);
                txtDefeitoOrdens.ForeColor = Color.Silver;
                txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                //txtDefeitoOrdens.LineIdleColor = Color.White;
            }
        }

        private void txtSenhaOrdens_Enter(object sender, EventArgs e)
        {
            if (txtSenhaOrdens.Text == "Digite a senha do celular")
            {
                txtSenhaOrdens.Text = "";
                txtSenhaOrdens.Font = new Font(txtSenhaOrdens.Font, FontStyle.Regular);
                txtSenhaOrdens.LineIdleColor = Color.White;
                txtSenhaOrdens.ForeColor = Color.White;
            }
        }

        private void txtSenhaOrdens_Leave(object sender, EventArgs e)
        {
            if (txtSenhaOrdens.Text == "" || string.IsNullOrWhiteSpace(txtSenhaOrdens.Text))
            {
                txtSenhaOrdens.Text = "Digite a senha do celular";
                txtSenhaOrdens.Font = new Font(txtSenhaOrdens.Font, FontStyle.Italic);
                txtSenhaOrdens.ForeColor = Color.Silver;
                txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtSituacaoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtSituacaoOrdens.Text == "Situação do aparelho")
            {
                txtSituacaoOrdens.Text = "";
                txtSituacaoOrdens.Font = new Font(txtSituacaoOrdens.Font, FontStyle.Regular);
                txtSituacaoOrdens.LineIdleColor = Color.White;
                txtSituacaoOrdens.ForeColor = Color.White;
            }
        }

        private void txtSituacaoOrdens_Leave(object sender, EventArgs e)
        {
            if (txtSituacaoOrdens.Text == "" || string.IsNullOrWhiteSpace(txtSituacaoOrdens.Text))
            {
                txtSituacaoOrdens.Text = "Situação do aparelho";
                txtSituacaoOrdens.Font = new Font(txtSituacaoOrdens.Font, FontStyle.Italic);
                txtSituacaoOrdens.ForeColor = Color.Silver;
                txtSituacaoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtPesquisarCliente_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarCliente.Text == "Digite o nome do cliente que deseja buscar os serviços")
            {
                txtPesquisarCliente.Text = "";
                txtPesquisarCliente.Font = new Font(txtPesquisarCliente.Font, FontStyle.Regular);
                txtPesquisarCliente.BorderColorIdle = Color.White;
                txtPesquisarCliente.ForeColor = Color.White;
            }
        }

        private void txtPesquisarCliente_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarCliente.Text == "" || string.IsNullOrWhiteSpace(txtPesquisarCliente.Text))
            {
                txtPesquisarCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
                txtPesquisarCliente.Font = new Font(txtSituacaoOrdens.Font, FontStyle.Italic);
                txtPesquisarCliente.ForeColor = Color.Silver;
                txtPesquisarCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                timer1.Start();
            }
        }

        private void txtPesquisarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Stop();
            if (txtPesquisarCliente.Text == "")
            {
                preencherTableServ.Preencher(table_OrdensServicos);
                table_OrdensServicos.ClearSelection();
            }
            else
            {
                try
                {
                    preencherTableServ.PreencherServicosPorNomeCliente(table_OrdensServicos, txtPesquisarCliente.Text);
                    //table_OrdensServicos.Refresh();
                    table_OrdensServicos.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
                }
            }
        }

        private void table_OrdensServicos_DoubleClick(object sender, EventArgs e)
        {
            EditarUmServico();
        }

        public void EditarUmServico()
        {
            string _CPFCliente = bd.BuscarCPFCliente(Convert.ToInt32(table_OrdensServicos.SelectedCells[1].Value.ToString()));
            string _TELCliente = bd.BuscarTelefoneCliente(Convert.ToInt32(table_OrdensServicos.SelectedCells[1].Value.ToString()));
            float lucro = float.Parse(table_OrdensServicos.SelectedCells[10].Value.ToString());
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);
            editarServicos.lblIDservico.Text = table_OrdensServicos.SelectedCells[0].Value.ToString();
            editarServicos.lblIDcliente.Text = table_OrdensServicos.SelectedCells[1].Value.ToString();
            editarServicos.dtpDataEdit.Value = Convert.ToDateTime(table_OrdensServicos.SelectedCells[2].Value.ToString());
            editarServicos.lblClienteNome.Text = table_OrdensServicos.SelectedCells[3].Value.ToString();
            editarServicos.txtClienteNome.Text = table_OrdensServicos.SelectedCells[3].Value.ToString();
            editarServicos.txtCPFCliente.Text = _CPFCliente;
            editarServicos.txtTelefoneCliente.Text = _TELCliente;
            editarServicos.txtAparelhoEdit.Text = table_OrdensServicos.SelectedCells[4].Value.ToString();
            editarServicos.txtDefeitoEdit.Text = table_OrdensServicos.SelectedCells[5].Value.ToString();
            editarServicos.txtSenhaEdit.Text = table_OrdensServicos.SelectedCells[7].Value.ToString();
            editarServicos.txtSituacaoEdit.Text = table_OrdensServicos.SelectedCells[6].Value.ToString();
            editarServicos.txtServicoValorEdit.Text = table_OrdensServicos.SelectedCells[8].Value.ToString();
            editarServicos.txtPecaValorEdit.Text = table_OrdensServicos.SelectedCells[9].Value.ToString();
            editarServicos.txtLucroValorEdit.Text = table_OrdensServicos.SelectedCells[10].Value.ToString();
            editarServicos.txtServicoEdit.Text = table_OrdensServicos.SelectedCells[11].Value.ToString();
            if (table_OrdensServicos.SelectedCells[12].Value == DBNull.Value)
            {
                //MessageBox.Show("Sem data");
                editarServicos.dtpDataEditPrevisao.FormatCustom = " ";
                editarServicos.dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
                editarServicos.chkSemData.Checked = true;
                //editarServicos.dtpDataEditPrevisao.Value = DateTime.Parse("00/00/0000");
            }
            else
            {
                editarServicos.dtpDataEditPrevisao.Value = Convert.ToDateTime(table_OrdensServicos.SelectedCells[12].Value.ToString());
                editarServicos.chkSemData.Checked = false;
            }

            if (lucro > 0)
            {
                editarServicos.txtLucroValorEdit.LineIdleColor = Color.LimeGreen;
            }
            else if (lucro == 0)
            {
                editarServicos.txtLucroValorEdit.LineIdleColor = Color.White;
            }
            else
            {
                editarServicos.txtLucroValorEdit.LineIdleColor = Color.Red;
            }

            editarServicos.LabelResize();

            editarServicos.ShowDialog();
            //table_OrdensServicos.Refresh();
            //refreshTable();
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUmServico();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja deletar esse serviço?", "DELETAR SERVIÇO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int _idServico = int.Parse(table_OrdensServicos.SelectedCells[0].Value.ToString());
                dd.DeletarServico(_idServico);
                refreshTable();
            }
        }

        private void txtAparelhoOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtDefeitoOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtSenhaOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtSituacaoOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        public void CadastrarServicoNovo()
        {

            form_DiaEntrega formPrevisaoEntrega = new form_DiaEntrega(this, corGeral);

            formPrevisaoEntrega.ShowDialog();

            //if (txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            //{
            //    MessageBox.Show("Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    //Pego a ID do cliente no banco de dados pelo nome dele na combobox.
            //    int _idCliente = bd.BuscarIdCliente(cmbClientes.SelectedItem.ToString());
            //    //Pego a data de hoje.
            //    DateTime data = DateTime.Now;

            //    try
            //    {
            //        //Insiro o servico com os dados.
            //        if (txtSenhaOrdens.Text.Equals("Digite a senha do celular") || string.IsNullOrWhiteSpace(txtSenhaOrdens.Text))
            //        {
            //            id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, "------------", txtSituacaoOrdens.Text);
            //        }
            //        else
            //        {
            //            id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, txtSenhaOrdens.Text, txtSituacaoOrdens.Text);
            //        }

            //        //Reseto os campos.
            //        txtAparelhoOrdens.Text = "";
            //        txtDefeitoOrdens.Text = "";
            //        txtSenhaOrdens.Text = "";
            //        txtSituacaoOrdens.Text = "";

            //        //Mensagem de Conclusao
            //        ms.InserirServicoSucesso();

            //        //Atualizo a tabela
            //        preencherTableServ.Preencher(table_OrdensServicos);
            //    }
            //    catch (Exception ex)
            //    {
            //        //Mensagem de Erro
            //        me.ErroInserirServico(ex);
            //    }
            //}
        }

        private void table_OrdensServicos_MouseLeave(object sender, EventArgs e)
        {
            table_OrdensServicos.ClearSelection();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //AtualizarAtrasosCores();
            preencherTableServ.Preencher(table_OrdensServicos);
        }

        private void table_OrdensServicos_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void table_OrdensServicos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AtualizarAtrasosCores();
        }
    }
}
