using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;

namespace PFC___StandBy_CSharp.Utils
{
    internal static class ComboboxStatus
    {
        public static void MudarCor(BunifuDropdown combobox)
        {
            if (combobox.Text == @"APROVADO")
            {
                combobox.BackColor       = Color.Chartreuse;
                combobox.BackgroundColor = Color.Chartreuse;
            }
            else if (combobox.Text == @"AVALIAÇÃO")
            {
                combobox.BackColor       = Color.DarkOrange;
                combobox.BackgroundColor = Color.DarkOrange;
            }
            else if (combobox.Text == @"CONCLUÍDO")
            {
                combobox.BackColor       = Color.DarkGray;
                combobox.BackgroundColor = Color.DarkGray;
            }
        }
    }
}