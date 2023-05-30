using System;
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
using Microsoft.Identity.Client;
using NLog;
using PFC___StandBy_CSharp.Utils;
using NLog.Fluent;
using LogLevel = NLog.LogLevel;
using PFC___StandBy_CSharp.ChecarUpdates;
using PFC___StandBy_CSharp.Dados;
using Microsoft.Win32;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;

namespace PFC___StandBy_CSharp.Forms.Testes
{
    public partial class form_V2Standby : DevExpress.XtraEditors.XtraForm
    {
        private readonly BackupDados bd = new BackupDados();
        private Form currentChildForm;
        private NLog.Logger logger = LogManager.GetCurrentClassLogger();
        private Verificar verificarUpd = new Verificar();
        private string statusAtualizacao = "";
        private const string PASTA_RAIZ = @"./PasswordPattern";

        public form_V2Standby()
        {
            InitializeComponent();
            Constantes.IniciarOpcoesChecklistEntrada();
            InicializarSkinStandbyDevexpress();
            menuSuperior.OptionsBar.DrawDragBorder = false;
            sourceServicosSemanais.Fill();
            sourceServicosMensais.Fill();
            lblVersao.Caption = "v" + verificarUpd.VERSAO_STANDBY;

            //Aqui sao todos os itens que inicializa junto com o form.
            workerInicializarJuntoComForm.RunWorkerAsync();

            //Aqui ele verifica a versao do sistema.
            workerVerificarVersao.RunWorkerAsync();

            var thread = new Thread(MonitorCpu);
            thread.Start();

            //InicializarMenuAreaTrabalho();
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
                    "D:\\@C Sharp\\TCC - Sistema StandBy - C#\\GIT\\StandBy-S.-C-\\StandBy-S.-C-\\StandBy System\\PFC - StandBy CSharp\\bin\\Debug\\StandBy System.exe";

                // Nome e descrição da opção no menu de contexto
                string optionName = "StandBy System";
                string optionDescription = "StandBy System";

                // Caminho para o ícone personalizado (arquivo .ico)
                string iconPath =
                    "D:\\@C Sharp\\TCC - Sistema StandBy - C#\\GIT\\StandBy-S.-C-\\StandBy-S.-C-\\StandBy System\\PFC - StandBy CSharp\\icone.ico";

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
            catch (Exception e)
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
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
                OpenChildForm(new form_ServicoPrincipal());
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
            formFilho.TopLevel        = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock            = DockStyle.Fill;
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
                var a = 0;
                var b = 1;
                var teste = b / a;
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
                    if (Application.OpenForms[i].Name == "form_Lucros")
                    {
                        Application.OpenForms[i].Close();
                        OpenChildForm(new form_Lucros(new int[] { 255, 0, 103 }));
                        break;
                    }
                }
            }
            else
            {
                OpenChildForm(new form_Lucros(new int[] { 255, 0, 103 }));
            }
        }

        private void workerVerificarVersao_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                lblStatusUpdate.Caption                         = @"Verificando atualizações...";
                lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.DarkOrange;
                lblVersao.ItemAppearance.Normal.ForeColor       = Color.DarkOrange;

                //lblVersion.Location  = new Point(174, 9);

                statusAtualizacao = verificarUpd.ChecarVersaoStandBy();
                if (statusAtualizacao == "Atualização Pendente!")
                {
                    lblStatusUpdate.Caption                         = @"Atualização Pendente!";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.Yellow;
                    lblVersao.ItemAppearance.Normal.ForeColor       = Color.Yellow;

                    // lblVersion.Location  = new Point(183, 9);
                }
                else if (statusAtualizacao == "Sistema Atualizado!")
                {
                    lblStatusUpdate.Caption                         = @"Sistema Atualizado!";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.LawnGreen;
                    lblVersao.ItemAppearance.Normal.ForeColor       = Color.LawnGreen;

                    //lblVersion.Location  = new Point(188, 9);
                }
                else if (statusAtualizacao == "Erro ao atualizar!")
                {
                    lblStatusUpdate.Caption                         = @"Erro ao atualizar";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.Crimson;
                    lblVersao.ItemAppearance.Normal.ForeColor       = Color.Crimson;

                    //lblVersion.Location  = new Point(199, 9);
                }
                else
                {
                    lblStatusUpdate.Caption                         = @"Erro Desconhecido!";
                    lblStatusUpdate.ItemAppearance.Normal.ForeColor = Color.AntiqueWhite;
                    lblVersao.ItemAppearance.Normal.ForeColor       = Color.AntiqueWhite;

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
            bd.CriarDiretorioEscreverConfigs();
            criarPastaDasSenhas();
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
    }
}