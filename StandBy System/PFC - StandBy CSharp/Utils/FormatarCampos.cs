using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Utils
{
    internal static class FormatarCampos
    {
        public static void FormatandoEmTempoRealParaCPF(object sender, KeyPressEventArgs e)
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

        public static void FormatandoEmTempoRealParaCNPJ(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != 8)
            {
                Regex pattern = new Regex("[./-]");
                //string cpfApenasDigitos = pattern.Replace(txtCPFCliente.Text, "");
                TextBox Data = sender as TextBox;

                string cpfTexto = pattern.Replace(Data.Text, "");
                char[] cpfCaracteres = cpfTexto.ToCharArray();
                Data.Text = "";
                foreach (char caractere in cpfCaracteres)
                {
                    Data.SelectionStart = Data.Text.Length + 1;
                    Data.Text += caractere;
                    if (Data.Text.Length == 2 || Data.Text.Length == 5)
                    {
                        Data.Text += "/";
                    }
                    Data.SelectionStart = Data.Text.Length + 1;
                }
            }
        }
    }
}