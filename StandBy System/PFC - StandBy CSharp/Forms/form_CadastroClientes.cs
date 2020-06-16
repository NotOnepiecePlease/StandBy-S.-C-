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
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCadastrarCliente.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //table_Clientes.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            contextMenuStrip1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void txtNomeCliente_Enter(object sender, EventArgs e)
        {
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
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            if (txtCPFCliente.Text == "")
            {
                txtCPFCliente.Text = "CPF do Cliente";
                txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
                txtCPFCliente.ForeColor = Color.Silver;
                txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtTelefoneCliente_Enter(object sender, EventArgs e)
        {
            if (txtTelefoneCliente.Text == "Telefone do Cliente")
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
                txtTelefoneCliente.Text = "Telefone do Cliente";
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
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //Verificando se o usuario nao deixou nada em branco
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || string.IsNullOrWhiteSpace(txtCPFCliente.Text)
                || txtNomeCliente.Text == "Nome do Cliente" || txtCPFCliente.Text == "CPF do Cliente")
            {
                MessageBox.Show("Campos de nome ou cpf estão vazios, favor preencha-os", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Pegar os dados dos campos
                string nome = txtNomeCliente.Text.ToString();
                long cpf = Convert.ToInt64(txtCPFCliente.Text);
                string tel = txtTelefoneCliente.Text.ToString();

                string CPFFormatado = String.Format(@"{0:\000\.000\.000\-00}", cpf);
                //txt.Text = CPFFormatado;
                if (string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) || txtTelefoneCliente.Text.Equals("Telefone do Cliente"))
                {
                    id.InserirCliente(nome, CPFFormatado, "");
                }
                else
                {
                    id.InserirCliente(nome, CPFFormatado, tel);
                }
            }

            //Limpar os campos
            txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            txtPesquisarCADCliente.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Italic);
            txtPesquisarCADCliente.ForeColor = Color.Silver;
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtNomeCliente.Text = "Nome do Cliente";
            txtNomeCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtNomeCliente.ForeColor = Color.Silver;
            txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneCliente.Text = "Telefone do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;
            txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCPFCliente.Text = "CPF do Cliente";
            txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
            txtCPFCliente.ForeColor = Color.Silver;
            txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            refreshTable();
        }

        private void txtPesquisarCADCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_CadastroClientes_Edit editarCliente = new form_CadastroClientes_Edit(this, corGeral);
            string cpfSemformatar = table_Clientes.SelectedCells[2].Value.ToString().Replace(".", "").Replace("-", "");
            editarCliente.lblID.Text = table_Clientes.SelectedCells[0].Value.ToString();
            editarCliente.txtNomeCliente.Text = table_Clientes.SelectedCells[1].Value.ToString();
            editarCliente.txtCpf.Text = cpfSemformatar;
            editarCliente.txtTelefone.Text = table_Clientes.SelectedCells[3].Value.ToString();
            editarCliente.ShowDialog();
            //refreshTable();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja deletar esse cliente?", "DELETAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || string.IsNullOrWhiteSpace(txtCPFCliente.Text)
                || txtNomeCliente.Text == "Nome do Cliente" || txtCPFCliente.Text == "CPF do Cliente")
            {
                MessageBox.Show("Campos de nome ou cpf estão vazios, favor preencha-os", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Pegar os dados dos campos
                string nome = txtNomeCliente.Text.ToString();
                long cpf = Convert.ToInt64(txtCPFCliente.Text);
                string tel = txtTelefoneCliente.Text.ToString();

                string CPFFormatado = String.Format(@"{0:\000\.000\.000\-00}", cpf);
                //txt.Text = CPFFormatado;
                id.InserirCliente(nome, CPFFormatado, tel);
            }

            //Limpar os campos
            txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            txtPesquisarCADCliente.Font = new Font(txtPesquisarCADCliente.Font, FontStyle.Italic);
            txtPesquisarCADCliente.ForeColor = Color.Silver;
            txtPesquisarCADCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtNomeCliente.Text = "Nome do Cliente";
            txtNomeCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtNomeCliente.ForeColor = Color.Silver;
            txtNomeCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtTelefoneCliente.Text = "Telefone do Cliente";
            txtTelefoneCliente.Font = new Font(txtTelefoneCliente.Font, FontStyle.Italic);
            txtTelefoneCliente.ForeColor = Color.Silver;
            txtTelefoneCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtCPFCliente.Text = "CPF do Cliente";
            txtCPFCliente.Font = new Font(txtCPFCliente.Font, FontStyle.Italic);
            txtCPFCliente.ForeColor = Color.Silver;
            txtCPFCliente.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

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
    }
}
