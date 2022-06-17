using Bunifu.Framework.UI;
using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_4___Orcamentos
{
    internal class PreencherTableOrcamento : conexao
    {
        public void Preencher(BunifuCustomDataGrid tableOrcamento, string _marca, Label _lblSemDados)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection conexao = OpenConnection())
                {
                    string query = "select * from tb_orcamento where orc_aparelho = @marca";

                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@marca", _marca);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count <= 0)
                    {
                        _lblSemDados.Visible = true;
                    }
                    else
                    {
                        _lblSemDados.Visible = false;
                    }
                    tableOrcamento.DataSource = dataTable;
                    tableOrcamento.Sort(tableOrcamento.Columns["orc_id"], ListSortDirection.Descending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher a tabela.\n\n\nErro: " + ex, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}