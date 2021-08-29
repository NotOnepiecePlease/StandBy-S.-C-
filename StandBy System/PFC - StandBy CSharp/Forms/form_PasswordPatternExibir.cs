using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_PasswordPatternExibir : Form
    {
        public form_PasswordPatternExibir()
        {
            InitializeComponent();
        }

        private void form_PasswordPatternExibir_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
