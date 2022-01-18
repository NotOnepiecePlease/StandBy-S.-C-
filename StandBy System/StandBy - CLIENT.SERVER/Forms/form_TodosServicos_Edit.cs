using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_TodosServicos_Edit : Form
    {
        public form_TodosServicos_Edit()
        {
            InitializeComponent();
            
        }

        private void form_TodosServicos_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
