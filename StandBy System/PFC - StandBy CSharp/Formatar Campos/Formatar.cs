using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Formatar_Campos
{
    class Formatar
    {
        public void ApenasValorNumericoVirgulas(object sender, KeyPressEventArgs e)
        {
            GunaLineTextBox txt = (GunaLineTextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Apenas numeros e virgulas!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            GunaLineTextBox txt = (GunaLineTextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    //e.Handled = (txt.Text.Contains(','));
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Apenas numeros!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void TirarMascaraEnter(object sender, EventArgs e)
        {
            GunaLineTextBox txt = (GunaLineTextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        
        public void TirarMascara(GunaLineTextBox txt)
        {
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public void RetornarMascara(object sender, EventArgs e)
        {
            GunaLineTextBox txt = (GunaLineTextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void FormatarMoeda(object sender, KeyEventArgs e)
        {
            GunaLineTextBox txt = (GunaLineTextBox)sender;
            string valor = txt.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txt.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txt.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txt.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt.Text.StartsWith("0,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt.Text.Contains("00,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt.Text;
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt.Select(txt.Text.Length, 0);
        }

        public void AplicarApenasNumeroVirgulaEMoeda(GunaLineTextBox txt)
        {
            //txt.Enter += TirarMascaraEnter;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumericoVirgulas;
            txt.KeyUp += FormatarMoeda;
        }

        public void AplicarApenasNumerosSemVirgula(GunaLineTextBox txt)
        {
            //txt.Enter += TirarMascaraEnter;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
            //txt.KeyUp += FormatarMoeda;
        }

        public void AplicarApenasNumerosVirgulaSemMoeda(GunaLineTextBox txt)
        {
            //txt.Enter += TirarMascaraEnter;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumericoVirgulas;
            //txt.KeyUp += FormatarMoeda;
        }
    }
}
