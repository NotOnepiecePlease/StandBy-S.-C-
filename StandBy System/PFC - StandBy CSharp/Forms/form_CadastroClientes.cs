using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes;
using PFC___StandBy_CSharp.APIs.CEP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PFC___StandBy_CSharp.Properties;
using PFC___StandBy_CSharp.Utils;
using Bunifu.UI.WinForms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Syncfusion.Windows.Forms.Tools;
using BunifuSeparator = Bunifu.UI.WinForms.BunifuSeparator;
using DevExpress.Xpo;
using DevExpress.DataProcessing.InMemoryDataProcessor;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes : Form
    {
        private PreencherTableClientes preencherTableClientes = new PreencherTableClientes();
        private PreencherComboboxCliente preencherComboboxCliente = new PreencherComboboxCliente();
        private DeletarDados dd = new DeletarDados();
        private InserirDados id = new InserirDados();
        private BuscarDados bd = new BuscarDados();
        private static List<string> listCidades = new List<string>();

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
            testeSearchLookUp();
            txtNomeCliente.Focus();
        }

        private void testeSearchLookUp()
        {
            List<string> estados = new List<string>
            {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO",
                "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
                "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            };
            cmbEstados.Properties.DataSource = estados;
            cmbEstados.Properties.PopupFormSize = new Size(206, 300);
            string[] cidadesSeparadas = Resources.Cidades.Split('\n');
            // Creates the dictionary.
            List<string> products = new List<string>();
            //Dictionary<int, string> products = new Dictionary<int, string>();
            int contador = 0;
            foreach (var VARIABLE in cidadesSeparadas)
            {
                products.Add(VARIABLE);
                //contador++;
            }
            // Binds the lookup to the dictionary.
            cmbCidades.Properties.DataSource = products;



            //string[] cidadesSeparadas = Resources.Cidades.Split('\n');

            //// Configuração do DataSource
            //searchLookUpEdit1.Properties.DataSource = cidadesSeparadas;
            //searchLookUpEdit1.Properties.DisplayMember = "NomeDaPropriedade"; // Substitua pelo nome da propriedade que deseja exibir
            //searchLookUpEdit1.Properties.ValueMember = "NomeDaPropriedade"; // Substitua pelo nome da propriedade que deseja usar como valor

            //// Configuração do Instant Feedback Mode
            //searchLookUpEdit1.Properties.View.OptionsBehavior.Editable = false; // Desativa a edição na grade
            //searchLookUpEdit1.Properties.View.OptionsBehavior.AllowIncrementalSearch = true; // Ativa a pesquisa incremental
            //searchLookUpEdit1.Properties.PopupFilterMode = PopupFilterMode.StartsWith; // Define o modo de filtro para pesquisa incremental
            //searchLookUpEdit1.Properties.View.OptionsView.ShowAutoFilterRow = true; // Mostra a linha de filtro

            //// Evento para carregar dados de forma assíncrona
            //searchLookUpEdit1.QueryPopUp += (sender, e) =>
            //{
            //    // Carregue os dados aqui de forma assíncrona, se necessário
            //    // Você pode usar uma tarefa assíncrona ou qualquer outra lógica específica para carregar os dados
            //    // Certifique-se de chamar EndPopulating quando a carga de dados estiver concluída
            //    searchLookUpEdit1.Properties.BeginUpdate();
            //    // Carregue os dados de forma assíncrona aqui
            //    // Exemplo: searchLookUpEdit1.Properties.DataSource = await LoadDataAsync();
            //    searchLookUpEdit1.Properties.EndUpdate();
            //};
        }
        public void refreshTable()
        {
            preencherTableClientes.Preencher(table_Clientes);
        }

        public void MudarTodasCores()
        {
            separatorNomeCliente.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorCEP.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorRua.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorComplemento.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorBairro.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            separatorESTADOS.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorNomeRecado.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorNomeRecado.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            menuBotaoDireitoTabela.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            separatorCIDADES.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorESTADOS.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorTEL_CLIENTE.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorDATA.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorTEL_RECADO.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnCadastrarCliente.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCadastrarCliente.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCadastrarCliente.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //chkMasculino.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkMasculino.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkFeminino.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chkFeminino.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //CadastrarTestes();
            CadastrarNovoCliente();
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

        private void separatorCPF_MouseEnter(object sender, EventArgs e)
        {
            separatorCPF.LineColor = Color.Lavender;
        }

        private void separatorCPF_MouseLeave(object sender, EventArgs e)
        {
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void separatorTEL_CLIENTE_MouseEnter(object sender, EventArgs e)
        {
            separatorTEL_CLIENTE.LineColor = Color.Lavender;
        }

        private void separatorTEL_CLIENTE_MouseLeave(object sender, EventArgs e)
        {
            separatorTEL_CLIENTE.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        
        private void separatorDATA_MouseEnter(object sender, EventArgs e)
        {
            separatorDATA.LineColor = Color.Lavender;
        }

        private void separatorDATA_MouseLeave(object sender, EventArgs e)
        {
            separatorDATA.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
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

        #region Resetar todos os campos textboxes
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
            separatorNomeCliente.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;
            separatorTEL_CLIENTE.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            txtTelefoneRecado.ForeColor = Color.Silver;
            separatorTEL_RECADO.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCPFCliente.Text = "CPF ou CNPJ do Cliente";
            txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
            txtCPFCliente.ForeColor = Color.Silver;
            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtDataNascimento.Text = "Data de Nascimento";
            txtDataNascimento.Font = new Font(txtDataNascimento.Font, FontStyle.Italic);
            txtDataNascimento.ForeColor = Color.Silver;

            //txtDataNascimento.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorDATA.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;

            //txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorTEL_CLIENTE.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            txtTelefoneRecado.ForeColor = Color.Silver;
            separatorTEL_RECADO.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtParentescoRecado.Text = "Parentesco de quem vai receber o recado";
            txtParentescoRecado.Font = new Font(txtParentescoRecado.Font, FontStyle.Italic);
            txtParentescoRecado.ForeColor = Color.Silver;
            separatorParentesco.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtNomeRecado.Text = "Nome de quem vai receber o recado";
            txtNomeRecado.Font = new Font(txtNomeRecado.Font, FontStyle.Italic);
            txtNomeRecado.ForeColor = Color.Silver;
            separatorNomeRecado.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCEP.Text = "Ex: 42803317";
            txtCEP.Font = new Font(txtCEP.Font, FontStyle.Italic);
            txtCEP.ForeColor = Color.Silver;
            separatorCEP.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtEndereco.Text = "Ex: Rua Segundo Cendes, 197B";
            txtEndereco.Font = new Font(txtEndereco.Font, FontStyle.Italic);
            txtEndereco.ForeColor = Color.Silver;
            separatorRua.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            cmbCidades.Text = "Ex: Camaçari";
            cmbCidades.Font = new Font(cmbCidades.Font, FontStyle.Italic);
            cmbCidades.ForeColor = Color.Silver;
            separatorCIDADES.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtComplemento.Text = "Ex: Casa";
            txtComplemento.Font = new Font(txtComplemento.Font, FontStyle.Italic);
            txtComplemento.ForeColor = Color.Silver;
            separatorComplemento.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtBairro.Text = "Ex: Gleba B";
            txtBairro.Font = new Font(txtBairro.Font, FontStyle.Italic);
            txtBairro.ForeColor = Color.Silver;
            separatorBairro.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            cmbEstados.Text = "Ex: BA";
            cmbEstados.Font = new Font(cmbEstados.Font, FontStyle.Italic);
            cmbEstados.ForeColor = Color.Silver;
            separatorESTADOS.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            chkMasculino.Checked = false;
            chkFeminino.Checked = false;
        }
        #endregion Resetar todos os campos textboxes

        #region ENTER e LEAVE eventos das textboxes e comboboxes
        //BunifuMaterialTextbox ENTER
        private void SetarCorDaLinhaETexto_ENTER(TextEdit _textbox, BunifuSeparator _separator, string _texto)
        {
            if (_textbox.Text == _texto)
            {
                _textbox.Text = "";
                _textbox.Font = new Font(_textbox.Font, FontStyle.Regular);
                _separator.LineColor = Color.White;
                _textbox.ForeColor = Color.White;
            }
        }

        //BunifuMaterialTextbox LEAVE
        private void SetarCorDaLinhaETexto_LEAVE(TextEdit _textbox, BunifuSeparator _separator, string _texto)
        {
            if (_textbox.Text == "")
            {
                _textbox.Text = _texto;
                _textbox.Font = new Font(_textbox.Font, FontStyle.Italic);
                _textbox.ForeColor = Color.Silver;
                _separator.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        //BunifuMetroTextbox ENTER
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

        //ComboBoxBase ENTER
        private void SetarCorDaLinhaETexto_ENTER(ComboBoxBase _combobox, BunifuSeparator _line, string _texto)
        {
            if (_combobox.Text == _texto)
            {
                _combobox.Text = "";
                _combobox.Font = new Font(_combobox.Font, FontStyle.Regular);
                _line.LineColor = Color.White;
                _combobox.ForeColor = Color.White;
            }
        }



        //BunifuMetroTextbox LEAVE
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

        //ComboBoxBase LEAVE
        private void SetarCorDaLinhaETexto_LEAVE(ComboBoxBase _combobox, BunifuSeparator _line, string _texto)
        {
            if (_combobox.Text == "")
            {
                _combobox.Text = _texto;
                _combobox.Font = new Font(_combobox.Font, FontStyle.Italic);
                _combobox.ForeColor = Color.Silver;
                _line.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtNomeCliente_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtNomeCliente, separatorNomeCliente, "Nome do Cliente");
        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtNomeCliente, separatorNomeCliente, "Nome do Cliente");
        }

        private void txtTelefoneCliente_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtTelefoneCliente, separatorTEL_CLIENTE, "Telefone Principal do Cliente");
        }

        private void txtTelefoneCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtTelefoneCliente, separatorTEL_CLIENTE, "Telefone Principal do Cliente" );
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
            SetarCorDaLinhaETexto_ENTER(txtTelefoneRecado, separatorTEL_RECADO, "Telefone de Recados do Cliente");
        }

        private void txtTelefoneRecado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtTelefoneRecado, separatorTEL_RECADO, "Telefone de Recados do Cliente");
        }

        private void txtCPFCliente_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtCPFCliente, separatorCPF, "CPF ou CNPJ do Cliente" );
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtCPFCliente, separatorCPF, "CPF ou CNPJ do Cliente");
        }

        private void txtParentescoRecado_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtParentescoRecado, separatorParentesco, "Parentesco de quem vai receber o recado");
        }

        private void txtParentescoRecado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtParentescoRecado, separatorParentesco, "Parentesco de quem vai receber o recado");
        }

        private void txtNomeRecado_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtNomeRecado, separatorNomeRecado, "Nome de quem vai receber o recado");
        }

        private void txtNomeRecado_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtNomeRecado, separatorNomeRecado, "Nome de quem vai receber o recado");
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtCEP, separatorCEP, "Ex: 42803317");
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            BuscarCepAPI();
        }

        private void BuscarCepAPI()
        {
            try
            {
                if (txtCEP.Text == "")
                {
                    IniciarStyleTextsEndereco();
                    SetarCorDaLinhaETexto_LEAVE(txtCEP, separatorCEP,"Ex: 42803317");
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
                    separatorCEP.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
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


        private void txtRua_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtEndereco, separatorRua, "Ex: Rua Segundo Cendes, 197B");
        }

        private void txtRua_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtEndereco, separatorRua, "Ex: Rua Segundo Cendes, 197B");
        }

        private void txtComplemento_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtComplemento, separatorComplemento, "Ex: Casa");
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtComplemento, separatorComplemento, "Ex: Casa");
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtBairro, separatorBairro, "Ex: Gleba B");
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtBairro, separatorBairro, "Ex: Gleba B");
        }

        private void cmbEstados_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(cmbEstados, separatorESTADOS, "Ex: BA");
        }

        private void cmbCidades_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(cmbEstados, separatorESTADOS, "Ex: Camaçari");
        }

        private void cmbEstados_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(cmbEstados, separatorESTADOS, "Ex: BA");
        }

        private void cmbCidades_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(cmbEstados, separatorESTADOS, "Ex: Camaçari");
        }
        private void txtDataNascimento_Enter(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_ENTER(txtDataNascimento, separatorDATA, "Data de Nascimento");
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            SetarCorDaLinhaETexto_LEAVE(txtDataNascimento, separatorDATA, "Data de Nascimento");
        }
        #endregion ENTER e LEAVE eventos das textboxes

        private void form_CadastroClientes_Load(object sender, EventArgs e)
        {
        }

        private void separatorCIDADES_MouseEnter(object sender, EventArgs e)
        {
            separatorCIDADES.LineColor = Color.Lavender;
        }

        private void separatorCIDADES_MouseLeave(object sender, EventArgs e)
        {
            separatorCIDADES.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

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
            txtParentescoRecado.Text = "";
            txtParentescoRecado.Focus();
            txtNomeRecado.Text = "";
            txtNomeRecado.Focus();
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
    }
}