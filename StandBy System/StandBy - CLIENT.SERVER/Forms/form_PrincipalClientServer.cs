using PFC___StandBy_CSharp.Forms;
using StandBy___CLIENT.SERVER.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.ChecarUpdates;

namespace StandBy___CLIENT.SERVER
{
    public partial class form_PrincipalClientServer : Form
    {
        private Form currentChildForm;
        private readonly Verificar verificarUpd = new Verificar();
        private readonly conexao con = new conexao();

        public form_PrincipalClientServer()
        {
            InitializeComponent();
            PegarIp();
            CheckForIllegalCrossThreadCalls = false;
            backVerificarConexao.RunWorkerAsync();
            backVerificarVersao.RunWorkerAsync();
        }

        public void PegarIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                string localIP;
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
                lblIp.Text = localIP + ",1433";
            }
        }

        private void OpenChildForm(Form formFilho)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
            }

            currentChildForm = formFilho;
            //End
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(formFilho);
            panelCentral.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTodosServicos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Concluidos>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_Concluidos(new[] { 255, 0, 103 }));

                btnServicosAndamento.Normalcolor = Color.Transparent;
                btnLucros.Normalcolor = Color.Transparent;

                btnTodosServicos.Normalcolor = Color.Black;
            }
        }

        private void btnServicosAndamento_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_ServicosAndamento>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_ServicosAndamento());

                btnTodosServicos.Normalcolor = Color.Transparent;
                btnLucros.Normalcolor = Color.Transparent;

                btnServicosAndamento.Normalcolor = Color.Black;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btnLucros_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Lucros>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_Lucros(new[] { 255, 0, 103 }));

                btnTodosServicos.Normalcolor = Color.Transparent;
                btnServicosAndamento.Normalcolor = Color.Transparent;

                btnLucros.Normalcolor = Color.Black;
            }
        }

        private void imgbuttonTitulo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();

                btnTodosServicos.Normalcolor = Color.Transparent;
                btnServicosAndamento.Normalcolor = Color.Transparent;
                btnLucros.Normalcolor = Color.Transparent;
            }
        }

        private void backVerificarConexao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            lblEstadoConexao.Text = @"Conectando...";
            lblEstadoConexao.ForeColor = Color.DarkOrange;

            string status = con.StatusConexao();
            if (status == "Aberta")
            {
                lblEstadoConexao.Text = @"Conectado ao Servidor!";
                lblEstadoConexao.ForeColor = Color.LawnGreen;
            }
            else if (status == "Fechada")
            {
                lblEstadoConexao.Text = @"Servidor Desconectado!";
                lblEstadoConexao.ForeColor = Color.Red;
            }
            else
            {
                lblEstadoConexao.Text = @"Erro, clique aqui e tente novamente!";
                lblEstadoConexao.ForeColor = Color.AntiqueWhite;
            }
        }

        private void lblEstadoConexao_Click(object sender, EventArgs e)
        {
            backVerificarConexao.RunWorkerAsync();
        }

        private void backVerificarVersao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            lblUpdate.Text = @"Verificando atualizações...";
            lblUpdate.ForeColor = Color.DarkOrange;
            lblUpdate.Location = new Point(187, 9);

            //verificarUpd.ChecarVersaoStandBy(this);
            string atualizacao = verificarUpd.ChecarVersaoClientServer();

            if (atualizacao == "Atualização Pendente!")
            {
                lblUpdate.Text = @"Atualização Pendente!";
                lblUpdate.ForeColor = Color.Yellow;
                lblUpdate.Location = new Point(196, 9);
            }
            else if (atualizacao == "Sistema Atualizado!")
            {
                lblUpdate.Text = @"Sistema Atualizado!";
                lblUpdate.ForeColor = Color.LawnGreen;
                lblUpdate.Location = new Point(200, 9);
            }
            else if (atualizacao == "Erro ao atualizar!")
            {
                lblUpdate.Text = @"Erro ao atualizar!";
                lblUpdate.ForeColor = Color.Crimson;
                lblUpdate.Location = new Point(207, 9);
            }
            else
            {
                lblUpdate.Text = @"Erro Desconhecido!";
                lblUpdate.ForeColor = Color.AntiqueWhite;
                lblUpdate.Location = new Point(201, 9);
            }
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            backVerificarVersao.RunWorkerAsync();
        }
    }
}