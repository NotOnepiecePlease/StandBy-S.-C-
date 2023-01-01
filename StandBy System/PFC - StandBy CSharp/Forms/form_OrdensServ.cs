using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Models;
using Syncfusion.Windows.Forms.Tools;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_OrdensServ : Form
    {
        private readonly BuscarDados buscarDados = new BuscarDados();
        private readonly DeletarDados deletarDados = new DeletarDados();
        private readonly PreencherComboBoxCliente preencherCombobox = new PreencherComboBoxCliente();
        private readonly PreencherTableOrdensServicos preencherTableServ = new PreencherTableOrdensServicos();
        private List<ClienteEstrutura> listClientesComId = new List<ClienteEstrutura>();
        private int[] corGeral = new int[3] { 0, 0, 0 };
        private int ultimoClienteAdicionadoID = 0;

        public form_OrdensServ(int[] _corRgb)
        {
            InitializeComponent();
            preencherTableServ.Preencher(table_OrdensServicos);
            CarregarComboxClientes();
            corGeral = _corRgb;
            MudarTodasCores();
            //multiColumnComboBox1.SelectedIndex = multiColumnComboBox1.Items.Count - 1;
            table_OrdensServicos.ClearSelection();
            timerAtualizarTabela.Start();
        }

        private void CarregarComboxClientes()
        {
            this.cmbCliente.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbCliente.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;

            listClientesComId = preencherCombobox.Preencher();

            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Cpf");
            dt.Columns.Add("⠀⠀⠀Telefone⠀⠀");
            //dt.Columns.Add("Recado");
            dt.Columns.Add("Nascimento");
            dt.Columns.Add("⠀⠀⠀⠀⠀⠀⠀⠀Endereco⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            dt.Columns.Add("⠀⠀⠀Bairro⠀⠀⠀");
            dt.Columns.Add("Estado");
            dt.Columns[0].ColumnMapping = MappingType.Hidden;

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            listClientesComId
                .OrderBy(x => x.Nome)
                .ToList()
                .ForEach(cliente =>
                {
                    //Pegando a id do ultimo cliente adicionado (ou o que tem MAIOR ID q da na mesma)
                    ultimoClienteAdicionadoID = cliente.ID > ultimoClienteAdicionadoID ? cliente.ID : ultimoClienteAdicionadoID;

                    dt.Rows.Add(new string[]
                    {
                        $"{cliente.ID}",
                        $"{cliente.Nome}",
                        $"{cliente.Cpf}",
                        $"{cliente.Telefone}",
                       // $"{cliente.TelefoneRecado}",
                        $"{cliente.DataNascimento}",
                        $"{cliente.Endereco}",
                        $"{cliente.Bairro}",
                        $"{cliente.Estado}"
                    });
                });

            DataView view = new DataView(dt);

            this.cmbCliente.DataSource = view;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.ValueMember = "ID";

            SetarComboboxComUltimoClienteAdicionado(dt);
        }

        private void SetarComboboxComUltimoClienteAdicionado(DataTable _dt)
        {
            //Pego a linha que tem o ultimo ID cadastrado
            DataRow[] rows = _dt.Select($"ID ='{ultimoClienteAdicionadoID}'");
            //Seto a index da combobox para a index dessa linha que peguei acima.
            cmbCliente.SelectedIndex = _dt.Rows.IndexOf(rows[0]);
        }

        public void AtualizarCoresCelulasTabela()
        {
            foreach (DataGridViewRow row in table_OrdensServicos.Rows)
            {
                try
                {
                    if (row.Cells[12].Value != DBNull.Value && Convert.ToInt32(row.Cells[13].Value) == 1)
                    {
                        //row.Cells[12] = é a coluna sv_previsao_entrega
                        DateTime dataEntrega = Convert.ToDateTime(row.Cells[12].Value);
                        DateTime dataAtual = DateTime.Now;

                        TimeSpan diasParaEntrega = dataEntrega.Subtract(dataAtual);

                        //0 = sem cor
                        //1 = verde
                        //2 = amarelo/laranja
                        //3 = vermelho
                        if (diasParaEntrega.TotalHours < 0)
                        //if (Convert.ToInt32(row.Cells[2].Value) == 3)
                        {
                            row.Cells[1].Style.BackColor = Color.Red;
                            row.Cells[1].Style.ForeColor = Color.Black;
                        }
                        else if (diasParaEntrega.TotalHours >= 0 && diasParaEntrega.TotalHours <= 12)
                        //else if (Convert.ToInt32(row.Cells[2].Value) == 2)
                        {
                            row.Cells[1].Style.BackColor = Color.Orange;
                            row.Cells[1].Style.ForeColor = Color.Black;
                        }
                        else if (diasParaEntrega.TotalHours > 12)
                        //else if (Convert.ToInt32(row.Cells[2].Value) == 1)
                        {
                            row.Cells[1].Style.BackColor = Color.Lime;
                            row.Cells[1].Style.ForeColor = Color.Black;
                        }
                        else
                        {
                            row.Cells[1].Style.BackColor = Color.FromArgb(30, 30, 46);
                            row.Cells[1].Style.ForeColor = Color.Gray;
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public void MudarTodasCores()
        {
            btnSenhaPadrao.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaPadrao.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaPadrao.onHoverState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaPadrao.onHoverState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaPadrao.OnIdleState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaPadrao.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaPadrao.OnPressedState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaPadrao.OnPressedState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnCadastrarOrdem.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnPesquisarCliente.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSituacaoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPesquisarCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtAcessoriosOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            contextMenuStrip1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        public void refreshTable()
        {
            preencherTableServ.Preencher(table_OrdensServicos);
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            preencherTableServ.PreencherServicosPorNomeCliente(table_OrdensServicos, txtPesquisarCliente.Text);
        }

        private void btnCadastrarOrdem_Click(object sender, EventArgs e)
        {
            //ComboBoxBaseDataBound combobox = multiColumnComboBox1 as ComboBoxBaseDataBound;
            //if (combobox.SelectedIndex != -1)
            //{
            //    //Sets the text of MultiColumnComboBox to the text in the first column of selected row.
            //    DataRowView drv = combobox.Items[combobox.SelectedIndex] as DataRowView;
            //    //combobox.Text = drv.Row[0].ToString();

            //    MessageBox.Show($"{drv.Row[0]}");
            //}
            //MessageBox.Show($"{ultimoClienteAdicionadoID}");
            CadastrarServico();
            CarregarComboxClientes();
        }

        private void CadastrarServico()
        {
            if (txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            {
                MessageBox.Show(@"Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAcessoriosOrdens.Text.Equals("Vieram junto c/ aparelho"))
            {
                DialogResult dialogResult = MessageBox.Show("O Aparelho veio com algum acessório com ele? (ex: carregador, capa, bolsa..)", "VERIFICAÇÃO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Volta pra tela pra digitar
                }
                else if (dialogResult == DialogResult.No)
                {
                    form_DiaEntrega formPrevisaoEntrega = new form_DiaEntrega(this, corGeral);
                    formPrevisaoEntrega.ShowDialog();
                }
            }
            else
            {
                form_DiaEntrega formPrevisaoEntrega = new form_DiaEntrega(this, corGeral);
                formPrevisaoEntrega.ShowDialog();
            }
        }

        private void txtAparelhoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text == @"Modelo do aparelho")
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
                txtAparelhoOrdens.Text = @"Modelo do aparelho";
                txtAparelhoOrdens.Font = new Font(txtAparelhoOrdens.Font, FontStyle.Italic);
                txtAparelhoOrdens.ForeColor = Color.Silver;
                txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtDefeitoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtDefeitoOrdens.Text == @"Digite o defeito")
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
                txtDefeitoOrdens.Text = @"Digite o defeito";
                txtDefeitoOrdens.Font = new Font(txtDefeitoOrdens.Font, FontStyle.Italic);
                txtDefeitoOrdens.ForeColor = Color.Silver;
                txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                //txtDefeitoOrdens.LineIdleColor = Color.White;
            }
        }

        private void txtSenhaOrdens_Enter(object sender, EventArgs e)
        {
            if (txtSenhaOrdens.Text == @"Digite a senha do celular")
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
                txtSenhaOrdens.Text = @"Digite a senha do celular";
                txtSenhaOrdens.Font = new Font(txtSenhaOrdens.Font, FontStyle.Italic);
                txtSenhaOrdens.ForeColor = Color.Silver;
                txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtSituacaoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtSituacaoOrdens.Text == @"Situação do aparelho")
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
                txtSituacaoOrdens.Text = @"Situação do aparelho";
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
                timerAtualizarTabela.Start();
            }
        }

        private void txtPesquisarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            timerAtualizarTabela.Stop();
            if (txtPesquisarCliente.Text == "")
            {
                preencherTableServ.Preencher(table_OrdensServicos);
                table_OrdensServicos.ClearSelection();
            }
            else
            {
                preencherTableServ.PreencherServicosPorNomeCliente(table_OrdensServicos, txtPesquisarCliente.Text);
                table_OrdensServicos.ClearSelection();
            }
        }

        private void table_OrdensServicos_DoubleClick(object sender, EventArgs e)
        {
            EditarUmServico();
        }

        public void EditarUmServico()
        {
            string _TELCliente = buscarDados.BuscarTelefoneCliente(Convert.ToInt32(table_OrdensServicos.SelectedCells[16].Value.ToString()));
            string _TEL_RECCliente = buscarDados.BuscarTelefoneRecadoCliente(Convert.ToInt32(table_OrdensServicos.SelectedCells[16].Value.ToString()));
            float lucro = float.Parse(table_OrdensServicos.SelectedCells[10].Value.ToString());
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);
            try
            {
                string _CPFCliente = buscarDados.BuscarCPFCliente(Convert.ToInt32(table_OrdensServicos.SelectedCells[16].Value.ToString()));
                editarServicos.txtCPFCliente.Text = _CPFCliente;
                editarServicos.txtAcessoriosEdit.Text = table_OrdensServicos.SelectedCells[14].Value.ToString();
            }
            catch (Exception)
            {
            }
            editarServicos.lblIDservico.Text = table_OrdensServicos.SelectedCells[0].Value.ToString();
            editarServicos.lblIDcliente.Text = table_OrdensServicos.SelectedCells[16].Value.ToString();
            editarServicos.dtpDataEdit.Value = Convert.ToDateTime(table_OrdensServicos.SelectedCells[1].Value.ToString());
            editarServicos.lblClienteNome.Text = table_OrdensServicos.SelectedCells[3].Value.ToString();
            editarServicos.txtClienteNome.Text = table_OrdensServicos.SelectedCells[3].Value.ToString();

            editarServicos.txtTelefoneCliente.Text = _TELCliente;
            editarServicos.txtTelefoneRecado.Text = _TEL_RECCliente;
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
                editarServicos.dtpDataEditPrevisao.FormatCustom = " ";
                editarServicos.dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
                editarServicos.chkSemData.Checked = true;
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
            DialogResult resultado = MessageBox.Show(@"Tem certeza que deseja deletar esse serviço?", "DELETAR SERVIÇO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int _idServico = int.Parse(table_OrdensServicos.SelectedCells[0].Value.ToString());
                deletarDados.DeletarServico(_idServico);
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
        }

        private void table_OrdensServicos_MouseLeave(object sender, EventArgs e)
        {
            if (txtPesquisarCliente.Text == "Digite o nome do cliente que deseja buscar os serviços")
            {
                table_OrdensServicos.ClearSelection();
                timerAtualizarTabela.Start();
            }
        }

        private void timerAtualizarTabela_Tick(object sender, EventArgs e)
        {
            //AtualizarAtrasosCores();
            preencherTableServ.Preencher(table_OrdensServicos);
            table_OrdensServicos.ClearSelection();
        }

        private void table_OrdensServicos_MouseEnter(object sender, EventArgs e)
        {
            timerAtualizarTabela.Stop();
        }

        private void table_OrdensServicos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AtualizarCoresCelulasTabela();
            //MessageBox.Show("Test");
        }

        private void btnOcultarComponentes_Click(object sender, EventArgs e)
        {
            btnPatternIcon.Visible = false;
            lblCliente.Visible = false;
            lblAparelho.Visible = false;
            lblDefeito.Visible = false;
            lblSenha.Visible = false;
            lblAcessoriosOrdens.Visible = false;
            //cmbClientes.Visible = false;
            cmbCliente.Visible = false;
            txtAparelhoOrdens.Visible = false;
            txtDefeitoOrdens.Visible = false;
            txtSenhaOrdens.Visible = false;
            txtAcessoriosOrdens.Visible = false;
            txtPesquisarCliente.Visible = false;
            btnCadastrarOrdem.Visible = false;
            btnPesquisarCliente.Visible = false;
            table_OrdensServicos.Size = new Size(form_StandBy.ActiveForm.Width - 2, 611);
            table_OrdensServicos.Location = new Point(3, 35);
            table_OrdensServicos.Anchor = AnchorStyles.Top;
            table_OrdensServicos.Anchor = AnchorStyles.Left;
            table_OrdensServicos.Anchor = AnchorStyles.Right;
            table_OrdensServicos.Anchor = AnchorStyles.Bottom;
            table_OrdensServicos.Refresh();
            table_OrdensServicos.Update();
            btnOcultarComponentes.Visible = false;
            btnVisivel.Visible = true;
        }

        private void btnVisivel_Click(object sender, EventArgs e)
        {
            //table_OrdensServicos.Size = new Size(form_StandBy.ActiveForm.Width - 2, 492);
            table_OrdensServicos.Size = new Size(form_StandBy.ActiveForm.Width - 2, 447);
            table_OrdensServicos.Location = new Point(3, 195);

            btnPatternIcon.Visible = true;
            lblCliente.Visible = true;
            lblAparelho.Visible = true;
            lblDefeito.Visible = true;
            lblSenha.Visible = true;
            lblAcessoriosOrdens.Visible = true;
            //cmbClientes.Visible = true;
            cmbCliente.Visible = true;
            txtAparelhoOrdens.Visible = true;
            txtDefeitoOrdens.Visible = true;
            txtSenhaOrdens.Visible = true;
            txtAcessoriosOrdens.Visible = true;
            txtPesquisarCliente.Visible = true;
            btnCadastrarOrdem.Visible = true;
            btnPesquisarCliente.Visible = true;
            btnOcultarComponentes.Visible = true;
            btnVisivel.Visible = false;
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

        private void verSenhaPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (form_PasswordPatternExibir passShow = new form_PasswordPatternExibir(corGeral))
            {
                passShow.pictureBox1.Image = ConvertByteArrayToImage(buscarDados.BuscarImagem(table_OrdensServicos.SelectedCells[0].Value.ToString()));
                if (passShow.pictureBox1.Image == null)
                {
                    passShow.lblSemPadrao.Visible = true;
                    passShow.lblSemPadrao.Location = new Point(49, 102);
                    passShow.lblDesejaCadastrar.Visible = false;
                    passShow.btnSim.Visible = false;
                    passShow.btnNao.Visible = false;
                }
                else
                {
                    passShow.lblSemPadrao.Visible = false;
                    passShow.lblDesejaCadastrar.Visible = false;
                    passShow.btnSim.Visible = false;
                    passShow.btnNao.Visible = false;
                }

                passShow.ShowDialog();
            }
        }

        private void btnSenhaPadrao_Click(object sender, EventArgs e)
        {
            form_PasswordPattern pp = new form_PasswordPattern(corGeral);
            pp.ShowDialog();
        }

        private void txtAcessoriosOrdens_Enter(object sender, EventArgs e)
        {
            if (txtAcessoriosOrdens.Text == "Vieram junto c/ aparelho")
            {
                txtAcessoriosOrdens.Text = "";
                txtAcessoriosOrdens.Font = new Font(txtAcessoriosOrdens.Font, FontStyle.Regular);
                txtAcessoriosOrdens.LineIdleColor = Color.White;
                txtAcessoriosOrdens.ForeColor = Color.White;
            }
        }

        private void txtAcessoriosOrdens_Leave(object sender, EventArgs e)
        {
            if (txtAcessoriosOrdens.Text == "" || string.IsNullOrWhiteSpace(txtAcessoriosOrdens.Text))
            {
                txtAcessoriosOrdens.Text = "Vieram junto c/ aparelho";
                txtAcessoriosOrdens.Font = new Font(txtAcessoriosOrdens.Font, FontStyle.Italic);
                txtAcessoriosOrdens.ForeColor = Color.Silver;
                txtAcessoriosOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void btnPatternIcon_Click(object sender, EventArgs e)
        {
            form_PasswordPattern pp = new form_PasswordPattern(corGeral);
            pp.ShowDialog();
        }

        private void txtAcessoriosOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtAcessoriosOrdens_KeyUp(object sender, KeyEventArgs e)
        {
            //Apenas um codigo de estudos para entender a diferença entre as propriedades do evento de key
            //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //messageBoxCS.AppendFormat("{0} = {1}", "Alt", e.Alt);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Control", e.Control);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Handled", e.Handled);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "KeyCode", e.KeyCode);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "KeyValue", e.KeyValue);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "KeyData", e.KeyData);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Modifiers", e.Modifiers);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Shift", e.Shift);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "SuppressKeyPress", e.SuppressKeyPress);
            //messageBoxCS.AppendLine();
            //MessageBox.Show(messageBoxCS.ToString(), "KeyDown Event");
        }

        private void multiColumnComboBox1_Click(object sender, EventArgs e)
        {
            cmbCliente.DroppedDown = true;
        }

        private void multiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxBaseDataBound combobox = cmbCliente as ComboBoxBaseDataBound;
            if (combobox.SelectedIndex != -1)
            {
                DataRowView drv = combobox.Items[combobox.SelectedIndex] as DataRowView;
                //lblIdCliente.Text = listClientesComId.ElementAt(multiColumnComboBox1.SelectedIndex).ID.ToString();
                lblIdCliente.Text = drv.Row[0].ToString();
            }
        }
    }
}