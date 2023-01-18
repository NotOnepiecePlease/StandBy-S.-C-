using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class SplashScreen1 : SplashScreen
    {
        form_StandBy form;

        public SplashScreen1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
            form = new form_StandBy();
            form.WindowState = FormWindowState.Minimized;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Run(form);


            this.Hide();
        }
    }
}