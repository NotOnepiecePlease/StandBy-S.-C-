using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Correios;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes : Form
    {
        private PreencherTableClientes preencherClientes = new PreencherTableClientes();
        private DeletarDados dd = new DeletarDados();
        private VerificarExistencia ve = new VerificarExistencia();
        private InserirDados id = new InserirDados();
        private BuscarDados bd = new BuscarDados();
        private int[] corGeral = new int[3] { 0, 0, 0 };
        private int contadorCNPJ = 0;
        private int contadorCPF = 0;
        private const string VALOR_PADRAO_DADOS_CLIENTE = "";

        public form_CadastroClientes(int[] _corRGB)
        {
            InitializeComponent();
            preencherClientes.Preencher(table_Clientes);
            corGeral = _corRGB;
            MudarTodasCores();
            lblQuantidadeClientes.Text = bd.buscarQuantidadeClientes().ToString();
        }

        public void refreshTable()
        {
            preencherClientes.Preencher(table_Clientes);
        }

        public void MudarTodasCores()
        {
            txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtTelefoneRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnCadastrarCliente.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //table_Clientes.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            contextMenuStrip1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkSemCPF.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkSemCPF.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //chkCnpj.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkCnpj.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //chkTelRecados.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkTelRecados.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //CadastrarTestes();
            CadastrarNovoCliente();
        }

        public void chamarEdicaoCliente()
        {
            form_CadastroClientes_Edit editarCliente = new form_CadastroClientes_Edit(this, corGeral);

            string cpfSemformatar = table_Clientes.SelectedCells[2].Value.ToString().Replace(".", "").Replace("-", "").Replace("/", "");
            editarCliente.lblID.Text = table_Clientes.SelectedCells[0].Value.ToString();
            editarCliente.txtNomeCliente.Text = table_Clientes.SelectedCells[1].Value.ToString();
            editarCliente.txtCpf.Text = cpfSemformatar;
            editarCliente.txtTelefone.Text = table_Clientes.SelectedCells[3].Value.ToString();
            editarCliente.txtTelefoneRecados.Text = table_Clientes.SelectedCells[4].Value.ToString();
            editarCliente.txtNomeRecado.Text = table_Clientes.SelectedCells[5].Value.ToString();
            editarCliente.txtParentescoRecado.Text = table_Clientes.SelectedCells[6].Value.ToString();
            editarCliente.chkMasculino.Checked = table_Clientes.SelectedCells[7].Value.ToString() == "M";
            editarCliente.chkFeminino.Checked = table_Clientes.SelectedCells[7].Value.ToString() == "F";

            if (table_Clientes.SelectedCells[8].Value.ToString() == "")
            {
                editarCliente.dtpDataNascimento.Value = Convert.ToDateTime("01/01/1753");
                editarCliente.dtpDataNascimento.ForeColor = Color.Transparent;
                editarCliente.txtDataNascimento.Text = "SEM DATA";
            }
            else
            {
                editarCliente.dtpDataNascimento.Value = Convert.ToDateTime(table_Clientes.SelectedCells[8].Value.ToString());
                editarCliente.txtDataNascimento.Text = Convert.ToDateTime(table_Clientes.SelectedCells[8].Value.ToString()).ToShortDateString();
            }

            editarCliente.txtCEP.Text = table_Clientes.SelectedCells[9].Value.ToString();
            editarCliente.txtRua.Text = table_Clientes.SelectedCells[10].Value.ToString();
            editarCliente.txtComplemento.Text = table_Clientes.SelectedCells[11].Value.ToString();
            editarCliente.txtBairro.Text = table_Clientes.SelectedCells[12].Value.ToString();
            editarCliente.txtCidade.Text = table_Clientes.SelectedCells[13].Value.ToString();
            editarCliente.txtEstado.Text = table_Clientes.SelectedCells[14].Value.ToString();
            editarCliente.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamarEdicaoCliente();
            //refreshTable();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(@"Tem certeza que deseja deletar esse cliente?", "DELETAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int idcliente = int.Parse(table_Clientes.SelectedCells[0].Value.ToString());
                dd.DeletarCliente(idcliente);
                refreshTable();
            }
        }

        private void txtPesquisarCADCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisarCADCliente.Text == "")
            {
                preencherClientes.Preencher(table_Clientes);
            }
            else
            {
                try
                {
                    preencherClientes.PesquisarClienteNome(txtPesquisarCADCliente.Text, table_Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
                }
            }
        }

        public void CadastrarNovoCliente()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || txtNomeCliente.Text == "Nome do Cliente")
            {
                MessageBox.Show(@"Campos de nome está vazio, favor preencha-o", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkMasculino.Checked == false && chkFeminino.Checked == false)
            {
                MessageBox.Show(@"Favor preencher o genero do cliente!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrWhiteSpace(txtDataNascimento.Text) && txtDataNascimento.Text != "Data de Nascimento")
            {
                try
                {
                    Convert.ToDateTime(txtDataNascimento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Digite uma data valida Ex: 26/08/1995\nou deixe a data em branco. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                //Pegar os dados dos campos
                string nome = txtNomeCliente.Text;
                string cpf = (txtCPFCliente.Text == "CPF ou CNPJ do Cliente") ? "SEM CPF/CNPJ" : txtCPFCliente.Text;
                string telPrincipal = (txtTelefoneCliente.Text == "Telefone Principal do Cliente") ? VALOR_PADRAO_DADOS_CLIENTE : txtTelefoneCliente.Text;
                string telRecados = (txtTelefoneRecado.Text == "Telefone de Recados do Cliente") ? VALOR_PADRAO_DADOS_CLIENTE : txtTelefoneRecado.Text;
                string nomeRecados = (txtNomeRecado.Text == "Nome de quem vai receber o recado") ? VALOR_PADRAO_DADOS_CLIENTE : txtNomeRecado.Text;
                string parentescoRecados = (txtParentescoRecado.Text == "Parentesco de quem vai receber o recado") ? VALOR_PADRAO_DADOS_CLIENTE : txtParentescoRecado.Text;
                string cep = (txtCEP.Text == "Ex: 42803317") ? VALOR_PADRAO_DADOS_CLIENTE : txtCEP.Text;
                string endereco = (txtEndereco.Text == "Ex: Rua Segundo Cendes, 197B") ? VALOR_PADRAO_DADOS_CLIENTE : txtEndereco.Text;
                string complemento = (txtComplemento.Text == "Ex: Casa") ? VALOR_PADRAO_DADOS_CLIENTE : txtComplemento.Text;
                string bairro = (txtBairro.Text == "Ex: Gleba B") ? VALOR_PADRAO_DADOS_CLIENTE : txtBairro.Text;
                string cidade = (txtCidade.Text == "Ex: Camaçari") ? VALOR_PADRAO_DADOS_CLIENTE : txtCidade.Text;
                string estado = (txtEstado.Text == "Ex: Bahia") ? VALOR_PADRAO_DADOS_CLIENTE : txtEstado.Text;
                string sexo = (chkMasculino.Checked == true) ? "M" : "F";
                string dataNascimento = (txtDataNascimento.Text == "Data de Nascimento") ? VALOR_PADRAO_DADOS_CLIENTE : txtDataNascimento.Text;
                id.InserirCliente(nome, cpf, telPrincipal, telRecados, nomeRecados, parentescoRecados,
                    sexo, dataNascimento, cep, endereco, complemento, bairro, cidade, estado);
            }

            ResetarCampos();
            refreshTable();
        }

        private void ResetarCampos()
        {
            //Limpar os campos
            txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            txtPesquisarCADCliente.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Italic);
            txtPesquisarCADCliente.ForeColor = Color.Silver;
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtNomeCliente.Text = "Nome do Cliente";
            txtNomeCliente.Font = new Font(txtNomeCliente.Font, FontStyle.Italic);
            txtNomeCliente.ForeColor = Color.Silver;
            txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;
            txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            txtTelefoneRecado.ForeColor = Color.Silver;
            txtTelefoneRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCPFCliente.Text = "CPF ou CNPJ do Cliente";
            txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
            txtCPFCliente.ForeColor = Color.Silver;
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtDataNascimento.Text = "Data de Nascimento";
            txtDataNascimento.Font = new Font(txtDataNascimento.Font, FontStyle.Italic);
            txtDataNascimento.ForeColor = Color.Silver;
            txtDataNascimento.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;
            txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            txtTelefoneRecado.ForeColor = Color.Silver;
            txtTelefoneRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtParentescoRecado.Text = "Parentesco de quem vai receber o recado";
            txtParentescoRecado.Font = new Font(txtParentescoRecado.Font, FontStyle.Italic);
            txtParentescoRecado.ForeColor = Color.Silver;
            txtParentescoRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtNomeRecado.Text = "Nome de quem vai receber o recado";
            txtNomeRecado.Font = new Font(txtNomeRecado.Font, FontStyle.Italic);
            txtNomeRecado.ForeColor = Color.Silver;
            txtNomeRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCEP.Text = "Ex: 42803317";
            txtCEP.Font = new Font(txtCEP.Font, FontStyle.Italic);
            txtCEP.ForeColor = Color.Silver;
            txtCEP.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtEndereco.Text = "Ex: Rua Segundo Cendes, 197B";
            txtEndereco.Font = new Font(txtEndereco.Font, FontStyle.Italic);
            txtEndereco.ForeColor = Color.Silver;
            txtEndereco.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCidade.Text = "Ex: Camaçari";
            txtCidade.Font = new Font(txtCidade.Font, FontStyle.Italic);
            txtCidade.ForeColor = Color.Silver;
            txtCidade.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtComplemento.Text = "Ex: Casa";
            txtComplemento.Font = new Font(txtComplemento.Font, FontStyle.Italic);
            txtComplemento.ForeColor = Color.Silver;
            txtComplemento.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtBairro.Text = "Ex: Gleba B";
            txtBairro.Font = new Font(txtBairro.Font, FontStyle.Italic);
            txtBairro.ForeColor = Color.Silver;
            txtBairro.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtEstado.Text = "Ex: Bahia";
            txtEstado.Font = new Font(txtEstado.Font, FontStyle.Italic);
            txtEstado.ForeColor = Color.Silver;
            txtEstado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            chkMasculino.Checked = false;
            chkFeminino.Checked = false;
        }

        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }

        private void txtTelefoneCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }

        private void table_Clientes_DoubleClick(object sender, EventArgs e)
        {
            chamarEdicaoCliente();
        }

        private void txtTelefoneRecado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }

        private void txtCPFCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex pattern = new Regex("[./-]");
            string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
            if (cpfApenasDigitos.Length <= 12)
            {
                contadorCNPJ = 0;
                if (contadorCPF == 0)
                {
                    FormatarTodaStringParaCpf(sender);
                    contadorCPF++;
                }
                else
                {
                    TextBox CPF = sender as TextBox;
                    if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    {
                        CPF.SelectionStart = CPF.Text.Length + 1;

                        if (CPF.Text.Length == 3 || CPF.Text.Length == 7)
                        {
                            CPF.Text += ".";
                        }
                        else if (CPF.Text.Length == 11)
                        {
                            CPF.Text += "-";
                        }
                        CPF.SelectionStart = CPF.Text.Length + 1;
                    }
                }
            }
            else
            {
                contadorCPF = 0;
                if (contadorCNPJ == 0)
                {
                    FormatarTodaStringParaCnpj(sender);
                    contadorCNPJ++;
                }
                else
                {
                    TextBox CPF = sender as TextBox;
                    if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    {
                        CPF.SelectionStart = CPF.Text.Length + 1;

                        if (CPF.Text.Length == 2 || CPF.Text.Length == 6)
                        {
                            CPF.Text += ".";
                        }
                        else if (CPF.Text.Length == 10)
                        {
                            CPF.Text += "/";
                        }
                        else if (CPF.Text.Length == 15)
                        {
                            CPF.Text += "-";
                        }
                        CPF.SelectionStart = CPF.Text.Length + 1;
                    }
                }
            }
        }

        private void FormatarTodaStringParaCpf(object sender)
        {
            Regex pattern = new Regex("[./-]");
            //string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
            TextBox CPF = sender as TextBox;

            string cpfTexto = pattern.Replace(txtCPFCliente.Text, "");
            char[] cpfCaracteres = cpfTexto.ToCharArray();
            txtCPFCliente.Text = "";
            foreach (char caractere in cpfCaracteres)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;
                txtCPFCliente.Text += caractere;
                if (CPF.Text.Length == 3 || CPF.Text.Length == 7)
                {
                    CPF.Text += ".";
                }
                else if (CPF.Text.Length == 11)
                {
                    CPF.Text += "-";
                }
                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        private void FormatarTodaStringParaCnpj(object sender)
        {
            Regex pattern = new Regex(@"[./-]");
            //string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
            TextBox CPF = sender as TextBox;

            string cpfTexto = pattern.Replace(txtCPFCliente.Text, "");
            char[] cpfCaracteres = cpfTexto.ToCharArray();
            txtCPFCliente.Text = "";
            foreach (char caractere in cpfCaracteres)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;
                txtCPFCliente.Text += caractere;
                if (CPF.Text.Length == 2 || CPF.Text.Length == 6)
                {
                    CPF.Text += ".";
                }
                else if (CPF.Text.Length == 10)
                {
                    CPF.Text += "/";
                }
                else if (CPF.Text.Length == 15)
                {
                    CPF.Text += "-";
                }
                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        private void txtCPFCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }

        private void separatorCPF_MouseEnter(object sender, EventArgs e)
        {
            separatorCPF.LineColor = Color.Lavender;
        }

        private void separatorCPF_MouseLeave(object sender, EventArgs e)
        {
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void txtCPFCliente_MouseEnter(object sender, EventArgs e)
        {
            separatorCPF.LineColor = Color.Lavender;
        }

        private void txtCPFCliente_MouseLeave(object sender, EventArgs e)
        {
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void txtTelefoneRecado_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTelefoneRecado.Text == "Telefone de Recados do Cliente" || txtTelefoneRecado.Text == "")
            {
                txtNomeRecado.Enabled = false;
                txtParentescoRecado.Enabled = false;
            }
            else
            {
                txtNomeRecado.Enabled = true;
                txtParentescoRecado.Enabled = true;
            }
        }

        private void SetarCorDaLinhaETexto_ENTER(BunifuMaterialTextbox _textbox, string _texto)
        {
            if (_textbox.Text == _texto)
            {
                _textbox.Text = "";
                _textbox.Font = new Font(_textbox.Font, FontStyle.Regular);
                _textbox.LineIdleColor = Color.White;
                _textbox.ForeColor = Color.White;
            }
        }

        private void SetarCorDaLinhaETexto_ENTER(BunifuMetroTextbox _textbox, string _texto)
        {
            if (_textbox.Text == _texto)
            {
                _textbox.Text = "";
                _textbox.Font = new Font(_textbox.Font, FontStyle.Regular);
                _textbox.BorderColorIdle = Color.White;
                _textbox.ForeColor = Color.White;
            }
        }

        private void SetarCorDaLinhaETexto_LEAVE(BunifuMaterialTextbox _textbox, string _texto)
        {
            if (_textbox.Text == "")
            {
                _textbox.Text = _texto;
                _textbox.Font = new Font(_textbox.Font, FontStyle.Italic);
                _textbox.ForeColor = Color.Silver;
                _textbox.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void SetarCorDaLinhaETexto_LEAVE(BunifuMetroTextbox _textbox, string _texto)
        {
            if (_textbox.Text == "")
            {
                _textbox.Text = _texto;
                _textbox.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Italic);
                _textbox.ForeColor = Color.Silver;
                _textbox.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtNomeCliente_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtNomeCliente, "Nome do Cliente");
        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtNomeCliente, "Nome do Cliente");
        }

        private void txtTelefoneCliente_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtTelefoneCliente, "Telefone Principal do Cliente");
        }

        private void txtTelefoneCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtTelefoneCliente, "Telefone Principal do Cliente");
        }

        private void txtPesquisarCADCliente_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtPesquisarCADCliente, "Digite o nome do cliente que deseja buscar os serviços");
        }

        private void txtPesquisarCADCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtPesquisarCADCliente, "Digite o nome do cliente que deseja buscar os serviços");
            if (txtPesquisarCADCliente.Text == "")
            {
                preencherClientes.Preencher(table_Clientes);
            }
        }

        private void txtTelefoneRecado_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtTelefoneRecado, "Telefone de Recados do Cliente");
        }

        private void txtTelefoneRecado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtTelefoneRecado, "Telefone de Recados do Cliente");
        }

        private void txtCPFCliente_Enter(object sender, EventArgs e)
        {
            //Na textbox de CPF eu nao utilizei o metodo SetarCorDaLinhaETexto porque ele usa o textbox comum
            //preferi nao criar um metodo apenas para 1 textbox.
            if (txtCPFCliente.Text == "CPF ou CNPJ do Cliente")
            {
                txtCPFCliente.Text = "";
                txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Regular);
                separatorCPF.LineColor = Color.White;
                txtCPFCliente.ForeColor = Color.White;
            }
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            //Na textbox de CPF eu nao utilizei o metodo SetarCorDaLinhaETexto porque ele usa o textbox comum
            //preferi nao criar um metodo apenas para 1 textbox.
            if (txtCPFCliente.Text == "")
            {
                txtCPFCliente.Text = "CPF ou CNPJ do Cliente";
                txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
                txtCPFCliente.ForeColor = Color.Silver;
                separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtParentescoRecado_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtParentescoRecado, "Parentesco de quem vai receber o recado");
        }

        private void txtParentescoRecado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtParentescoRecado, "Parentesco de quem vai receber o recado");
        }

        private void txtNomeRecado_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtNomeRecado, "Nome de quem vai receber o recado");
        }

        private void txtNomeRecado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtNomeRecado, "Nome de quem vai receber o recado");
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtCEP, "Ex: 42803317");
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCEP.Text == "")
                {
                    SetarCorDaLinhaETexto_LEAVE(txtCEP, "Ex: 42803317");
                }
                else if (txtCEP.Text.Length < 8 || txtCEP.Text.Length > 8)
                {
                    MessageBox.Show("Digite um CEP valido!\nEx: 42803317", "Erro CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var endereco = correiosApi.consultaCEP(txtCEP.Text);

                    txtEndereco.Text = endereco.end ?? "------";
                    txtBairro.Text = endereco.bairro ?? "------";
                    txtCidade.Text = endereco.cidade ?? "------";
                    txtComplemento.Text = endereco.complemento ?? "------";
                    txtEstado.Text = endereco.uf ?? "------";
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(exception);
                //throw;
            }
        }

        private void txtRua_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtEndereco, "Ex: Rua Segundo Cendes, 197B");
        }

        private void txtRua_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtEndereco, "Ex: Rua Segundo Cendes, 197B");
        }

        private void txtComplemento_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtComplemento, "Ex: Casa");
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtComplemento, "Ex: Casa");
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtBairro, "Ex: Gleba B");
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtBairro, "Ex: Gleba B");
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtCidade, "Ex: Camaçari");
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtCidade, "Ex: Camaçari");
        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtEstado, "Ex: Bahia");
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtEstado, "Ex: Bahia");
        }

        private void chkMasculino_Click(object sender, EventArgs e)
        {
            if (chkMasculino.Checked == true)
            {
                chkFeminino.Checked = false;
            }
            else
            {
                chkFeminino.Checked = true;
            }
        }

        private void chkFeminino_Click(object sender, EventArgs e)
        {
            if (chkFeminino.Checked == true)
            {
                chkMasculino.Checked = false;
            }
            else
            {
                chkMasculino.Checked = true;
            }
        }

        private void chkMasculino_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkMasculino.Checked)
            {
                chkFeminino.Checked = false;
            }
        }

        private void chkFeminino_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkFeminino.Checked)
            {
                chkMasculino.Checked = false;
            }
        }

        private void txtDataNascimento_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtDataNascimento, "Data de Nascimento");
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtDataNascimento, "Data de Nascimento");
        }
    }
}