using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using DevExpress.XtraEditors;
using Guna.UI.WinForms;

namespace PFC___StandBy_CSharp.Utils
{
    internal static class FormatarCampos
    {
        public static void FormatandoEmTempoRealParaTelefone(object sender, KeyPressEventArgs e)
        {
            TextBox CPF = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;

                if (CPF.Text.Length == 0)
                {
                    CPF.Text += "(";
                }
                else if (CPF.Text.Length == 3)
                {
                    CPF.Text += ") ";
                }
                //else if (CPF.Text.Length == 6)
                //{
                //    CPF.Text += " ";
                //}
                else if (CPF.Text.Length == 10)
                {
                    CPF.Text += "-";
                }

                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        public static void FormatandoEmTempoRealParaCpf(object sender, KeyPressEventArgs e)
        {
            TextBox CPF = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;

                if (CPF.Text.Length == 3 || CPF.Text.Length == 7)
                {
                    CPF.Text += ".";
                }
                else if (CPF.Text.Length == 11)
                {
                    CPF.Text += "-";
                }

                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        public static void FormatandoEmTempoRealParaCnpj(object sender, KeyPressEventArgs e)
        {
            TextBox CPF = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;

                if (CPF.Text.Length == 2 || CPF.Text.Length == 6)
                {
                    CPF.Text += ".";
                }
                else if (CPF.Text.Length == 10)
                {
                    CPF.Text += "/";
                }
                else if (CPF.Text.Length == 15)
                {
                    CPF.Text += "-";
                }

                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        public static void FormatarTodaStringParaCpf(object sender, TextBox _textBox)
        {
            Regex pattern = new Regex("[./-]");
            //string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
            TextBox CPF = sender as TextBox;

            string cpfTexto = pattern.Replace(_textBox.Text, "");
            char[] cpfCaracteres = cpfTexto.ToCharArray();
            _textBox.Text = "";
            foreach (char caractere in cpfCaracteres)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;
                _textBox.Text += caractere;
                if (CPF.Text.Length == 3 || CPF.Text.Length == 7)
                {
                    CPF.Text += ".";
                }
                else if (CPF.Text.Length == 11)
                {
                    CPF.Text += "-";
                }

                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        public static void FormatarTodaStringParaCnpj(object sender, TextBox _textBox)
        {
            Regex pattern = new Regex(@"[./-]");
            //string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
            TextBox CPF = sender as TextBox;

            string cpfTexto = pattern.Replace(_textBox.Text, "");
            char[] cpfCaracteres = cpfTexto.ToCharArray();
            _textBox.Text = "";
            foreach (char caractere in cpfCaracteres)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;
                _textBox.Text += caractere;
                if (CPF.Text.Length == 2 || CPF.Text.Length == 6)
                {
                    CPF.Text += ".";
                }
                else if (CPF.Text.Length == 10)
                {
                    CPF.Text += "/";
                }
                else if (CPF.Text.Length == 15)
                {
                    CPF.Text += "-";
                }

                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        public static void FormatarEmTempoRealData(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && char.IsDigit(e.KeyChar))
            {
                Regex pattern = new Regex("[./-]");
                //string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
                TextBox txtData = sender as TextBox;

                string dataSemCaracteresEspeciais = pattern.Replace(txtData.Text, "");
                char[] dataApenasNumeros = dataSemCaracteresEspeciais.ToCharArray();
                txtData.Text = "";
                foreach (char caractere in dataApenasNumeros)
                {
                    txtData.SelectionStart = txtData.Text.Length + 1;
                    txtData.Text += caractere;
                    if (txtData.Text.Length == 2 || txtData.Text.Length == 5)
                    {
                        txtData.Text += "/";
                    }

                    txtData.SelectionStart = txtData.Text.Length + 1;
                }
            }
            else if (e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
            }
        }

        public static void ApenasValorNumericoVirgulas(object sender, KeyPressEventArgs e)
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
                    MessageBox.Show(@"Apenas numeros e virgulas!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void ApenasValorNumericoVirgulasBunifu(object sender, KeyPressEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show(@"Apenas numeros e virgulas!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void ApenasValorNumerico(object sender, KeyPressEventArgs e)
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
                    MessageBox.Show(@"Apenas numeros!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void TirarMascara(GunaLineTextBox txt)
        {
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public static void FormatarMoeda(object sender, KeyEventArgs e)
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
            txt.Text = $"{Convert.ToDouble(valor):C}";
            txt.Select(txt.Text.Length, 0);
        }

        public static void FormatarMoedaBunifu(object sender, KeyEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
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
            txt.Text = $"{Convert.ToDouble(valor):C}";
            txt.Select(txt.Text.Length, 0);
        }

        public static void AplicarApenasNumeroVirgulaEMoeda(GunaLineTextBox txt)
        {
            //txt.Enter += TirarMascaraEnter;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumericoVirgulas;
            txt.KeyUp += FormatarMoeda;
        }

        public static void AplicarApenasNumeroVirgulaEMoeda(TextEdit txt)
        {
            //txt.Enter += TirarMascaraEnter;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumericoVirgulasBunifu;
            txt.KeyUp += FormatarMoedaBunifu;
        }

        public static void AplicarApenasNumerosSemVirgula(GunaLineTextBox txt)
        {
            //txt.Enter += TirarMascaraEnter;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
            //txt.KeyUp += FormatarMoeda;
        }
    }
}