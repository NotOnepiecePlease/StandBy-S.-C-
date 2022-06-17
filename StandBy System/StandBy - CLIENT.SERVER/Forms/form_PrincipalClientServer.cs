using PFC___StandBy_CSharp.Forms;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.ChecarUpdates;
using StandBy___CLIENT.SERVER.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER
{
    public partial class form_PrincipalClientServer : Form
    {
        private Form currentChildForm;
        private readonly Verificar verificarUpd = new Verificar();
        private readonly conexao con = new conexao();
        private string statusAtualizacao = "";

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

            if (e.KeyCode == Keys.NumPad1 && e.Modifiers == Keys.Control)
            {
                form_SQLConfig formSql = new form_SQLConfig();
                formSql.Show();
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
            //backVerificarConexao.RunWorkerAsync();
            //ListaIps();
            getIps();
        }

        private void getIps()
        {
            var list = new List<string>();
            var list2 = new List<string>();
            string subnet = "192.168.1";

            Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                            list.Add(ip + "- " + host.HostName + "- Up");
                        }
                        catch
                        {
                            MessageBox.Show($"Couldn't retrieve hostname from {ip}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        list2.Add(ip + "" + "- Down");
                    }
                }
            }));
        }

        public static Dictionary<string, string> ListaIps()
        {
            Dictionary<string, string> listaIpsComMac = new Dictionary<string, string>();
            Process processo = new Process();

            processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec") ?? string.Empty; //comspec = é o processo do CMD

            // Formata a string para passar como argumento para o cmd.exe
            processo.StartInfo.Arguments = "/c arp -a";

            processo.StartInfo.RedirectStandardOutput = true;
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.CreateNoWindow = true;

            processo.Start();
            processo.WaitForExit();

            string saida = processo.StandardOutput.ReadToEnd();
            string padraoIP = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
            string padraoMAC = @"\w{1,2}\-\w{1,2}\-\w{1,2}\-\w{1,2}\-\w{1,2}\-\w{1,2}";
            //string pattern = @"";

            MatchCollection matches;
            Regex regexIP = new Regex(padraoIP);
            matches = regexIP.Matches(saida);

            int cont = 0;
            foreach (Match ips in matches)
            {
                if (cont == 0)
                {
                }
                else
                {
                    listaIpsComMac.Add(ips.ToString(), "-");
                }

                cont++;
            }

            Regex regexMAC = new Regex(padraoMAC);
            matches = regexMAC.Matches(saida);

            int indice = 0;
            foreach (Match enderecoMAC in matches)
            {
                listaIpsComMac[listaIpsComMac.ElementAt(indice).Key] = enderecoMAC.ToString();
                indice++;
            }
            return listaIpsComMac;
        }

        private void backVerificarVersao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            lblUpdate.Text = @"Verificando atualizações...";
            lblUpdate.ForeColor = Color.DarkOrange;
            lblUpdate.Location = new Point(187, 9);

            //verificarUpd.ChecarVersaoStandBy(this);
            statusAtualizacao = verificarUpd.ChecarVersaoClientServer();

            if (statusAtualizacao == "Atualização Pendente!")
            {
                lblUpdate.Text = @"Atualização Pendente!";
                lblUpdate.ForeColor = Color.Yellow;
                lblUpdate.Location = new Point(196, 9);
            }
            else if (statusAtualizacao == "Sistema Atualizado!")
            {
                lblUpdate.Text = @"Sistema Atualizado!";
                lblUpdate.ForeColor = Color.LawnGreen;
                lblUpdate.Location = new Point(200, 9);
            }
            else if (statusAtualizacao == "Erro ao atualizar!")
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

        private void backVerificarVersao_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //lblUpdate.Visible = false;
            lblUpdate.Visible = true;

            if (statusAtualizacao == "Atualização Pendente!")
            {
                lblDesejaAtualizar.Visible = true;
                btnSimAtualizar.Visible = true;
                btnNaoAtualizar.Visible = true;
            }
            else
            {
                lblDesejaAtualizar.Visible = false;
                btnSimAtualizar.Visible = false;
                btnNaoAtualizar.Visible = false;
            }
        }

        private void btnSimAtualizar_Click(object sender, EventArgs e)
        {
            verificarUpd.ForcarAtualizacao();
        }

        private void btnNaoAtualizar_Click(object sender, EventArgs e)
        {
            lblDesejaAtualizar.Visible = false;
            btnSimAtualizar.Visible = false;
            btnNaoAtualizar.Visible = false;
        }
    }
}