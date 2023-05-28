using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Microsoft.VisualBasic.Devices;
using DevExpress.XtraSplashScreen;
using Microsoft.Identity.Client;
using NLog;
using PFC___StandBy_CSharp.Utils;
using NLog.Fluent;
using LogLevel = NLog.LogLevel;
using PFC___StandBy_CSharp.ChecarUpdates;

namespace PFC___StandBy_CSharp.Forms.Testes
{
    public partial class form_V2Standby : DevExpress.XtraEditors.XtraForm
    {
        private Form currentChildForm;
        private NLog.Logger logger = LogManager.GetCurrentClassLogger();
        private Verificar verificarUpd = new Verificar();

        public form_V2Standby()
        {
            InitializeComponent();
            Constantes.IniciarOpcoesChecklistEntrada();
            menuSuperior.OptionsBar.DrawDragBorder = false;
            sourceServicosSemanais.Fill();
            sourceServicosMensais.Fill();
            lblVersion.Caption = "v" + verificarUpd.VERSAO_STANDBY;
            var thread = new Thread(MonitorCpu);
            thread.Start();
        }

        private void MonitorCpu()
        {
            try
            {
                var cpuCounter    = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                var computerInfo  = new ComputerInfo();
                var totalMemory   = computerInfo.TotalPhysicalMemory / (1024 * 1024);
                var memoryCounter = new PerformanceCounter("Memory", "Available MBytes");
                while (true)
                {
                    var cpu           = cpuCounter.NextValue();
                    var memory        = memoryCounter.NextValue();
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

        private void form_V2Standby_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
                var a     = 0;
                var b     = 1;
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
    }
}