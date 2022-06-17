using Guna.UI.WinForms;
using PFC___StandBy_CSharp.SqlDbConnect;
using System.Data.SqlClient;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_4___Orcamentos
{
    internal class PreencherComboboxMarca : conexao
    {
        public void Preencher(GunaComboBox combobox)
        {
            using (SqlConnection conexao = OpenConnection())
            {
            }
        }
    }
}