using Guna.UI.WinForms;
using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_4___Orcamentos
{
    class PreencherComboboxMarca : conexao
    {
        public void Preencher(GunaComboBox combobox)
        {

            using(SqlConnection conexao = OpenConnection())
            {

            }
        }
    }
}
