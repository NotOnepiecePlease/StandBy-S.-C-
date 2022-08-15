using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// ReSharper disable UseStringInterpolation

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_5___Lucros
{
    internal class PreencherTabelaGastos : conexao
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
            using (SqlConnection conexao = OpenConnection())
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

        public void BuscarGastosPorNome(DataGridView tabelaGastos, string _Gasto)
        {
            using (SqlConnection con = OpenConnection())
            {
                DataTable datatable = new DataTable();
                string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                        "from tb_gastos " +
                        "where gst_temporario = 0 " +
                        "and gst_produto like @_Gasto " +
                        "order by gst_data desc";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@_Gasto", string.Format("%{0}%", _Gasto));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.Fill(datatable);

                tabelaGastos.DataSource = datatable;
            }

            //DataTable datatable = new DataTable();
            //using (SqlConnection conexao = OpenConnection())
            //{
            //    //-- Essa era a query que eu usava antes mas a busca estava buscando apenas por mes
            //    //-- ignorando o ano
            //    string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
            //        "from tb_gastos " +
            //        "where gst_temporario = 0 " +
            //        "and gst_produto like '%@_Gasto%' " +
            //        "order by gst_id desc";

            //    //SqlCommand cmd = new SqlCommand(procedure, conexao);
            //    SqlCommand cmd = new SqlCommand(query, conexao);
            //    cmd.Parameters.AddWithValue("@_Gasto", _Gasto);

            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    adapter.SelectCommand.ExecuteNonQuery();

            //    adapter.Fill(datatable);

            //    tabelaGastos.DataSource = datatable;

            //    totalGastos = 0.00m;

            //    foreach (DataGridViewRow row in tabelaGastos.Rows)
            //    {
            //        if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["gst_valor"].Value)))
            //        {
            //            totalGastos += Convert.ToDecimal(row.Cells[3].Value);
            //        }
            //    }
            //}
        }

        public void PreencherGastosEntreDatas(DataGridView tabelaGastos, DateTime _date1, DateTime _date2, int _Temp)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection conexao = OpenConnection())
            {
                string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                    "from tb_gastos where gst_temporario = @_Temp " +
                    "and gst_data BETWEEN @_Date1 and @_Date2 " +
                    "order by gst_data desc";
                //string procedure = "GastosBuscarEntreDatas";
                //string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                //    "from tb_gastos " +
                //    "where gst_temporario = @_Temp and month(gst_data) = MONTH(GETDATE()) and year(gst_data) = YEAR(GETDATE()) " +
                //    "order by gst_id desc";

                //-- Essa era a query que eu usava antes mas a busca estava buscando apenas por mes
                //-- ignorando o ano

                //string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                //    "from tb_gastos " +
                //    "where gst_temporario = @_Temp and month(gst_data) = MONTH(GETDATE()) " +
                //    "order by gst_id desc";

                //SqlCommand cmd = new SqlCommand(procedure, conexao);
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@_Temp", _Temp);
                cmd.Parameters.AddWithValue("@_Date1", _date1);
                cmd.Parameters.AddWithValue("@_Date2", _date2);

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

        public void PreencherGastosMesAtual(DataGridView tabelaGastos, DateTime _date1, DateTime _date2, int _Temp)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection conexao = OpenConnection())
            {
                string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                        "from tb_gastos " +
                        "where gst_temporario = 0 " +
                        "and month(gst_data) = MONTH(GETDATE()) " +
                        "and year(gst_data) = YEAR(GETDATE()) " +
                        "order by gst_data desc";
                //string procedure = "GastosBuscarEntreDatas";
                //string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                //    "from tb_gastos " +
                //    "where gst_temporario = @_Temp and month(gst_data) = MONTH(GETDATE()) and year(gst_data) = YEAR(GETDATE()) " +
                //    "order by gst_id desc";

                //-- Essa era a query que eu usava antes mas a busca estava buscando apenas por mes
                //-- ignorando o ano

                //string query = "select gst_id, gst_data, gst_produto, gst_valor, gst_temporario " +
                //    "from tb_gastos " +
                //    "where gst_temporario = @_Temp and month(gst_data) = MONTH(GETDATE()) " +
                //    "order by gst_id desc";

                //SqlCommand cmd = new SqlCommand(procedure, conexao);
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@_Temp", _Temp);
                cmd.Parameters.AddWithValue("@_Date1", _date1);
                cmd.Parameters.AddWithValue("@_Date2", _date2);

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

        public void PreencherGastosTotais(DataGridView tabelaGastos, DateTime _date1, DateTime _date2, int _Temp)
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