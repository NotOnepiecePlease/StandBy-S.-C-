using PFC___StandBy_CSharp.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.NotepadFuncoes
{
    class SalvarDocumento
    {
        public void Salvar(SaveFileDialog saveFileDialog, RichTextBox richText, form_Notepad f_note)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        File.Delete(saveFileDialog.FileName);
                    }
                    FileStream arquivo = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    using (StreamWriter streamWriter = new StreamWriter(arquivo))
                    {
                        streamWriter.Flush();
                        streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                        streamWriter.Write(richText.Text);
                        streamWriter.Flush();
                        streamWriter.Close();
                        
                        var nomeArquivo = new DirectoryInfo(saveFileDialog.FileName).Name;
                        f_note.Text = nomeArquivo;

                        MessageBox.Show("O Arquivo foi salvo em: " + saveFileDialog.FileName, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar o arquivo: " + e, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
