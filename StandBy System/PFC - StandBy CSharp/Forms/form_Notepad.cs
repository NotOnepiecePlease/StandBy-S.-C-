using PFC___StandBy_CSharp.Properties;
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
    public partial class form_Notepad : Form
    {
        public form_Notepad()
        {
            InitializeComponent();
            richTextBox1.BackColor = Settings.Default.notepad_CorFundo;
            richTextBox1.Font = Settings.Default.notepad_FonteStyle;
            richTextBox1.ForeColor = Settings.Default.notepad_FonteColor;
        }

        private void coresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cores = new ColorDialog();
            //cores.ShowDialog();
            if (cores.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cores.Color;
                Settings.Default.notepad_CorFundo = cores.Color;
                Settings.Default.Save();
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontes = new FontDialog();

            if (fontes.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontes.Font;
                Settings.Default.notepad_FonteStyle = fontes.Font;
                Settings.Default.Save();
                //richTextBox1.ForeColor = fontes.Color;
            }
        }

        private void fonteCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cores = new ColorDialog();
            //cores.ShowDialog();
            if (cores.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = cores.Color;
                Settings.Default.notepad_FonteColor = cores.Color;
                Settings.Default.Save();
            }
        }
    }
}
