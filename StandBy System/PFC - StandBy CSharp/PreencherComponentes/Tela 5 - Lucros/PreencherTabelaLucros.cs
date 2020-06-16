using Bunifu.DataViz.WinForms;
using Bunifu.Framework.UI;
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
    class PreencherTabelaLucros : conexao
    {
        private decimal totalServicos;
        private decimal totalPecas;
        private decimal totalLucros;

        public decimal getLucros()
        {
            return totalLucros;
        }
        public decimal getServicos()
        {
            return totalServicos;
        }
        public decimal getPecas()
        {
            return totalPecas;
        }

        public void Preencher(DataGridView tabelaLucros, DateTime data1, DateTime data2, Label lbllucro)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = OpenConnection())
            {
                string procedure = "BuscarLucroEntreDatas";

                SqlCommand cmd = new SqlCommand(procedure, con);

                cmd.Parameters.AddWithValue("@_Data1", data1);
                cmd.Parameters.AddWithValue("@_Data2", data2);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.Fill(datatable);
                DataView dataView = new DataView(datatable);
                //this.Grid.DataSource = dataView;
                tabelaLucros.DataSource = dataView;
                //tabelaLucros.Columns[4].Visible = false;

                totalLucros = 0.00m;
                totalServicos = 0.00m;
                totalPecas = 0.00m;
                //percorrer todas as linhas pra somar valores dos servicos
                foreach (DataGridViewRow row in tabelaLucros.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["sv_valorservico"].Value)))
                    {
                        totalServicos += Convert.ToDecimal(row.Cells[5].Value);
                    }
                }
                //percorrer todas as linhas pra somar valores das pecas
                foreach (DataGridViewRow row in tabelaLucros.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["sv_valorpeca"].Value)))
                    {
                        totalPecas += Convert.ToDecimal(row.Cells[6].Value);
                    }
                }
                //percorrer todas as linhas pra somar os lucros
                foreach (DataGridViewRow row in tabelaLucros.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["sv_lucro"].Value)))
                    {
                        totalLucros += Convert.ToDecimal(row.Cells[7].Value);
                        //MessageBox.Show(Lucros.ToString("0.00"));
                    }
                }
            }
        }
    }
}
