using Guna.UI.WinForms;
using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Graficos
{
    class GraficoTotalGanhoAnualmente : conexao
    {
        public void TotalGanho(GunaLabel label, int _AnoAtual)
        {
            SqlDataReader dr;
            using (SqlConnection con = OpenConnection())
            {
                string Query = "SELECT SUM(sv_lucro) as Mes FROM tb_servicos WHERE year(sv_data) = @AnoAtual";
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.Add("@AnoAtual", SqlDbType.VarChar).Value = _AnoAtual;

                dr = cmd.ExecuteReader();
                dr.Read();
                label.Text = "R$ "+Convert.ToString(dr.GetDecimal(0));
                //con.Close();
            }
        }
    }
}
