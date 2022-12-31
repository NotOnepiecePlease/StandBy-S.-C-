using PFC___StandBy_CSharp.ChecarUpdates;
using PFC___StandBy_CSharp.Graficos;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Models;

//using PFC___StandBy_CSharp.LogSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz.WinForms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using Application = System.Windows.Forms.Application;
using Point = System.Drawing.Point;
using Newtonsoft.Json;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_StandBy : Form
    {
        private readonly BackupDados bd = new BackupDados();
        private static readonly GraficoServicosSemanais graficoSemanal = new GraficoServicosSemanais();
        private static readonly GraficoServicosMensais graficoMensal = new GraficoServicosMensais();
        private Verificar verificarUpd = new Verificar();
        private Form currentChildForm;
        private form_ServicoPrincipal formPrincipal;
        private string statusAtualizacao = "";
        private static readonly int mesAtual = DateTime.Now.Month;
        private int[] corGeral = new int[3] { 0, 0, 0 };
        private const string PASTA_RAIZ = @"./PasswordPattern";

        public form_StandBy()
        {
            InitializeComponent();
            InicializarSkinStandbyDevexpress();
            CarregarGraficos(bunifuDataViz1, lblQntServicosSemanais, bunifuDataViz2, lblQntServicosMensais);
            //Pega a versão do sistema e seta na label.
            lblVersion.Text = verificarUpd.VERSAO_STANDBY;
            //Aqui sao todos os itens que inicializa junto com o form.
            workerInicializarJuntoComForm.RunWorkerAsync();
            //Aqui ele verifica a versao do sistema.
            workerVerificarVersao.RunWorkerAsync();

            formPrincipal = new form_ServicoPrincipal();
            formPrincipal.Show();
            formPrincipal.Hide();
            //Logs.GerarLogErro();
        }

        private void InicializarSkinStandbyDevexpress()
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);

            var commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            SvgPalette svgPalette = commonSkin.SvgPalettes[Skin.DefaultSkinPaletteName] as SvgPalette;

            commonSkin.CustomSvgPalettes.Add(new SvgPaletteKey(commonSkin.CustomSvgPalettes.Count, "StandBy THEME"), svgPalette);
            UserLookAndFeel.Default.SetSkinStyle(commonSkin.Name, "StandBy THEME");
        }

        private void workerInicializarJuntoComForm_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            IniciarPainelCor();
            bd.CriarDiretorioEscreverConfigs();
            criarPastaDasSenhas();
            lblIpLocal.Text = PegarIp();

            if (btnMenuSuperior.Enabled == false)
            {
                btnMenuSuperior.Cursor = Cursors.Default;
            }
        }

        private async Task APIMunicipio()
        {
            string path = @"./Municipios.txt";
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://servicodados.ibge.gov.br/api/v1/localidades/distritos");
                string content = await response.Content.ReadAsStringAsync();

                var jsonDeserializado = JsonConvert.DeserializeObject<List<MunicipioModel.Municipio>>(content);

                jsonDeserializado?.OrderBy(x => x.Nome)
                    .ToList()
                    .GroupBy(x => x.Nome)
                    .Select(x => x.First())
                    .ToList().ForEach(m => File.AppendAllText(path, m.Nome + "\n"));
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e.Message}");
            }
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

        private static async void CarregarGraficos(BunifuDataViz _datavizSemanal, Label _lblQntServicosSemanais, BunifuDataViz _datavizMensal, Label _lblQntServicosMensais)
        {
            await CarregarGraficosAsync(_datavizSemanal, _lblQntServicosSemanais, _datavizMensal, _lblQntServicosMensais);
        }

        private static async Task CarregarGraficosAsync(BunifuDataViz _datavizSemanal, Label _lblQntServicosSemanais, BunifuDataViz _datavizMensal, Label _lblQntServicosMensais)
        {
            try
            {
                await graficoSemanal.PreencherUltimos7Dias(_datavizSemanal, _lblQntServicosSemanais);
                await graficoMensal.Preencher(_datavizMensal, mesAtual, _lblQntServicosMensais);
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
            formPrincipal.Hide(); //Form principal é carregado diferente dos outros
            formFilho.Show();
            //lblAbaAtual.Text = formFilho.Text;
        }

        private void OpenChildForm(form_ServicoPrincipal formFilho)
        {
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(formFilho);
            panelCentral.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
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

            btnClientes.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnClientes.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnClientes.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnServicos.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnServicos.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnServicos.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnConcluidos.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnConcluidos.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnConcluidos.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //btnOrcamentos.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnOrcamentos.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            // btnOrcamentos.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnLucros.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnLucros.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnLucros.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnMenuSuperior.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnMenuSuperior.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnMenuSuperior.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnMenuSuperior.DisabledColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
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

            btnClientes.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnClientes.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnClientes.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnServicos.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnServicos.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnServicos.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnConcluidos.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnConcluidos.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnConcluidos.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //btnOrcamentos.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //btnOrcamentos.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            // btnOrcamentos.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnLucros.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnLucros.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnLucros.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnMenuSuperior.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnMenuSuperior.Iconcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnMenuSuperior.Normalcolor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnMenuSuperior.DisabledColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
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
            btnClientes.BackColor = cor;
            btnClientes.Iconcolor = cor;
            btnClientes.Normalcolor = cor;
            btnServicos.BackColor = cor;
            btnServicos.Iconcolor = cor;
            btnServicos.Normalcolor = cor;
            btnConcluidos.BackColor = cor;
            btnConcluidos.Iconcolor = cor;
            btnConcluidos.Normalcolor = cor;
            //btnOrcamentos.BackColor = cor;
            //btnOrcamentos.Iconcolor = cor;
            // btnOrcamentos.Normalcolor = cor;
            btnLucros.BackColor = cor;
            btnLucros.Iconcolor = cor;
            btnLucros.Normalcolor = cor;
            btnMenuSuperior.BackColor = cor;
            btnMenuSuperior.Iconcolor = cor;
            btnMenuSuperior.Normalcolor = cor;
            btnMenuSuperior.DisabledColor = cor;
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
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<form_OrdensServ>().Count() > 0)
            if (Application.OpenForms.OfType<form_ServicoPrincipal>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
                OpenChildForm(formPrincipal);
            }
            else
            {
                if (formPrincipal == null)
                {
                    formPrincipal = new form_ServicoPrincipal();
                    OpenChildForm(formPrincipal);
                }
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
                OpenChildForm(new form_Lucros(corGeral));
            }
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Orcamento>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
            }
            else
            {
                OpenChildForm(new form_Orcamento(corGeral));
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

        private void workerVerificarVersao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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

        private void workerVerificarVersao_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
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
            //workerInicializarJuntoComForm.RunWorkerAsync();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            workerVerificarVersao.RunWorkerAsync();
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