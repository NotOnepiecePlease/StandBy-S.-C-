using PFC___StandBy_CSharp.Utils;
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
    public partial class form_DeveloperCommand : Form
    {
        public form_DeveloperCommand()
        {
            InitializeComponent();
        }

        private void btnExecutarComando_Click(object sender, EventArgs e)
        {
            if (cmbComando.Text.ToLower().Trim() == "cmb")
            {
                form_ComboboxConfig formCommand = new form_ComboboxConfig();
                formCommand.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Comando não reconhecido");
            }
        }

        private void form_DeveloperCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}