using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_5___Lucros
{
    class PreencherTabelaGastos : conexao
    {
        private decimal totalGastos;

        public decimal getGastos()
        {
            return totalGastos;
        }

        public void Preencher(DataGridView tabelaGastos, int _Temp)
        {
            //Esse metodo so vai trazer servicos ativos no mes
            DataTable datatable = new DataTable();
            using(SqlConnection conexao = OpenConnection())
            {

                string procedure = "GastosBuscar";

                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_Temp", _Temp);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.ExecuteNonQuery();

                adapter.Fill(datatable);

                tabelaGastos.DataSource = datatable;

                totalGastos = 0.00m;

                //foreach (DataGridViewRow row in tabelaGastos.Rows)
                //{
                //    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["gst_valor"].Value)))
                //    {
                //        totalGastos += Convert.ToDecimal(row.Cells[3].Value);
                //    }
                //}
            }
        }

        public void PreencherEntreDatas(DataGridView tabelaGastos, DateTime _date1, DateTime _date2, int _Temp)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection conexao = OpenConnection())
            {

                string procedure = "GastosBuscarEntreDatas";

                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_Temp", _Temp);
                cmd.Parameters.AddWithValue("@_Data1", _date1);
                cmd.Parameters.AddWithValue("@_Data2", _date2);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.ExecuteNonQuery();

                adapter.Fill(datatable);

                tabelaGastos.DataSource = datatable;

                totalGastos = 0.00m;

                foreach (DataGridViewRow row in tabelaGastos.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["gst_valor"].Value)))
                    {
                        totalGastos += Convert.ToDecimal(row.Cells[3].Value);
                    }
                }
            }
        }
    }
}
