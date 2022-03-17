using PFC___StandBy_CSharp.Forms;
using StandBy___CLIENT.SERVER.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER
{
    public partial class form_PrincipalClientServer : Form
    {
        private Form currentChildForm;

        public form_PrincipalClientServer()
        {
            InitializeComponent();
            PegarIp();
        }

        public void PegarIp()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
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
            //lblAbaAtual.Text = formFilho.Text;
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
    }
}