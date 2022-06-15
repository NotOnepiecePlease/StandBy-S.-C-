using PFC___StandBy_CSharp.ChecarUpdates;
using PFC___StandBy_CSharp.Graficos;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Dados;
using Application = System.Windows.Forms.Application;
using Point = System.Drawing.Point;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_StandBy : Form
    {
        private BackupDados bd = new BackupDados();
        private readonly GraficoServicosSemanais graficoSemanal = new GraficoServicosSemanais();
        private readonly GraficoServicosMensais graficoMensal = new GraficoServicosMensais();
        private readonly Verificar verificarUpd = new Verificar();
        private Form currentChildForm;

        private string statusAtualizacao = "";
        private readonly int mesAtual = DateTime.Now.Month;
        private int[] corGeral = new int[3] { 0, 0, 0 };
        private const string PASTA_RAIZ = @"./PasswordPattern";

        public form_StandBy()
        {
            InitializeComponent();
            //randomizarCores(100);
            IniciarPainelCor();
            bd.CriarDiretorioEscreverConfigs();
            CarregarGraficos();
            criarPastaDasSenhas();
            lblIpLocal.Text = PegarIp();

            btnMenuSuperior.DisabledColor = Color.Transparent;
            if (btnMenuSuperior.Enabled == false)
            {
                btnMenuSuperior.Cursor = Cursors.Default;
            }
            //verificarUpd.ChecarVersaoStandBy();

            //Aqui verifica a versao
            backVerificarVersao.RunWorkerAsync();
        }

        private string PegarIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                string localIP = endPoint.Address.ToString();
                return localIP;
            }
        }

        private void criarPastaDasSenhas()
        {
            if (Directory.Exists(PASTA_RAIZ))
            {
                //Caso exista a pasta, nao faz nada.
            }
            else
            {
                Directory.CreateDirectory(PASTA_RAIZ);
            }
        }

        private void CarregarGraficos()
        {
            try
            {
                graficoSemanal.PreencherUltimos7Dias(bunifuDataViz1, lblQntServicosSemanais);
                graficoMensal.Preencher(bunifuDataViz2, mesAtual, lblQntServicosMensais);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Nao foi possivel carregar os graficos pois nao existem dados", "Sem dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IniciarPainelCor()
        {
            corGeral[0] = track_RED.Value;
            lblRED.Text = track_RED.Value.ToString();
            //lblRED.ForeColor = Color.FromArgb(track_RED.Value, 0, 0);

            corGeral[1] = track_GREEN.Value;
            lblGREEN.Text = track_GREEN.Value.ToString();
            //lblGREEN.ForeColor = Color.FromArgb(0, track_GREEN.Value, 0);

            corGeral[2] = track_BLUE.Value;
            lblBLUE.Text = track_BLUE.Value.ToString();
            //lblBLUE.ForeColor = Color.FromArgb(0, 0, track_BLUE.Value);

            panel_CorGeral.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Tem certeza que deseja sair?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (dialog == DialogResult.Yes)
            //{
            Application.Exit();
            //}
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconRestaure_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            iconMaximize.Visible = true;
            iconRestaure.Visible = false;
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            iconMaximize.Visible = false;
            iconRestaure.Visible = true;
            //ordensserv.lblSituacao.Anchor = AnchorStyles.None;
        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Height == 50)
            {
                panelMenu.Visible = false;
                panelMenu.Height = 40;
                animationMenuHide1.Show(panelMenu);
            }
            else
            {
                panelMenu.Visible = false;
                panelMenu.Height = 50;
                animationMenuShow1.Show(panelMenu);
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

        private void btnServicosPorMes_Click(object sender, EventArgs e)
        {
            form_ServicosAnuais servMes1 = new form_ServicosAnuais(corGeral);
            servMes1.Show();
        }

        private void btnDesligarPc_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja desligar o computador?", "DESLIGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogo == DialogResult.Yes)
            {
                MessageBox.Show("Funcao desativada no momento para evitar problemas.");
                //Process.Start("shutdown", "/s /t 0");
            }
        }

        private void mudarCorGeral_Tick(object sender, EventArgs e)
        {
            corGeral[0] = track_RED.Value;
            lblRED.Text = track_RED.Value.ToString();

            corGeral[1] = track_GREEN.Value;
            lblGREEN.Text = track_GREEN.Value.ToString();

            corGeral[2] = track_BLUE.Value;
            lblBLUE.Text = track_BLUE.Value.ToString();

            btnServicosPorMes.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnDesligarPc.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardSemanais.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardsMensais.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardsBotoes.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardsCores.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelMenu.GradientBottomLeft = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelMenu.GradientBottomRight = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelMenu.GradientTopLeft = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNotepad.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnReset.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            iconClose.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSimAtualizar.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSimAtualizar.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            if ((corGeral[0] - 70) < 0)
            {
                btnSimAtualizar.onHoverState.BorderColor = Color.FromArgb(0, corGeral[1], corGeral[2]);
                btnSimAtualizar.onHoverState.FillColor = Color.FromArgb(0, corGeral[1], corGeral[2]);
                btnSimAtualizar.OnPressedState.FillColor = Color.FromArgb(0, corGeral[1], corGeral[2]);
                btnSimAtualizar.OnPressedState.BorderColor = Color.FromArgb(0, corGeral[1], corGeral[2]);
            }
            else
            {
                btnSimAtualizar.onHoverState.BorderColor = Color.FromArgb(corGeral[0] - 50, corGeral[1], corGeral[2]);
                btnSimAtualizar.onHoverState.FillColor = Color.FromArgb(corGeral[0] - 50, corGeral[1], corGeral[2]);
                btnSimAtualizar.OnPressedState.FillColor = Color.FromArgb(corGeral[0] - 70, corGeral[1], corGeral[2]);
                btnSimAtualizar.OnPressedState.BorderColor = Color.FromArgb(corGeral[0] - 70, corGeral[1], corGeral[2]);
            }

            panel_CorGeral.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void randomizarCores(int _corInicial)
        {
            //Deixar random
            //Random random = new Random();
            //corGeral[0] = random.Next(_corInicial, 255);
            //corGeral[1] = random.Next(_corInicial, 255);
            //corGeral[2] = random.Next(_corInicial, 255);

            //Cor fixa
            Random random = new Random();
            corGeral[0] = random.Next(_corInicial, 255);
            corGeral[1] = random.Next(_corInicial, 255);
            corGeral[2] = random.Next(_corInicial, 255);

            track_RED.Value = corGeral[0];
            track_GREEN.Value = corGeral[1];
            track_BLUE.Value = corGeral[2];

            lblRED.Text = corGeral[0].ToString();
            lblGREEN.Text = corGeral[1].ToString();
            lblBLUE.Text = corGeral[2].ToString();

            panel_CorGeral.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnServicosPorMes.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnDesligarPc.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardSemanais.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardsMensais.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardsBotoes.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            buniCardsCores.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelMenu.GradientBottomLeft = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelMenu.GradientBottomRight = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelMenu.GradientTopLeft = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNotepad.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnReset.colorActive = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            iconClose.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void btnMudarCor_Click(object sender, EventArgs e)
        {
            randomizarCores(0);
        }

        public void ResetarCor()
        {
            Color cor = Color.FromArgb(255, 0, 103);
            btnServicosPorMes.colorActive = cor;
            btnDesligarPc.colorActive = cor;
            buniCardSemanais.color = cor;
            buniCardsMensais.color = cor;
            buniCardsBotoes.color = cor;
            buniCardsCores.color = cor;
            panelMenu.GradientBottomLeft = cor;
            panelMenu.GradientBottomRight = cor;
            panelMenu.GradientTopLeft = cor;
            btnNotepad.colorActive = cor;
            btnReset.colorActive = cor;
            iconClose.IconColor = cor;
            corGeral = new int[] { 255, 0, 103 };

            track_RED.Value = 255;
            track_GREEN.Value = 0;
            track_BLUE.Value = 103;
            panel_CorGeral.BackColor = cor;
        }

        private void track_RED_ValueChanged(object sender, EventArgs e)
        {
            mudarCorGeral.Start();
        }

        private void track_RED_ValueChangeComplete(object sender, EventArgs e)
        {
            mudarCorGeral.Stop();
        }

        private void track_GREEN_ValueChanged(object sender, EventArgs e)
        {
            mudarCorGeral.Start();
        }

        private void track_GREEN_ValueChangeComplete(object sender, EventArgs e)
        {
            mudarCorGeral.Stop();
        }

        private void track_BLUE_ValueChanged(object sender, EventArgs e)
        {
            mudarCorGeral.Start();
        }

        private void track_BLUE_ValueChangeComplete(object sender, EventArgs e)
        {
            mudarCorGeral.Stop();
        }

        private void btnResetarCor_Click(object sender, EventArgs e)
        {
            ResetarCor();
        }

        private void imgbuttonTitulo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\TITULO STANDBY SYSTEM.png");
        }

        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_OrdensServ>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_OrdensServ(corGeral));
                //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\TITULO ORDENS DE SERVICO.png");
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_CadastroClientes>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_CadastroClientes(corGeral));
                //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\TITULO CADASTRO CLIENTES.png");
            }
        }

        private void btnConcluidos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Concluidos>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_Concluidos(corGeral));
                //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\SERVICOS COMPLETOS.png");
            }

            //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\TITULO CADASTRO CLIENTES.png");
        }

        private void btnLucros_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Lucros>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_Lucros(corGeral));
                //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\LUCROS.png");
            }
            //
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Orcamento>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                //OpenChildForm(new form_Gastos(corGeral));
                OpenChildForm(new form_Orcamento(corGeral));
                //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\ORCAMENTOS.png");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            form_Notepad notepad = new form_Notepad(corGeral);
            notepad.Show();
        }

        private void form_StandBy_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Teste");
            if (e.KeyCode == Keys.F2)
            {
                if (Application.OpenForms.OfType<form_OrdensServ>().Count() > 0)
                {
                    //MessageBox.Show("O Form2 já está aberto!");
                }
                else
                {
                    OpenChildForm(new form_OrdensServ(corGeral));
                    //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\TITULO ORDENS DE SERVICO.png");
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcao desativada pois o sistema efetua o reset automaticamente.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //DialogResult dialog1 = MessageBox.Show("Voce esta prestes a resetar o mês, fazendo isso voce armazena todos os dados" +
            //    "com segurança no banco de dados e reinicia todas as tabelas dos dados do mês em questão, essa ação é irreversivel," +
            //    " você tem certeza disso?", "----- PERIGO -----", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            //if (dialog1 == DialogResult.Yes)
            //{
            //    DialogResult dialog2 = MessageBox.Show("ULTIMO AVISO!!!\n\nEfetue o reset apenas se você tiver permissão para isso, essa ação" +
            //        " não poderá ser desfeita, voce tem certeza do que está fazendo?", "ULTIMO AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            //    if (dialog2 == DialogResult.Yes)
            //    {
            //        ad.ResetarDadosMensais();
            //    }
            //}
        }

        private void form_StandBy_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void form_StandBy_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    Hide();
            //    notifyIcon1.Visible = true;
            //    notifyIcon1.ShowBalloonTip(1000);
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            // notifyIcon1.ShowBalloonTip(1000);
        }

        private void backVerificarVersao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            lblUpdate.Text = @"Verificando atualizações...";
            lblUpdate.ForeColor = Color.DarkOrange;
            lblUpdate.Location = new Point(150, 9);

            statusAtualizacao = verificarUpd.ChecarVersaoStandBy();
            if (statusAtualizacao == "Atualização Pendente!")
            {
                lblUpdate.Text = @"Atualização Pendente!";
                lblUpdate.ForeColor = Color.Yellow;
                lblUpdate.Location = new Point(157, 9);
            }
            else if (statusAtualizacao == "Sistema Atualizado!")
            {
                lblUpdate.Text = @"Sistema Atualizado!";
                lblUpdate.ForeColor = Color.LawnGreen;
                lblUpdate.Location = new Point(164, 9);
            }
            else if (statusAtualizacao == "Erro ao atualizar!")
            {
                lblUpdate.Text = @"Erro ao atualizar";
                lblUpdate.ForeColor = Color.Crimson;
                lblUpdate.Location = new Point(164, 9);
            }
            else
            {
                lblUpdate.Text = @"Erro Desconhecido!";
                lblUpdate.ForeColor = Color.AntiqueWhite;
                lblUpdate.Location = new Point(165, 9);
            }
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

        private void lblIpLocal_Click(object sender, EventArgs e)
        {
            lblIpLocal.Text = PegarIp();
        }

        private void form_StandBy_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            backVerificarVersao.RunWorkerAsync();
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