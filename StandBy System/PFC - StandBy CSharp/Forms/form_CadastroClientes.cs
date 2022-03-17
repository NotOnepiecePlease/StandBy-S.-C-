using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes : Form
    {
        PreencherTableClientes preencherClientes = new PreencherTableClientes();
        DeletarDados dd = new DeletarDados();
        VerificarExistencia ve = new VerificarExistencia();
        InserirDados id = new InserirDados();
        int[] corGeral = new int[3] { 0, 0, 0 };
        public form_CadastroClientes(int[] corRGB)
        {
            InitializeComponent();
            preencherClientes.Preencher(table_Clientes);
            corGeral = corRGB;
            MudarTodasCores();
        }

        public form_CadastroClientes()
        {
            InitializeComponent();
            preencherClientes.Preencher(table_Clientes);
        }

        public void refreshTable()
        {
            preencherClientes.Preencher(table_Clientes);
        }

        public void MudarTodasCores()
        {
            txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtTelefoneRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCadastrarCliente.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //table_Clientes.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            contextMenuStrip1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkSemCPF.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkSemCPF.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            chkCnpj.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkCnpj.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            chkTelRecados.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            chkTelRecados.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            ///chkTelRecados
        }

        private void txtNomeCliente_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("teste");
            if (txtNomeCliente.Text == "Nome do Cliente")
            {
                txtNomeCliente.Text = "";
                txtNomeCliente.Font = new Font(txtNomeCliente.Font, FontStyle.Regular);
                txtNomeCliente.LineIdleColor = Color.White;
                txtNomeCliente.ForeColor = Color.White;
            }
        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                txtNomeCliente.Text = "Nome do Cliente";
                txtNomeCliente.Font = new Font(txtNomeCliente.Font, FontStyle.Italic);
                txtNomeCliente.ForeColor = Color.Silver;
                txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtCPFCliente_Enter(object sender, EventArgs e)
        {
            if (txtCPFCliente.Text == "CPF do Cliente")
            {
                txtCPFCliente.Text = "";
                txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Regular);
                txtCPFCliente.LineIdleColor = Color.White;
                txtCPFCliente.ForeColor = Color.White;
            }

            if (txtCPFCliente.Text == "CNPJ do Cliente")
            {
                txtCPFCliente.Text = "";
                txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Regular);
                txtCPFCliente.LineIdleColor = Color.White;
                txtCPFCliente.ForeColor = Color.White;
            }
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            if (chkCnpj.Checked == true)
            {
                if (txtCPFCliente.Text == "")
                {
                    txtCPFCliente.Text = "CNPJ do Cliente";
                    txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
                    txtCPFCliente.ForeColor = Color.Silver;
                    txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                }
            }
            else
            {
                if (txtCPFCliente.Text == "")
                {
                    txtCPFCliente.Text = "CPF do Cliente";
                    txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
                    txtCPFCliente.ForeColor = Color.Silver;
                    txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                }
            }
        }

        private void txtTelefoneCliente_Enter(object sender, EventArgs e)
        {
            if (txtTelefoneCliente.Text == "Telefone Principal do Cliente")
            {
                txtTelefoneCliente.Text = "";
                txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Regular);
                txtTelefoneCliente.LineIdleColor = Color.White;
                txtTelefoneCliente.ForeColor = Color.White;
            }
        }

        private void txtTelefoneCliente_Leave(object sender, EventArgs e)
        {
            if (txtTelefoneCliente.Text == "")
            {
                txtTelefoneCliente.Text = "Telefone Principal do Cliente";
                txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
                txtTelefoneCliente.ForeColor = Color.Silver;
                txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtPesquisarCADCliente_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarCADCliente.Text == "Digite o nome do cliente que deseja buscar os serviços")
            {
                txtPesquisarCADCliente.Text = "";
                txtPesquisarCADCliente.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Regular);
                txtPesquisarCADCliente.BorderColorIdle = Color.White;
                txtPesquisarCADCliente.ForeColor = Color.White;
            }
        }

        private void txtPesquisarCADCliente_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarCADCliente.Text == "")
            {
                txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
                txtPesquisarCADCliente.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Italic);
                txtPesquisarCADCliente.ForeColor = Color.Silver;
                txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                preencherClientes.Preencher(table_Clientes);
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //CadastrarTestes();
            CadastrarNovoCliente();
        }

        private void txtPesquisarCADCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
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

        public void CadastrarTestes()
        {
            long cpf = Convert.ToInt64(txtCPFCliente.Text);

            string CpfOuCnpjFORMATADO;
            if (chkCnpj.Checked == true)
            {
                CpfOuCnpjFORMATADO = String.Format(@"{0:00\.000\.000\/0000-00}", cpf);
            }
            else
            {
                CpfOuCnpjFORMATADO = String.Format(@"{0:000\.000\.000\-00}", cpf);
            }

            MessageBox.Show(CpfOuCnpjFORMATADO);
        }
        public void CadastrarNovoCliente()
        {

            //Verificando se o usuario nao deixou nada em branco
            //if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || string.IsNullOrWhiteSpace(txtCPFCliente.Text)
            //    || txtNomeCliente.Text == "Nome do Cliente" || txtCPFCliente.Text == "CPF do Cliente")
            //if (chkTelRecados.Checked == true && txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente")
            //    || chkTelRecados.Checked == true && txtTratarCom.Text.Equals("Quem recebe o recado")
            //    || chkTelRecados.Checked == true && txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente") && txtTratarCom.Text.Equals("Quem recebe o recado"))
            //{
            //    MessageBox.Show("Favor preencher todos os campos do numero de recado.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            //}
            //else
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || txtNomeCliente.Text == "Nome do Cliente")
            {
                MessageBox.Show(@"Campos de nome está vazio, favor preencha-o", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else if (!(txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente")) && txtTratarCom.Text.Equals("Quem recebe o recado"))
            //{
            //    MessageBox.Show("Você preencheu o numero mas esqueceu de especificar com quem deixar o recado.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (chkSemCPF.Checked == true)
            else if (txtCPFCliente.Text.Equals("CPF do Cliente"))
            {
                //Pegar os dados dos campos
                string nome = txtNomeCliente.Text.ToString();
                //long cpf = Convert.ToInt64(txtCPFCliente.Text);
                string telPrincipal = txtTelefoneCliente.Text.ToString();
                string telRecados = txtTelefoneRecado.Text.ToString();
                string tratarCom = " | " + txtTratarCom.Text.ToString();
                
                //string CpfOuCnpjFORMATADO = String.Format(@"{0:000\.000\.000\-00}", cpf);
                //txt.Text = CpfOuCnpjFORMATADO;

                //txtTelefoneRecado nao esta sendo usado mais.
                if (string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) || txtTelefoneCliente.Text.Equals("Telefone Principal do Cliente") && txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente"))
                {
                    id.InserirCliente(nome, "SEM CPF/CNPJ", "", "");
                }
                else if (string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) || txtTelefoneCliente.Text.Equals("Telefone Principal do Cliente") && !(txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente")))
                {
                    //id.InserirCliente(nome, "SEM CPF/CNPJ", "", telRecados + tratarCom);
                    id.InserirCliente(nome, "SEM CPF/CNPJ", "", telRecados);
                }
                else if (!string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) && !txtTelefoneCliente.Text.Equals("Telefone Principal do Cliente") && txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente"))
                {
                    id.InserirCliente(nome, "SEM CPF/CNPJ", telPrincipal, "");
                }
                else
                {
                    id.InserirCliente(nome, "SEM CPF/CNPJ", telPrincipal, telRecados);
                }
            }
            else
            {
                //Pegar os dados dos campos
                string nome = txtNomeCliente.Text.ToString();
                long cpf = Convert.ToInt64(txtCPFCliente.Text);
                string telPrincipal = txtTelefoneCliente.Text.ToString();
                string telRecados = txtTelefoneRecado.Text.ToString();
                string tratarCom = " | " + txtTratarCom.Text.ToString();

                string CpfOuCnpjFORMATADO;
                if (chkCnpj.Checked == true)
                {
                    CpfOuCnpjFORMATADO = String.Format(@"{0:00\.000\.000\/0000-00}", cpf);
                }
                else
                {
                    CpfOuCnpjFORMATADO = String.Format(@"{0:000\.000\.000\-00}", cpf);
                }
                //txt.Text = CpfOuCnpjFORMATADO;
                if (string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) || txtTelefoneCliente.Text.Equals("Telefone Principal do Cliente") && txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente"))
                {
                    id.InserirCliente(nome, CpfOuCnpjFORMATADO, "", "");
                }
                else if (string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) || txtTelefoneCliente.Text.Equals("Telefone Principal do Cliente") && !(txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente")))
                {
                    //id.InserirCliente(nome, CpfOuCnpjFORMATADO, "", telRecados + tratarCom);
                    id.InserirCliente(nome, CpfOuCnpjFORMATADO, "", telRecados);
                }
                else if (!string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) && !txtTelefoneCliente.Text.Equals("Telefone Principal do Cliente") && txtTelefoneRecado.Text.Equals("Telefone de Recados do Cliente"))
                {
                    id.InserirCliente(nome, CpfOuCnpjFORMATADO, telPrincipal, "");
                }
                else
                {
                    //id.InserirCliente(nome, CpfOuCnpjFORMATADO, telPrincipal, telRecados + tratarCom);
                    id.InserirCliente(nome, CpfOuCnpjFORMATADO, telPrincipal, telRecados);
                }
            }

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

            txtTratarCom.Text = "Quem recebe o recado";
            txtTratarCom.Font = new Font(txtTratarCom.Font, FontStyle.Italic);
            txtTratarCom.ForeColor = Color.Silver;
            txtTratarCom.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCPFCliente.Text = "CPF do Cliente";
            txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
            txtCPFCliente.ForeColor = Color.Silver;
            txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            chkCnpj.Checked = false;
            chkSemCPF.Checked = false;

            //txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
            //txtTelefoneRecado.ForeColor = Color.Silver;
            //txtTelefoneRecado.LineIdleColor = Color.Gray;
            //txtTelefoneRecado.LineMouseHoverColor = Color.Gray;
            //chkTelRecados.Checked = false;
            //txtTelefoneRecado.Enabled = false;

            //txtTratarCom.Font = new Font(txtTratarCom.Font, FontStyle.Italic);
            //txtTratarCom.ForeColor = Color.Silver;
            //txtTratarCom.LineIdleColor = Color.Gray;
            //txtTratarCom.LineMouseHoverColor = Color.Gray;
            ////chkTelRecados.Checked = false;
            //txtTratarCom.Enabled = false;

            refreshTable();
        }
        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }

        private void txtCPFCliente_KeyDown(object sender, KeyEventArgs e)
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
            //form_CadastroClientes_Edit editarCliente = new form_CadastroClientes_Edit(this, corGeral);
            ////string cpfSemformatar = table_Clientes.SelectedCells[2].Value.ToString().Replace(".", "").Replace("-", "");
            //editarCliente.lblID.Text = table_Clientes.SelectedCells[0].Value.ToString();
            //editarCliente.txtNomeCliente.Text = table_Clientes.SelectedCells[1].Value.ToString();
            //editarCliente.txtCpf.Text = table_Clientes.SelectedCells[2].Value.ToString();//cpfSemformatar;
            //editarCliente.txtTelefone.Text = table_Clientes.SelectedCells[3].Value.ToString();
            //editarCliente.ShowDialog();
            //refreshTable();
        }

        private void chkSemCPF_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkSemCPF.Checked == true)
            {
                txtCPFCliente.Enabled = false;
                txtCPFCliente.LineIdleColor = Color.Gray;
                txtCPFCliente.LineMouseHoverColor = Color.Gray;
            }
            else
            {
                txtCPFCliente.Enabled = true;
                txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                txtCPFCliente.LineMouseHoverColor = Color.Lavender;
            }
        }

        private void chkCnpj_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkCnpj.Checked == true)
            {
                lblCpf.Text = "CNPJ";
                txtCPFCliente.Text = "CNPJ do Cliente";
                txtCPFCliente.MaxLength = 14;
            }
            else
            {
                lblCpf.Text = "CPF";
                txtCPFCliente.Text = "CPF do Cliente";
                txtCPFCliente.MaxLength = 11;
            }
        }

        public void ativarSecaoTelPrincipal()
        {
            lblTelefonePrincipal.Enabled = true;
            txtTelefoneCliente.Enabled = true;
        }
        public void desativarSecaoTelPrincipal()
        {
            lblTelefonePrincipal.Enabled = false;
            txtTelefoneCliente.Enabled = false;
        }
        public void ativarSecaoTelRecados()
        {
            lblTelefoneRecados.Enabled = true;
            txtTelefoneRecado.Enabled = true;
        }
        public void desativarSecaoTelRecados()
        {
            lblTelefoneRecados.Enabled = false;
            //lblTelefoneRecados.Location = new Point(578, 180);
            txtTelefoneRecado.Enabled = false;
        }

        private void chkTelRecados_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkTelRecados.Checked == true)
            {
                //txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
                //txtTelefoneCliente.ForeColor = Color.Silver;
                //txtTelefoneCliente.LineIdleColor = Color.Gray;
                //txtTelefoneCliente.LineMouseHoverColor = Color.Gray;
                //txtTelefoneCliente.Enabled = false;

                txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
                txtTelefoneRecado.ForeColor = Color.Silver;
                txtTelefoneRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                txtTelefoneRecado.LineMouseHoverColor = Color.Lavender;
                txtTelefoneRecado.Enabled = true;

                txtTratarCom.Font = new Font(txtTratarCom.Font, FontStyle.Italic);
                txtTratarCom.ForeColor = Color.Silver;
                txtTratarCom.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                txtTratarCom.LineMouseHoverColor = Color.Lavender;
                txtTratarCom.Enabled = true;
            }
            else
            {
                //txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
                //txtTelefoneCliente.ForeColor = Color.Silver;
                //txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                //txtTelefoneCliente.LineMouseHoverColor = Color.Lavender;
                //txtTelefoneCliente.Enabled = true;


                txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
                txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
                txtTelefoneRecado.ForeColor = Color.Silver;
                txtTelefoneRecado.LineIdleColor = Color.Gray;
                txtTelefoneRecado.LineMouseHoverColor = Color.Gray;
                txtTelefoneRecado.Enabled = false;

                txtTratarCom.Font = new Font(txtTratarCom.Font, FontStyle.Italic);
                txtTratarCom.Text = "Quem recebe o recado";
                txtTratarCom.ForeColor = Color.Silver;
                txtTratarCom.LineIdleColor = Color.Gray;
                txtTratarCom.LineMouseHoverColor = Color.Gray;
                txtTratarCom.Enabled = false;
            }
        }

        private void txtTelefoneRecado_Enter(object sender, EventArgs e)
        {
            if (txtTelefoneRecado.Enabled == true)
            {
                if (txtTelefoneRecado.Text == "Telefone de Recados do Cliente")
                {
                    txtTelefoneRecado.Text = "";
                    txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Regular);
                    txtTelefoneRecado.LineIdleColor = Color.White;
                    txtTelefoneRecado.ForeColor = Color.White;
                }
            }
        }

        private void txtTelefoneRecado_Leave(object sender, EventArgs e)
        {
            if (txtTelefoneRecado.Enabled == true)
            {
                if (txtTelefoneRecado.Text == "")
                {
                    txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
                    txtTelefoneRecado.Font = new Font(txtTelefoneRecado.Font, FontStyle.Italic);
                    txtTelefoneRecado.ForeColor = Color.Silver;
                    txtTelefoneRecado.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                }
            }

        }

        private void txtTelefoneRecado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }

        private void txtTratarCom_Enter(object sender, EventArgs e)
        {
            if (txtTratarCom.Enabled == true)
            {
                if (txtTratarCom.Text == "Quem recebe o recado")
                {
                    txtTratarCom.Text = "";
                    txtTratarCom.Font = new Font(txtTratarCom.Font, FontStyle.Regular);
                    txtTratarCom.LineIdleColor = Color.White;
                    txtTratarCom.ForeColor = Color.White;
                }
            }
        }

        private void txtTratarCom_Leave(object sender, EventArgs e)
        {
            if (txtTratarCom.Enabled == true)
            {
                if (txtTratarCom.Text == "")
                {
                    txtTratarCom.Text = "Quem recebe o recado";
                    txtTratarCom.Font = new Font(txtTratarCom.Font, FontStyle.Italic);
                    txtTratarCom.ForeColor = Color.Silver;
                    txtTratarCom.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                }
            }
        }

        private void txtTratarCom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarNovoCliente();
            }
        }
    }
}
