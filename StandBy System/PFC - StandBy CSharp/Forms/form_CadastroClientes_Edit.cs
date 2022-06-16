using PFC___StandBy_CSharp.Dados;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Formatar_Campos;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.Utils;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes_Edit : Form
    {
        private form_CadastroClientes cadCliente;
        private AlterarDados ad = new AlterarDados();
        private int[] corGeral = new int[3];

        public form_CadastroClientes_Edit(form_CadastroClientes cadCliente, int[] corRGB)
        {
            InitializeComponent();
            corGeral = corRGB;
            this.cadCliente = cadCliente;
            MudarCores();
        }

        public form_CadastroClientes_Edit()
        {
            InitializeComponent();
        }

        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        private ClienteDados PegarDadosDoCliente()
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

            ClienteDados dadosCliente = new ClienteDados
            {
                ID = id,
                Nome = txtNomeCliente.Text,
                Telefone = txtTelefone.Text,
                Cpf = txtCpf.Text,
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
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text
            };

            return dadosCliente;
        }

        private void EditarCliente()
        {
            try
            {
                //Validacoes (armengadas mas funciona perfeitamente hehe)
                if (txtDataNascimento.Text != "SEM DATA")
                {
                    Convert.ToDateTime(txtDataNascimento.Text);
                }

                if (chkMasculino.Checked == false && chkFeminino.Checked == false)
                {
                    MessageBox.Show(@"Favor preencher o genero do cliente!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (contemLetras(txtCpf.Text))
                {
                    ClienteDados dadosCliente = PegarDadosDoCliente();

                    ad.AlterarClientes(dadosCliente);
                    cadCliente.refreshTable();
                    this.Close();
                }
                else
                {
                    string numeroSemPontosTracos = txtCpf.Text.ToString().Replace(".", "").Replace("-", "");
                    if (numeroSemPontosTracos.Length > 13)
                    {
                        long cnpj = Convert.ToInt64(numeroSemPontosTracos);
                        // long cpf = Convert.ToInt64(txtCpf.Text);
                        string CNPJformatado = String.Format(@"{0:00\.000\.000\/0000-00}", cnpj);
                        ClienteDados dadosCliente = PegarDadosDoCliente();
                        dadosCliente.Cpf = CNPJformatado;
                        ad.AlterarClientes(dadosCliente);
                        cadCliente.refreshTable();
                        this.Close();
                    }
                    else
                    {
                        long cpf = Convert.ToInt64(numeroSemPontosTracos);
                        // long cpf = Convert.ToInt64(txtCpf.Text);
                        string CPFformatado = String.Format(@"{0:000\.000\.000\-00}", cpf);
                        ClienteDados dadosCliente = PegarDadosDoCliente();
                        dadosCliente.Cpf = CPFformatado;
                        ad.AlterarClientes(dadosCliente);
                        cadCliente.refreshTable();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Digite uma data valida Ex: 26/08/1995\nou clique em 'Zerar Data' caso nao tenha uma. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MudarCores()
        {
            cardFundo.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.BaseColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.BaseColor2 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnEditar.OnHoverBaseColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.OnHoverBaseColor2 = Color.White;
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
            //if (txtDataNascimento.Text == "SEM DATA")
            //{
            //    EditarCliente();
            //}
            //else
            //{
            //    try
            //    {
            //        Convert.ToDateTime(txtDataNascimento.Text);
            //        EditarCliente();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show($"Digite uma data valida Ex: 26/08/1995\nou clique em 'Zerar Data' caso nao tenha uma. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditarCliente();
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
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

        private void btnZerarDataBotao_Click(object sender, EventArgs e)
        {
            ZerarData();
        }

        private void ZerarData()
        {
            txtDataNascimento.Text = "SEM DATA";
            dtpDataNascimento.Value = dtpDataNascimento.MinDate;
            dtpDataNascimento.ForeColor = Color.Transparent;
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

        private void dtpDataNascimento_MouseLeave(object sender, EventArgs e)
        {
            if (dtpDataNascimento.Value.Year == dtpDataNascimento.MinDate.Year)
            {
                ZerarData();
            }
        }

        private void dtpDataNascimento_MouseEnter(object sender, EventArgs e)
        {
            if (dtpDataNascimento.Value.Year == dtpDataNascimento.MinDate.Year)
            {
                dtpDataNascimento.ForeColor = Color.White;
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

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCampos.FormatarEmTempoRealData(sender, e);
        }
    }
}