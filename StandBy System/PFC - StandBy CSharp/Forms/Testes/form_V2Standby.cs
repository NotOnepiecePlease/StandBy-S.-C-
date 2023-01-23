using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Context;
using Microsoft.EntityFrameworkCore;
using DevExpress.DataAccess.Sql;
using System.Data.Objects.SqlClient;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.Utils;
using DevExpress.XtraBars.Controls;

namespace PFC___StandBy_CSharp.Forms.Testes
{
    public partial class form_V2Standby : DevExpress.XtraEditors.XtraForm
    {
        public form_V2Standby()
        {
            InitializeComponent();
            menuSuperior.OptionsBar.DrawDragBorder = false;
            sourceServicosSemanais.Fill();
            sourceServicosMensais.Fill();

            //barManager1.ForceInitialize();
            //CustomBarControl barControl = menuSuperior.GetBarControl();
            //barControl.MouseDown += menuSuperior_MouseDown;
        }

        private void menuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void form_V2Standby_Load(object sender, EventArgs e)
        {
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
    }
}