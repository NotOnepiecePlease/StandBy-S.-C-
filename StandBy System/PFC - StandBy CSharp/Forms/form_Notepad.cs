using PFC___StandBy_CSharp.NotepadFuncoes;
using PFC___StandBy_CSharp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_Notepad : Form
    {
        int richTextFoiAlterado;
        int[] corGeral = { 0, 0, 0 };
        CriarNovoDocumento newNote = new CriarNovoDocumento();
        SalvarDocumento saveNote = new SalvarDocumento();
        public form_Notepad(int[] _corRgb)
        {
            InitializeComponent();
            corGeral = _corRgb;
            richTextBox1.BackColor = Settings.Default.notepad_CorFundo;
            richTextBox1.Font = Settings.Default.notepad_FonteStyle;
            richTextBox1.ForeColor = Settings.Default.notepad_FonteColor;
        }

        public void setRichTextTamanho()
        {
            richTextFoiAlterado = richTextBox1.Text.Length;
        }
        
        public int getRichTextTamanho()
        {
            return richTextFoiAlterado;
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

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Notepad_Abrir f_notepad = new form_Notepad_Abrir(this, corGeral);
            f_notepad.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newNote.Novo(richTextBox1);
            this.Text = "Novo Arquivo (Nao salvo)*";
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveNote.Salvar(saveFileDialog1, richTextBox1, this);
        }

        private bool RichTextContemTexto()
        {
            if (richTextBox1.Text == String.Empty || string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                //true = pode fechar o form
                return false;
            }
            else if (richTextBox1.Text.Length != richTextFoiAlterado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void form_Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RichTextContemTexto() == false)
            {
                //this.Close();
            }
            else if(RichTextContemTexto() == true)
            {
                DialogResult dialogResult = MessageBox.Show(@"Deseja salvar suas anotações antes de sair?", "SAIR",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


                if (dialogResult == DialogResult.Yes)
                {
                    saveNote.Salvar(saveFileDialog1, richTextBox1, this);
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
