﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.Devices;
using DevExpress.XtraSplashScreen;
using NLog;
using PFC___StandBy_CSharp.Utils;
using LogLevel = NLog.LogLevel;
using PFC___StandBy_CSharp.ChecarUpdates;
using PFC___StandBy_CSharp.Dados;
using Microsoft.Win32;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using System.Net.Sockets;
using System.Net;
using DevExpress.XtraEditors;
using PFC___StandBy_CSharp.Forms.UserControl;
using PFC___StandBy_CSharp.ConsoleLogServer;
using DevExpress.XtraGrid;

namespace PFC___StandBy_CSharp.Forms.Testes
{
    public partial class form_V2Standby : DevExpress.XtraEditors.XtraForm
    {


        private readonly BackupDados bd = new BackupDados();
        private Form currentChildForm;
        private XtraUserControl currentChildForm2;
        private NLog.Logger logger = LogManager.GetCurrentClassLogger();
        private Verificar verificarUpd = new Verificar();
        private string statusAtualizacao = "";
        private const string PASTA_RAIZ = @"./PasswordPattern";
        private form_ServicoPrincipal form_Principal = new form_ServicoPrincipal();
        private ucTelaPrincipal ucPrincipal = new ucTelaPrincipal();
        public form_V2Standby()
        {
            InitializeComponent();
            //MODO DEBUG LOG
            ConsoleLog.EnviarMensagemInfo($"Inicializando o Sistema StandBy");
            ConsoleLog.EnviarMensagemInfo($"Carregando opções de checklist de entrada");
            Constantes.IniciarOpcoesChecklistEntrada();
            InicializarSkinStandbyDevexpress();
            menuSuperior.OptionsBar.DrawDragBorder = false;
            sourceServicosSemanais.Fill();
            sourceServicosMensais.Fill();
            lblVersao.Caption = "v" + verificarUpd.VERSAO_STANDBY;

            //Aqui sao todos os itens que inicializa junto com o form.
            workerInicializarJuntoComForm.RunWorkerAsync();

            //Aqui ele verifica a versao do sistema.
            ConsoleLog.EnviarMensagemInfo($"Verificando a versão do sistema...");
            workerVerificarVersao.RunWorkerAsync();

            var thread = new Thread(MonitorCpu);
            thread.Start();

            //InicializarMenuAreaTrabalho();
            CriarPastaConfig();


            ucPrincipal.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ucPrincipal);
            panelControl1.Tag = ucPrincipal;
            ucPrincipal.Hide();

            ConsoleLog.EnviarMensagemInfo($"Sistema StandBy Iniciado!");
        }


        private void CriarPastaConfig()
        {
            if (!Directory.Exists("C:\\StandBy_Config"))
            {
                Directory.CreateDirectory("C:\\StandBy_Config");
            }
        }
        private void InicializarSkinStandbyDevexpress()
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);

            var commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            SvgPalette svgPalette = commonSkin.SvgPalettes[Skin.DefaultSkinPaletteName] as SvgPalette;

            commonSkin.CustomSvgPalettes.Add(new SvgPaletteKey(commonSkin.CustomSvgPalettes.Count, "StandBy THEME")
                , svgPalette);
            UserLookAndFeel.Default.SetSkinStyle(commonSkin.Name, "StandBy THEME");
        }

        private void InicializarMenuAreaTrabalho()
        {
            try
            {
                // Caminho para o executável ou script que será executado ao selecionar a opção no menu de contexto
                string pathToExecutable =
                    "D:\\@C Sharp\\TCC\\GIT\\StandBy-S.-C-\\@Private GIT\\StandByPRIVATE\\StandBy-S.-C-\\StandBy System\\PFC - StandBy CSharp\\bin\\Debug\\StandBy System.exe";

                // Nome e descrição da opção no menu de contexto
                string optionName = "StandBy System";
                string optionDescription = "StandBy System";

                // Caminho para o ícone personalizado (arquivo .ico)
                string iconPath = "icone.ico";
                //string iconPath = "D:\\@C Sharp\\TCC\\GIT\\StandBy-S.-C-\\@Private GIT\\StandByPRIVATE\\StandBy-S.-C-\\StandBy System\\PFC - StandBy CSharp\\icone.ico";

                // Adicionando a entrada do registro para a opção no menu de contexto
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(@"Directory\Background\shell\" + optionName))
                {
                    key.SetValue("", optionDescription);
                    key.CreateSubKey("command").SetValue("", pathToExecutable);

                    // Adicionando o valor do ícone
                    using (RegistryKey iconKey = key.CreateSubKey("DefaultIcon"))
                    {
                        iconKey.SetValue("", iconPath);
                    }
                }

                // Notificar o sistema operacional sobre as alterações no registro
                //SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);
                // Notificar o sistema operacional sobre as alterações usando RUNDLL32.EXE
                Process.Start("RUNDLL32.EXE", "USER32.DLL,UpdatePerUserSystemParameters");

                //MessageBox.Show("Opção adicionada com sucesso ao menu de contexto da área de trabalho.");
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERRO: \n\n{e}");
            }
        }

        private void MonitorCpu()
        {
            try
            {
                var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                var computerInfo = new ComputerInfo();
                var totalMemory = computerInfo.TotalPhysicalMemory / (1024 * 1024);
                var memoryCounter = new PerformanceCounter("Memory", "Available MBytes");
                while (true)
                {
                    var cpu = cpuCounter.NextValue();
                    var memory = memoryCounter.NextValue();
                    var memoryPercent = (memory / (double)totalMemory) * 100;

                    progressMemoriaGeral.Invoke((MethodInvoker)delegate
                    {
                        progressMemoriaGeral.Value = Convert.ToInt32(memoryPercent);

                        //Console.WriteLine(memoryPercent + "%");
                    });
                    progressCPU.Invoke((MethodInvoker)delegate
                    {
                        progressCPU.Value = Convert.ToInt32(cpu);
                    });
                    Thread.Sleep(500);
                }
            }
            catch (Exception)
            {
                //Log
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            SeriesBase series = graficoSemanal.Series[0];
            series.ChangeView(ViewType.Pie);
        }

        private void form_V2Standby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                form_DeveloperCommand formDeveloper = new form_DeveloperCommand();
                formDeveloper.Show();
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (Application.OpenForms.OfType<form_OrdensServ>().Count() > 0)
                {
                    //MessageBox.Show("O Form2 já está aberto!");
                }
                else
                {
                    OpenChildForm(new form_OrdensServ(new int[] { 255, 0, 103 }));

                    //imgbuttonTitulo.Image = Image.FromFile(@"..\\..\\Resources\\TITULO ORDENS DE SERVICO.png");
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void form_V2Standby_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnTelaClientesMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var handle = Loading.Init(this))
            {
                handle.QueueFocus(IntPtr.Zero);
                Thread.Sleep(500);
                if (Application.OpenForms.OfType<form_CadastroClientes>().Count() > 0)
                {
                    //MessageBox.Show("O Form2 já está aberto!");
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].Name == "form_CadastroClientes")
                        {
                            Application.OpenForms[i].Close();
                            OpenChildForm(new form_CadastroClientes(new int[] { 255, 0, 103 }));
                            break;
                        }
                    }
                }
                else
                {
                    OpenChildForm(new form_CadastroClientes(new int[] { 255, 0, 103 }));

                    if (ucPrincipal != null)
                    {
                        ucPrincipal.Dispose();
                        ucPrincipal = new ucTelaPrincipal();
                        ucPrincipal.Dock = DockStyle.Fill;
                        panelControl1.Controls.Add(ucPrincipal);
                        panelControl1.Tag = ucPrincipal;
                        ucPrincipal.Hide();
                    }

                }
            }
        }

        private void btnServicosTelaPrincipal_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var handle = Loading.Init(this))
            {
                handle.QueueFocus(IntPtr.Zero);
                Thread.Sleep(500);
                if (Application.OpenForms.OfType<form_ServicoPrincipal>().Count() > 0)
                {
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].Name == "form_ServicoPrincipal")
                        {
                            Application.OpenForms[i].Close();
                            OpenChildForm(new form_ServicoPrincipal());
                            break;
                        }
                    }
                }
                else
                {
                    OpenChildForm2(ucPrincipal);
                    //OpenChildForm(new form_ServicoPrincipal());
                }
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
            panelControl1.Controls.Add(formFilho);
            panelControl1.Tag = formFilho;

            //this.Size = new Size(1500, 774);
            formFilho.BringToFront();

            //formPrincipal.Hide(); //Form principal é carregado diferente dos outros
            formFilho.Show();

            //lblAbaAtual.Text = formFilho.Text;
        }

        private void OpenChildForm2(XtraUserControl formFilho)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
            }

            currentChildForm2 = formFilho;

            //End
            //formFilho.TopLevel = false;
            //formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(formFilho);
            panelControl1.Tag = formFilho;

            //this.Size = new Size(1500, 774);
            formFilho.BringToFront();

            //formPrincipal.Hide(); //Form principal é carregado diferente dos outros
            formFilho.Show();

            //lblAbaAtual.Text = formFilho.Text;
        }

        private void btnInicio_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            if (ucPrincipal != null)
            {
                ucPrincipal.Dispose();
                ucPrincipal = new ucTelaPrincipal();
                ucPrincipal.Dock = DockStyle.Fill;
                panelControl1.Controls.Add(ucPrincipal);
                panelControl1.Tag = ucPrincipal;
                ucPrincipal.Hide();
            }
        }

        private void form_V2Standby_Shown(object sender, EventArgs e)
        {
            //MonitorCpu();
        }

        private void btnServicosPorMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
            try
            {
                logger.Info("Info de teste");
                logger.Debug("Debug de teste");
                logger.ConditionalDebug("ConditionalDebug de teste");
                logger.ConditionalTrace("ConditionalTrace de teste");
                logger.Error("Error de teste");
                logger.Fatal("Fatal de teste");
                logger.Log(LogLevel.Warn, "Log de teste");
            }
            catch (Exception exception)
            {
                logger.Trace(exception, "Log de teste");
                MessageBox.Show(exception.Message);

                //throw;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OverlayWindowOptions options = new OverlayWindowOptions(
                startupDelay: 0,
                backColor: Color.DarkOrange,

                // opacity: 50.0,
                fadeIn: true,
                fadeOut: true,
                imageSize: new Size(70, 70)
            );

            using (IOverlaySplashScreenHandle handle =
                   SplashScreenManager.ShowOverlayForm(this, customPainter: new CustomOverlayPainter()))
            {
                form_ComboboxConfig formCommand = new form_ComboboxConfig();
                formCommand.ShowDialog();
            }
        }

        private void form_V2Standby_FormClosing(object sender, FormClosingEventArgs e)
        {
            NLog.LogManager.Shutdown();

            ConsoleLog.isRunning = false;
            ConsoleLog.FecharConsoleLog();
            ConsoleLog.DesligarServidor();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<form_CadastroClientes>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name == "form_CadastroClientes")
                    {
                        Application.OpenForms[i].Close();
                        OpenChildForm(new form_CadastroClientes(new int[] { 255, 0, 103 }));
                        break;
                    }
                }
            }
            else
            {
                OpenChildForm(new form_CadastroClientes(new int[] { 255, 0, 103 }));
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<form_Lucros>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name == "form_LucrosV2")
                    {
                        Application.OpenForms[i].Close();

                        //OpenChildForm(new form_Lucros(new int[] { 255, 0, 103 }));
                        OpenChildForm(new form_LucrosV2());
                        break;
                    }
                }
            }
            else
            {
                OpenChildForm(new form_LucrosV2());

                //OpenChildForm(new form_Lucros(new int[] { 255, 0, 103 }));
            }
        }

        private void workerVerificarVersao_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                lblStatusUpdate.Caption = @"Verificando atualizações...";
                lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.DarkOrange;
                lblVersao.ItemAppearance.Normal.ForeColor = Color.DarkOrange;

                //lblVersion.Location  = new Point(174, 9);

                statusAtualizacao = verificarUpd.ChecarVersaoStandBy();
                if (statusAtualizacao == "Atualização Pendente!")
                {
                    lblStatusUpdate.Caption = @"Atualização Pendente!";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.Yellow;
                    lblVersao.ItemAppearance.Normal.ForeColor = Color.Yellow;

                    // lblVersion.Location  = new Point(183, 9);
                }
                else if (statusAtualizacao == "Sistema Atualizado!")
                {
                    lblStatusUpdate.Caption = @"Sistema Atualizado!";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.LawnGreen;
                    lblVersao.ItemAppearance.Normal.ForeColor = Color.LawnGreen;

                    //lblVersion.Location  = new Point(188, 9);
                }
                else if (statusAtualizacao == "Erro ao atualizar!")
                {
                    lblStatusUpdate.Caption = @"Erro ao atualizar";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.Crimson;
                    lblVersao.ItemAppearance.Normal.ForeColor = Color.Crimson;

                    //lblVersion.Location  = new Point(199, 9);
                }
                else
                {
                    lblStatusUpdate.Caption = @"Erro Desconhecido!";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.AntiqueWhite;
                    lblVersao.ItemAppearance.Normal.ForeColor = Color.AntiqueWhite;

                    //lblVersion.Location  = new Point(191, 9);
                }
            }
            catch
            {
            }
        }

        private void workerVerificarVersao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (statusAtualizacao == "Atualização Pendente!")
            {
                btnAtualizarSistema.Visibility = BarItemVisibility.Always;
            }
            else
            {
                btnAtualizarSistema.Visibility = BarItemVisibility.Never;
            }
        }

        private void btnAtualizarSistema_ItemClick(object sender, ItemClickEventArgs e)
        {
            verificarUpd.ForcarAtualizacao();
        }

        private void workerInicializarJuntoComForm_DoWork(object sender, DoWorkEventArgs e)
        {
            string pastaRaiz = bd.PASTA_RAIZ;
            string CAMINHO_TXT = bd.CAMINHO_TXT;

            if (!Directory.Exists(pastaRaiz) || !File.Exists(CAMINHO_TXT))
            {
                bd.CriarDiretorioEscreverConfigs();
            }

            criarPastaDasSenhas();
            lblIP.Caption = PegarIp();
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



        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<form_Concluidos>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name == "form_Concluidos")
                    {
                        Application.OpenForms[i].Close();
                        OpenChildForm(new form_Concluidos(new int[] { 255, 0, 103 }));
                        break;
                    }
                }
            }
            else
            {
                OpenChildForm(new form_Concluidos(new int[] { 255, 0, 103 }));
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ConsoleLog.EnviarMensagemInfo($"Rafa solteiro");
            ConsoleLog.EnviarMensagemErro($"Rafa comprometido");
        }
    }
}