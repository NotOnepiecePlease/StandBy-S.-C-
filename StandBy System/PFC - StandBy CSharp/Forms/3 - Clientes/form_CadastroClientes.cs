using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes;
using PFC___StandBy_CSharp.APIs.CEP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Properties;
using PFC___StandBy_CSharp.Utils;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes : Form
    {
        private PreencherTableClientes preencherTableClientes = new PreencherTableClientes();
        private DeletarDados dd = new DeletarDados();
        private InserirDados id = new InserirDados();
        private BuscarDados bd = new BuscarDados();

        private int[] corGeral;
        private int contadorCNPJ = 0;
        private int contadorCPF = 0;
        private const string VALOR_PADRAO_DADOS_CLIENTE = "";

        public form_CadastroClientes(int[] _corRGB)
        {
            InitializeComponent();

            //CarregarComboboxCidades();
            preencherTableClientes.Preencher(table_Clientes);
            corGeral = _corRGB;
            MudarTodasCores();
            lblQuantidadeClientes.Text = bd.buscarQuantidadeClientes().ToString();
            CheckForIllegalCrossThreadCalls = false;

            //Preencher Combobox de Cidades
            //Cidades.BuscarListaCidades();
            //preencherComboboxCliente.Preencher(txtNomeCliente, cmbCidades, lblCidades_Carregando, listboxCidades);
            CentralizarTextoTextboxes();
            //CarregarComboxClientes();
            InicializarComboboxEstadosCidades();
            txtNomeCliente.Focus();
        }

        private void InicializarComboboxEstadosCidades()
        {
            //Estados
            List<string> estados = new List<string>
            {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO",
                "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
                "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            };
            cmbEstados.Properties.DataSource = estados;
            cmbEstados.Properties.PopupFormSize = new Size(206, 300);

            //Cidades
            string[] cidadesSeparadas = Resources.Cidades.Split('\n');
            List<string> products = new List<string>();
            foreach (var VARIABLE in cidadesSeparadas)
            {
                products.Add(VARIABLE);
            }
            cmbCidades.Properties.DataSource = products;
        }
        public void refreshTable()
        {
            preencherTableClientes.Preencher(table_Clientes);
        }
        public void MudarTodasCores()
        {
            //txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menuBotaoDireitoTabela.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnCadastrarCliente.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnCadastrarCliente.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnCadastrarCliente.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //chkMasculino.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkMasculino.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkFeminino.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkFeminino.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        public void CadastrarNovoCliente()
        {
            bool teste = Cidades.listCidades.Exists(x => x.Equals(cmbCidades.Text));
            if (teste != true)
            {
                MessageBox.Show($"A Cidade que você digitou não existe, certifique-se de que digitou corretamente" +
                                $" utilizando o recurso de 'Auto-Complete' do campo onde é preenchida a cidade, desta" +
                                $" forma, você garante que o nome da cidade será preenchido sem erros.", "AVISO"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDataNascimento.Text) && txtDataNascimento.Text != "Data de Nascimento")
            {
                try
                {
                    var gambi = Convert.ToDateTime(txtDataNascimento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Digite uma data valida Ex: 26/08/1995\nou deixe a data em branco. ", "ERRO"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || txtNomeCliente.Text == "Nome do Cliente")
            {
                MessageBox.Show(@"Campos de nome está vazio, favor preencha-o", "ATENÇÃO!", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else if (chkMasculino.Checked == false && chkFeminino.Checked == false)
            {
                MessageBox.Show(@"Favor preencher o genero do cliente!", "ATENÇÃO!", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                //Pegar os dados dos campos
                string nome = txtNomeCliente.Text;
                string cpf = (txtCPFCliente.Text == "CPF ou CNPJ do Cliente") || (txtCPFCliente.Text == "")
                    ? "SEM CPF/CNPJ"
                    : txtCPFCliente.Text;
                string telPrincipal =
                    (txtTelefoneCliente.Text == "Telefone Principal do Cliente") || (txtTelefoneCliente.Text == "")
                        ? VALOR_PADRAO_DADOS_CLIENTE
                        : txtTelefoneCliente.Text;
                string telRecados =
                    (txtTelefoneRecado.Text == "Telefone de Recados do Cliente") || (txtTelefoneRecado.Text == "")
                        ? VALOR_PADRAO_DADOS_CLIENTE
                        : txtTelefoneRecado.Text;
                string nomeRecados =
                    (txtNomeRecado.Text == "Nome de quem vai receber o recado") || (txtNomeRecado.Text == "")
                        ? VALOR_PADRAO_DADOS_CLIENTE
                        : txtNomeRecado.Text;
                string parentescoRecados =
                    (txtParentescoRecado.Text == "Parentesco de quem vai receber o recado") ||
                    (txtParentescoRecado.Text == "")
                        ? VALOR_PADRAO_DADOS_CLIENTE
                        : txtParentescoRecado.Text;
                string cep = (txtCEP.Text == "Ex: 42803317") || (txtCEP.Text == "")
                    ? VALOR_PADRAO_DADOS_CLIENTE
                    : txtCEP.Text;
                string endereco = (txtEndereco.Text == "Ex: Rua Segundo Cendes, 197B") || (txtEndereco.Text == "")
                    ? VALOR_PADRAO_DADOS_CLIENTE
                    : txtEndereco.Text;
                string complemento = (txtComplemento.Text == "Ex: Casa") || (txtComplemento.Text == "")
                    ? VALOR_PADRAO_DADOS_CLIENTE
                    : txtComplemento.Text;
                string bairro = (txtBairro.Text == "Ex: Gleba B") || (txtBairro.Text == "")
                    ? VALOR_PADRAO_DADOS_CLIENTE
                    : txtBairro.Text;
                string cidade = (cmbCidades.Text == "Ex: Camaçari") || (cmbCidades.Text == "")
                    ? VALOR_PADRAO_DADOS_CLIENTE
                    : cmbCidades.Text;

                //string cidade = (cmbCidades.Text == "Ex: Camaçari") || (cmbCidades.Text == "") ? VALOR_PADRAO_DADOS_CLIENTE : cmbCidades.Text;
                string estado = (cmbEstados.Text == "Ex: BA") || (cmbEstados.Text == "")
                    ? VALOR_PADRAO_DADOS_CLIENTE
                    : cmbEstados.Text;
                string sexo = (chkMasculino.Checked == true) ? "M" : "F";
                string dataNascimento =
                    (txtDataNascimento.Text == "Data de Nascimento") || (txtDataNascimento.Text == "")
                        ? VALOR_PADRAO_DADOS_CLIENTE
                        : txtDataNascimento.Text;
                id.InserirCliente(nome, cpf, telPrincipal, telRecados, nomeRecados, parentescoRecados,
                    sexo, dataNascimento, cep, endereco, complemento, bairro, cidade, estado);
            }

            ResetarCampos();
            refreshTable();
        }
        public void chamarEdicaoCliente()
        {
            form_CadastroClientes_Edit editarCliente = new form_CadastroClientes_Edit(this, corGeral);
            string cpf = table_Clientes.SelectedCells[2].Value.ToString();
            string cpfSemformatar = cpf.Replace(".", "").Replace("-", "").Replace("/", "");
            editarCliente.lblID.Text = table_Clientes.SelectedCells[0].Value.ToString();
            editarCliente.txtNomeCliente.Text = table_Clientes.SelectedCells[1].Value.ToString();

            //editarCliente.txtCPFCliente.Text = cpf == "SEM CPF/CNPJ" ? cpf : cpfSemformatar;
            editarCliente.txtCPFCliente.Text = cpf;
            editarCliente.txtTelefone.Text = table_Clientes.SelectedCells[3].Value.ToString();
            editarCliente.txtTelefoneRecados.Text = table_Clientes.SelectedCells[4].Value.ToString();
            editarCliente.txtNomeRecado.Text = table_Clientes.SelectedCells[5].Value.ToString();
            editarCliente.txtParentescoRecado.Text = table_Clientes.SelectedCells[6].Value.ToString();
            editarCliente.chkMasculino.Checked = table_Clientes.SelectedCells[7].Value.ToString() == "M";
            editarCliente.chkFeminino.Checked = table_Clientes.SelectedCells[7].Value.ToString() == "F";

            if (table_Clientes.SelectedCells[8].Value.ToString() == "")
            {
                //editarCliente.dtpDataNascimento.Value = Convert.ToDateTime("01/01/1753");
                //editarCliente.dtpDataNascimento.ForeColor = Color.Transparent;
                editarCliente.txtDataNascimento.Text = "SEM DATA";
            }
            else
            {
                //editarCliente.dtpDataNascimento.Value = Convert.ToDateTime(table_Clientes.SelectedCells[8].Value.ToString());
                editarCliente.txtDataNascimento.Text =
                    Convert.ToDateTime(table_Clientes.SelectedCells[8].Value.ToString()).ToShortDateString();
            }

            editarCliente.txtCEP.Text = table_Clientes.SelectedCells[9].Value.ToString();
            editarCliente.txtRua.Text = table_Clientes.SelectedCells[10].Value.ToString();
            editarCliente.txtComplemento.Text = table_Clientes.SelectedCells[11].Value.ToString();
            editarCliente.txtBairro.Text = table_Clientes.SelectedCells[12].Value.ToString();
            editarCliente.cmbCidades.Text = table_Clientes.SelectedCells[13].Value.ToString();
            editarCliente.cmbEstados.Text = table_Clientes.SelectedCells[14].Value.ToString();
            if (editarCliente.cmbCidades.Text != "" && editarCliente.cmbCidades.Text != "Ex: Camaçari")
            {
                editarCliente.isTemCidadeCadastrada = true;
            }

            //editarCliente.txtEstado.Text = table_Clientes.SelectedCells[14].Value.ToString();
            editarCliente.ShowDialog();
        }
        private void BuscarCepAPI()
        {
            try
            {
                if (txtCEP.Text == "")
                {
                    IniciarStyleTextsEndereco();
                    SetarCorDaLinhaETexto_LEAVE(txtCEP, "Ex: 42803317");
                }
                else if (txtCEP.Text.Length < 8 || txtCEP.Text.Length > 8)
                {
                    IniciarStyleTextsEndereco();
                    MessageBox.Show("Digite um CEP valido!\nEx: 42803317", "Erro CEP", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
                else
                {
                    var enderecoRetornado = CepApi.Buscar(txtCEP.Text);

                    txtEndereco.Text = enderecoRetornado[0].Endereco;
                    txtBairro.Text = enderecoRetornado[0].Bairro;
                    cmbCidades.Text = enderecoRetornado[0].Cidade;
                    txtComplemento.Text = enderecoRetornado[0].Complemento;
                    cmbEstados.Text = enderecoRetornado[0].UF;
                    ResetarStyleTextsEndereco();
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(exception);
                //throw;
            }
        }
        private void ResetarStyleTextsEndereco()
        {
            txtCEP.Font = new Font(txtCEP.Font, FontStyle.Regular);
            txtCEP.ForeColor = Color.White;

            txtEndereco.Font = new Font(txtEndereco.Font, FontStyle.Regular);
            txtEndereco.ForeColor = Color.White;

            txtBairro.Font = new Font(txtBairro.Font, FontStyle.Regular);
            txtBairro.ForeColor = Color.White;

            txtComplemento.Font = new Font(txtComplemento.Font, FontStyle.Regular);
            txtComplemento.ForeColor = Color.White;

            cmbCidades.Font = new Font(cmbCidades.Font, FontStyle.Regular);
            cmbCidades.ForeColor = Color.White;

            cmbEstados.Font = new Font(cmbEstados.Font, FontStyle.Regular);
            cmbEstados.ForeColor = Color.White;
        }
        private void IniciarStyleTextsEndereco()
        {
            txtCEP.Font = new Font(txtCEP.Font, FontStyle.Italic);
            txtCEP.ForeColor = Color.Silver;

            txtEndereco.Font = new Font(txtEndereco.Font, FontStyle.Italic);
            txtEndereco.ForeColor = Color.Silver;

            txtBairro.Font = new Font(txtBairro.Font, FontStyle.Italic);
            txtBairro.ForeColor = Color.Silver;

            txtComplemento.Font = new Font(txtComplemento.Font, FontStyle.Italic);
            txtComplemento.ForeColor = Color.Silver;

            cmbCidades.Font = new Font(cmbCidades.Font, FontStyle.Italic);
            cmbCidades.ForeColor = Color.Silver;

            cmbEstados.Font = new Font(cmbEstados.Font, FontStyle.Italic);
            cmbEstados.ForeColor = Color.Silver;
        }
        private void CentralizarTextoTextboxes()
        {
            txtEndereco.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            txtCEP.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            txtComplemento.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            txtBairro.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            cmbEstados.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            txtDataNascimento.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
        }
        private void ResetarCampos()
        {
            //Limpar os campos
            txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            txtPesquisarCADCliente.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Italic);
            txtPesquisarCADCliente.ForeColor = Color.Silver;
            //txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtNomeCliente.Text = "Nome do Cliente";
            txtNomeCliente.Font = new Font(txtNomeCliente.Font, FontStyle.Italic);
            txtNomeCliente.ForeColor = Color.Silver;

            txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;

            txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            txtTelefoneRecado.ForeColor = Color.Silver;

            txtCPFCliente.Text = "CPF ou CNPJ do Cliente";
            txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
            txtCPFCliente.ForeColor = Color.Silver;

            txtDataNascimento.Text = "Data de Nascimento";
            txtDataNascimento.Font = new Font(txtDataNascimento.Font, FontStyle.Italic);
            txtDataNascimento.ForeColor = Color.Silver;

            txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;

            txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            txtTelefoneRecado.ForeColor = Color.Silver;

            txtParentescoRecado.Text = "Parentesco de quem vai receber o recado";
            txtParentescoRecado.Font = new Font(txtParentescoRecado.Font, FontStyle.Italic);
            txtParentescoRecado.ForeColor = Color.Silver;

            txtNomeRecado.Text = "Nome de quem vai receber o recado";
            txtNomeRecado.Font = new Font(txtNomeRecado.Font, FontStyle.Italic);
            txtNomeRecado.ForeColor = Color.Silver;

            txtCEP.Text = "Ex: 42803317";
            txtCEP.Font = new Font(txtCEP.Font, FontStyle.Italic);
            txtCEP.ForeColor = Color.Silver;

            txtEndereco.Text = "Ex: Rua Segundo Cendes, 197B";
            txtEndereco.Font = new Font(txtEndereco.Font, FontStyle.Italic);
            txtEndereco.ForeColor = Color.Silver;

            cmbCidades.Text = "Ex: Camaçari";
            cmbCidades.Font = new Font(cmbCidades.Font, FontStyle.Italic);
            cmbCidades.ForeColor = Color.Silver;

            txtComplemento.Text = "Ex: Casa";
            txtComplemento.Font = new Font(txtComplemento.Font, FontStyle.Italic);
            txtComplemento.ForeColor = Color.Silver;

            txtBairro.Text = "Ex: Gleba B";
            txtBairro.Font = new Font(txtBairro.Font, FontStyle.Italic);
            txtBairro.ForeColor = Color.Silver;

            cmbEstados.Text = "Ex: BA";
            cmbEstados.Font = new Font(cmbEstados.Font, FontStyle.Italic);
            cmbEstados.ForeColor = Color.Silver;

            chkMasculino.Checked = false;
            chkFeminino.Checked = false;
        }

        //Os metodos "PintarBordaEmBaixo" abaixo, sao os metodos que desenham uma borda na parte de baixo das textboxes
        //ja o metodo "PintarTodasBordas" desenha todas as bordas (usado apenas no textbox de pesquisar cliente)
        private void PintarTodasBordas(object sender, PaintEventArgs e)
        {
            float penThickness = 4f;
            Control control = (Control)sender;

            using (Pen p = new Pen(Color.FromArgb(255, 0, 103), penThickness))
            {
                // Top
                Point topLeft = new Point(0, 0);
                Point topRight = new Point(control.Width, 0);
                e.Graphics.DrawLine(p, topLeft, topRight);

                // Left
                Point bottomLeft = new Point(0, control.Height);
                e.Graphics.DrawLine(p, topLeft, bottomLeft);

                // Right
                Point bottomRight = new Point(control.Width, control.Height);
                e.Graphics.DrawLine(p, topRight, bottomRight);

                // Bottom
                e.Graphics.DrawLine(p, bottomLeft, bottomRight);
            }
        }
        private void PintarBordaEmBaixo(object sender, PaintEventArgs e)
        {
            float penThickness = 2f;
            Point bottomLeft = new Point(e.ClipRectangle.Left, e.ClipRectangle.Bottom - (int)penThickness);
            Point bottomRight = new Point(e.ClipRectangle.Right, e.ClipRectangle.Bottom - (int)penThickness);
            using (Pen p = new Pen(Color.FromArgb(255, 0, 103), penThickness))
            { // You can use a different Color
                e.Graphics.DrawLine(p, bottomLeft, bottomRight);
            }
        }

        //--------------------- Eventos de keypress, click e outros....
        #region Eventos
        private void eventoCadastrarClienteApertarEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();

                //MessageBox.Show("Test");
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            txtNomeCliente.Focus();
            txtCPFCliente.Text = "";
            txtCPFCliente.Focus();
            txtDataNascimento.Text = "";
            txtDataNascimento.Focus();
            txtTelefoneCliente.Text = "";
            txtTelefoneCliente.Focus();
            txtTelefoneRecado.Text = "";
            txtTelefoneRecado.Focus();

            txtParentescoRecado.Enabled = true;
            txtParentescoRecado.Text = "";
            txtParentescoRecado.Focus();
            txtParentescoRecado.Enabled = false;
            txtParentescoRecado.ForeColor = Color.DimGray;

            txtNomeRecado.Enabled = true;
            txtNomeRecado.Text = "";
            txtNomeRecado.Focus();
            txtNomeRecado.Enabled = false;
            txtNomeRecado.ForeColor = Color.DimGray;

            txtCEP.Text = "";
            txtCEP.Focus();
            txtEndereco.Text = "";
            txtEndereco.Focus();
            txtComplemento.Text = "";
            txtComplemento.Focus();
            txtBairro.Text = "";
            txtBairro.Focus();

            //txtEstado.Text = "";
            //txtEstado.Focus();
            cmbEstados.Text = "";
            cmbEstados.Focus();
            cmbCidades.Text = "";
            cmbCidades.Focus();
            btnLimparCampos.Focus();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //CadastrarTestes();
            CadastrarNovoCliente();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamarEdicaoCliente();

            //refreshTable();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(@"Tem certeza que deseja deletar esse cliente?", "DELETAR CLIENTE"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                preencherTableClientes.Preencher(table_Clientes);
            }
            else
            {
                try
                {
                    preencherTableClientes.PesquisarClienteNome(txtPesquisarCADCliente.Text, table_Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
                }
            }
        }

        private void table_Clientes_DoubleClick(object sender, EventArgs e)
        {
            chamarEdicaoCliente();
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
                    FormatarCampos.FormatarTodaStringParaCpf(sender, txtCPFCliente);
                    contadorCPF++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCpf(sender, e);
                }
            }
            else
            {
                contadorCPF = 0;
                if (contadorCNPJ == 0)
                {
                    FormatarCampos.FormatarTodaStringParaCnpj(sender, txtCPFCliente);
                    contadorCNPJ++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCnpj(sender, e);
                }
            }
        }

        private void txtTelefoneRecado_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTelefoneRecado.Text == "Telefone de Recados do Cliente" || txtTelefoneRecado.Text == "")
            {
                txtNomeRecado.Enabled = false;
                txtNomeRecado.ForeColor = Color.DimGray;
                txtParentescoRecado.Enabled = false;
                txtParentescoRecado.ForeColor = Color.DimGray;

                //txtCEP.Focus();
            }
            else
            {
                txtNomeRecado.Enabled = true;
                txtNomeRecado.ForeColor = Color.White;
                txtParentescoRecado.Enabled = true;
                txtParentescoRecado.ForeColor = Color.White;
            }
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCampos.FormatarEmTempoRealData(sender, e);
        }

        private void txtTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCampos.FormatandoEmTempoRealParaTelefone(sender, e);
        }

        private void txtTelefoneRecado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtTelefoneRecado.Text == "Telefone de Recados do Cliente" || txtTelefoneRecado.Text == "")
            //{
            //    txtCEP.Focus();
            //}
            FormatarCampos.FormatandoEmTempoRealParaTelefone(sender, e);
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

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasculino.Checked)
            {
                chkFeminino.Checked = false;
            }
        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeminino.Checked)
            {
                chkMasculino.Checked = false;
            }
        }

        private void SetarCorDaLinhaETexto_ENTER(TextEdit _textbox, string _texto)
        {
            if (_textbox.Text == _texto)
            {
                _textbox.Text = "";
                _textbox.Font = new Font(_textbox.Font, FontStyle.Regular);
                _textbox.ForeColor = Color.White;
            }
        }

        private void SetarCorDaLinhaETexto_LEAVE(TextEdit _textbox, string _texto)
        {
            if (_textbox.Text == "")
            {
                _textbox.Text = _texto;
                _textbox.Font = new Font(_textbox.Font, FontStyle.Italic);
                _textbox.ForeColor = Color.Silver;
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
            SetarCorDaLinhaETexto_ENTER(txtPesquisarCADCliente
                , "Digite o nome do cliente que deseja buscar os serviços");
        }

        private void txtPesquisarCADCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtPesquisarCADCliente
                , "Digite o nome do cliente que deseja buscar os serviços");
            if (txtPesquisarCADCliente.Text == "")
            {
                preencherTableClientes.Preencher(table_Clientes);
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
            SetarCorDaLinhaETexto_ENTER(txtCPFCliente, "CPF ou CNPJ do Cliente");
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtCPFCliente, "CPF ou CNPJ do Cliente");
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
            BuscarCepAPI();
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

        private void cmbEstados_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(cmbEstados, "Ex: BA");
        }

        private void cmbCidades_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(cmbEstados, "Ex: Camaçari");
        }

        private void cmbEstados_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(cmbEstados, "Ex: BA");
        }

        private void cmbCidades_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(cmbEstados, "Ex: Camaçari");
        }
        private void txtDataNascimento_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtDataNascimento, "Data de Nascimento");
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtDataNascimento, "Data de Nascimento");
        }
        #endregion Eventos

    }
}