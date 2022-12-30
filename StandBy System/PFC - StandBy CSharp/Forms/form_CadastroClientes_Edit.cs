using PFC___StandBy_CSharp.Dados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.APIs.CEP;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.Properties;
using PFC___StandBy_CSharp.Utils;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes_Edit : Form
    {
        private form_CadastroClientes formCadCliente;
        private readonly AlterarDados ad = new AlterarDados();
        private readonly VerificarExistencia verificarExistencia = new VerificarExistencia();
        private int[] corGeral;
        private int contadorCNPJ = 0;
        private int contadorCPF = 0;
        public bool isTemCidadeCadastrada = false;

        public form_CadastroClientes_Edit(form_CadastroClientes cadCliente, int[] corRGB)
        {
            InitializeComponent();
            corGeral = corRGB;
            this.formCadCliente = cadCliente;
            MudarCores();
        }

        public void MudarCores()
        {
            txtParentescoRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtNomeRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtCEP.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtRua.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtComplemento.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtBairro.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //txtCidade.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //txtEstado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnEditar.BaseColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.BaseColor2 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.OnHoverBaseColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.OnHoverBaseColor2 = Color.White;
            //btnZerarDataBotao.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnZerarDataBotao.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnZerarDataBotao.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            cardFundo.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            separatorCPF.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorDATA.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorTEL_RECADO.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorTEL_CLIENTE.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            separatorCIDADES.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            chkMasculino.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkMasculino.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkFeminino.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkFeminino.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private ClienteModel PegarDadosDoCliente()
        {
            string dataNascimento = "";
            if (txtDataNascimento.Text != "SEM DATA")
            {
                dataNascimento = txtDataNascimento.Text;
            }

            int id = int.Parse(lblID.Text);
            char sexo = '-';
            if (chkMasculino.Checked == true && chkFeminino.Checked == false)
            {
                sexo = 'M';
            }
            else if (chkFeminino.Checked == true && chkMasculino.Checked == false)
            {
                sexo = 'F';
            }

            ClienteModel dadosCliente = new ClienteModel
            {
                ID = id,
                Nome = txtNomeCliente.Text,
                Telefone = txtTelefone.Text,
                Cpf = txtCPFCliente.Text,
                TelefoneRecado = txtTelefoneRecados.Text,
                NomeRecado = txtNomeRecado.Text,
                ParentescoRecado = txtParentescoRecado.Text,
                Sexo = sexo,
                //DataNascimento = dtpDataNascimento.Value,
                DataNascimento = dataNascimento,
                Cep = txtCEP.Text,
                Endereco = txtRua.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = cmbCidades.Text,
                Estado = cmbEstados.Text
                //Estado = txtEstado.Text
            };

            return dadosCliente;
        }

        private void EditarCliente()
        {
            try
            {
                ClienteModel dadosCliente = PegarDadosDoCliente();

                //Validar a data (armengadas mas funciona perfeitamente hehe)
                if (txtDataNascimento.Text != "SEM DATA")
                {
                    var gambi = Convert.ToDateTime(txtDataNascimento.Text);
                }

                //Validar o genero
                if (chkMasculino.Checked == false && chkFeminino.Checked == false)
                {
                    MessageBox.Show(@"Favor preencher o genero do cliente!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Validar o CPF/CNPJ
                //bool isCpfCnpjExistente = false;
                //if (!dadosCliente.Cpf.Equals("SEM CPF/CNPJ"))
                //{
                //    isCpfCnpjExistente = verificarExistencia.VerificarExistenciaCPF(dadosCliente.Cpf);
                //}

                //if (isCpfCnpjExistente == true)
                //{
                //    MessageBox.Show(@"CPF/CNPJ Já existe, verifique se o cliente já esta cadastrado.", "CPF/CNPJ Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                ad.AlterarClientes(dadosCliente);
                formCadCliente.refreshTable();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show($"Digite uma data valida Ex: 26/08/1995\nou clique em 'Zerar Data' caso nao tenha uma. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void form_CadastroClientes_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditarCliente();
            }
        }

        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditarCliente();
            }
        }

        private void btnZerarData_Click(object sender, EventArgs e)
        {
            ZerarData();
        }

        private void ZerarData()
        {
            txtDataNascimento.Text = "SEM DATA";
            //dtpDataNascimento.Value = dtpDataNascimento.MinDate;
            //dtpDataNascimento.ForeColor = Color.Transparent;
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
            if (txtDataNascimento.Text == "SEM DATA")
            {
                txtDataNascimento.Text = "";
            }
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            if (txtDataNascimento.Text.Length < 2)
            {
                txtDataNascimento.Text = "SEM DATA";
            }
        }

        private void txtDataNascimento_MouseLeave(object sender, EventArgs e)
        {
            if (txtDataNascimento.Text.Length < 2)
            {
                txtDataNascimento.Text = "SEM DATA";
            }
        }

        private void txtDataNascimento_MouseEnter(object sender, EventArgs e)
        {
            if (txtDataNascimento.Text == "SEM DATA")
            {
                txtDataNascimento.Text = "";
            }
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCampos.FormatarEmTempoRealData(sender, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCampos.FormatandoEmTempoRealParaTelefone(sender, e);
        }

        private void txtTelefoneRecados_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCampos.FormatandoEmTempoRealParaTelefone(sender, e);
        }

        private void form_CadastroClientes_Edit_Load(object sender, EventArgs e)
        {
            //if (isTemCidadeCadastrada == false)
            //{
            CarregarCidadesANDEstados();
            isTemCidadeCadastrada = true;

            //}
        }

        private void CarregarCidadesANDEstados()
        {
            this.cmbCidades.ListControl = this.listboxCidades;
            this.cmbEstados.ListControl = this.listboxEstados;
            Task.Run(() =>
            {
                string cidadeCliente = "Ex: Camaçari";
                string estadoCliente = "Ex: BA";
                if (cmbCidades.Text != "" && cmbCidades.Text != "Ex: Camaçari")
                {
                    cidadeCliente = cmbCidades.Text;
                }

                if (cmbEstados.Text != "" && cmbEstados.Text != "Ex: BA")
                {
                    estadoCliente = cmbEstados.Text;
                }
                PreencherAutoComplete("");
                cmbCidades.Text = cidadeCliente;
                cmbEstados.Text = estadoCliente;
            });
        }

        private void PreencherAutoComplete(string _texto)
        {
            try
            {
                lblCidades_Carregando.Visible = true;
                lblCidades_Carregando.Text = "Carregando cidades...";

                lblEstados_Carregando.Visible = true;
                lblEstados_Carregando.Text = "Carregando estados...";

                List<string> cidades = new List<string>();
                List<string> estados = new List<string>
                {
                    "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
                    "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE",
                    "TO"
                };

                string[] cidadesSeparadas = Resources.Cidades.Split('\n');

                cidades = cidadesSeparadas.ToList();
                listboxCidades.DataSource = cidades.FindAll(x => x.StartsWith(_texto));
                listboxEstados.DataSource = estados.FindAll(x => x.StartsWith(_texto));
                lblCidades_Carregando.Text = "FIM";
                lblCidades_Carregando.Visible = false;

                lblEstados_Carregando.Text = "FIM";
                lblEstados_Carregando.Visible = false;

                if (cmbCidades.Text == "" || cmbCidades.Text == "Ex: Camaçari")
                    cmbCidades.Text = "Ex: Camaçari";
            }
            catch (Exception)
            {
                //Console.WriteLine(e);
                //throw;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCPFCliente_MouseEnter(object sender, EventArgs e)
        {
            if (txtCPFCliente.Text == "SEM CPF/CNPJ" || txtCPFCliente.Text == "SEM CPF")
            {
                txtCPFCliente.Text = "";
            }
        }

        private void txtCPFCliente_MouseLeave(object sender, EventArgs e)
        {
            if (txtCPFCliente.Text == "")
            {
                txtCPFCliente.Text = "SEM CPF/CNPJ";
            }
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
                    txtCEP.Text = "Ex: 42803317";
                    txtCEP.Font = new Font(txtCEP.Font, FontStyle.Italic);
                    txtCEP.ForeColor = Color.Silver;
                    txtCEP.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                }
                else if (txtCEP.Text.Length < 8 || txtCEP.Text.Length > 8)
                {
                    MessageBox.Show("Digite um CEP valido!\nEx: 42803317", "Erro CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var enderecoRetornado = CepApi.Buscar(txtCEP.Text);

                    txtRua.Text = enderecoRetornado[0].Endereco;
                    txtBairro.Text = enderecoRetornado[0].Bairro;
                    cmbCidades.Text = enderecoRetornado[0].Cidade;
                    txtComplemento.Text = enderecoRetornado[0].Complemento;
                    cmbEstados.Text = enderecoRetornado[0].UF;
                    //txtEstado.Text = enderecoRetornado[0].UF;

                    // txtCEP.Text = _texto;
                    txtCEP.Font = new Font(txtCEP.Font, FontStyle.Italic);
                    txtCEP.ForeColor = Color.Silver;
                    txtCEP.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                    //SetarCorDaLinhaETexto_LEAVE(txtCEP, "Ex: 42803317");
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(exception);
                //throw;
            }
        }

        private void cmbCidades_Click(object sender, EventArgs e)
        {
            if (isTemCidadeCadastrada == false)
            {
                CarregarCidadesANDEstados();
                isTemCidadeCadastrada = true;
            }
        }
    }
}