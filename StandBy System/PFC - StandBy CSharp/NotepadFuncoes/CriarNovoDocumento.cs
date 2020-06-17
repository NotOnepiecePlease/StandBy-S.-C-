using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.NotepadFuncoes
{
    class CriarNovoDocumento
    {
        public void Novo(RichTextBox richText)
        {
            if (richText.Text.Equals("") || string.IsNullOrWhiteSpace(richText.Text))
            {
                richText.Clear();
                richText.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente criar um novo documento?\nOs dados serão apagados!",
                    "ALERTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dialogResult == DialogResult.Yes)
                {
                    richText.Clear();
                    richText.Focus();
                }
            }
        }
    }
}
