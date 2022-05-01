using StandBy___CLIENT.SERVER.MsgBox;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PFC___StandBy_CSharp.SqlDbConnect;

namespace StandBy___CLIENT.SERVER.PreencherComponentes
{
    internal class PreencherTableConcluidos : conexao
    {
        public void Preencher(DataGridView table_ServicosConcluidos, int _numeroPagina, int _dadosPorPagina)
        {
            using (SqlConnection con = OpenConnection())
            {
                //0 Concluido | 1 Ta em servico
                SqlCommand cmd = new SqlCommand("SelecionarServicos_Done", con);

                cmd.Parameters.AddWithValue("@PageNumber", _numeroPagina);
                cmd.Parameters.AddWithValue("@RowsOfPage", _dadosPorPagina);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //dt.Rows
                table_ServicosConcluidos.DataSource = dt;
                table_ServicosConcluidos.AutoGenerateColumns = false;
                table_ServicosConcluidos.AllowUserToAddRows = false;
                table_ServicosConcluidos.AllowUserToResizeColumns = true;
                table_ServicosConcluidos.AllowUserToDeleteRows = false;
                //table_ServicosConcluidos.Sort(table_ServicosConcluidos.Columns["DataConclusao"], ListSortDirection.Descending);

                //foreach (DataGridViewRow row in table_ServicosConcluidos.Rows)
                //{
                //    if (Convert.ToInt32(row.Cells[12].Value) == 0)
                //    {
                //        // Se for negativo, fica vermelho
                //        row.Cells[12].Value = "DONE";
                //    }
                //}
            }
        }

        public void PreencherPorNomeCliente(DataGridView table_ServicosConcluidos, string _nomeCliente)
        {
            using (SqlConnection con = OpenConnection())
            {
                //0 Concluido | 1 Ta em servico
                SqlCommand cmd = new SqlCommand("SelecionarServicos_Done_Table", con);
                cmd.Parameters.AddWithValue("@_nomeCliente", _nomeCliente);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //dt.Rows
                table_ServicosConcluidos.DataSource = dt;
                table_ServicosConcluidos.AutoGenerateColumns = false;
                table_ServicosConcluidos.AllowUserToAddRows = false;
                table_ServicosConcluidos.AllowUserToResizeColumns = true;
                table_ServicosConcluidos.AllowUserToDeleteRows = false;

                //foreach (DataGridViewRow row in table_ServicosConcluidos.Rows)
                //{
                //    if (Convert.ToInt32(row.Cells[12].Value) == 0)
                //    {
                //        // Se for negativo, fica vermelho
                //        row.Cells[12].Value = "DONE";
                //    }
                //}
            }
        }
    }
}