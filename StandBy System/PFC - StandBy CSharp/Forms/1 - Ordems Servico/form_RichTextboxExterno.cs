using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms._1___Ordems_Servico
{
    public partial class form_RichTextboxExterno : Form
    {
        private RichTextBox richTex;

        public form_RichTextboxExterno(ref RichTextBox _richText)
        {
            InitializeComponent();
            richTex = _richText;
            txtRichtextExterna.Text = _richText.Text;
        }

        private void form_RichTextboxExterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                richTex.Text = txtRichtextExterna.Text;
                this.Close();
            }
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            richTex.Text = txtRichtextExterna.Text;
            this.Close();
        }
    }
}