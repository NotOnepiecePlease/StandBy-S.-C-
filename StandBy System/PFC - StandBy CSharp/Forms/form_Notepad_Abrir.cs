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
    public partial class form_Notepad_Abrir : Form
    {
        string diretorioSave;
        form_Notepad f_Notepad;
        public form_Notepad_Abrir(form_Notepad _notepadF)
        {
            InitializeComponent();
            f_Notepad = _notepadF;
            //f_Notepad.richTextBox1.BackColor = Settings.Default.notepad_CorFundo;
            //f_Notepad.richTextBox1.Font = Settings.Default.notepad_FonteStyle;
            //f_Notepad.richTextBox1.ForeColor = Settings.Default.notepad_FonteColor;
            diretorioSave = Settings.Default.diretorio_default_notepad;
            PreencherListBox(diretorioSave);
        }

        public void PreencherListBox(string diretorio)
        {
            var pasta = new DirectoryInfo(diretorio).Parent + @"\" + new DirectoryInfo(diretorio).Name;
            label1.Text = pasta.ToString();
            listBox1.Items.Clear();
            DirectoryInfo dir_files = new DirectoryInfo(diretorio);
            FileInfo[] files = dir_files.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            foreach (var fill in files)
            {
                listBox1.Items.Add(fill.Name);
            }
        }

        private void btnBuscarPasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;

            //label1.Text = folderBrowserDialog1.SelectedPath;
            Settings.Default.diretorio_default_notepad = folderBrowserDialog1.SelectedPath;
            diretorioSave = Settings.Default.diretorio_default_notepad;
            Settings.Default.Save();
            //MessageBox.Show(folderBrowserDialog1.SelectedPath.ToString());
            PreencherListBox(diretorioSave);
        }

        private void btnPastaPadrao_Click(object sender, EventArgs e)
        {
            PreencherListBox(@".\Anotacoes");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                f_Notepad.richTextBox1.Text = File.ReadAllText(diretorioSave + @"\" + listBox1.SelectedItem.ToString(), Encoding.UTF8);
                f_Notepad.Text = listBox1.SelectedItem.ToString();
                f_Notepad.setRichTextTamanho();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void form_Notepad_Abrir_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
            //MessageBox.Show("Rich Leng: " + f_Notepad.richTextBox1.Text.Length);
            //MessageBox.Show("Vari Leng: " + f_Notepad.getRichTextTamanho());
        }
    }
}
