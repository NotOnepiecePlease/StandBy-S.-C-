using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Bunifu.Framework.UI;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes
{
    class PreencherTableClientes : conexao
    {
        //form_CadastroClientes cadCliente = new form_CadastroClientes();
        public void Preencher(DataGridView tabelaClientes)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = OpenConnection())
            {
                string Query = "select cl_id, cl_nome, cl_cpf, cl_telefone, cl_telefone_recado from tb_clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);

                adapter.SelectCommand.ExecuteNonQuery();
                adapter.Fill(datatable);

                tabelaClientes.DataSource = datatable;
                tabelaClientes.AutoGenerateColumns = false;
                tabelaClientes.AllowUserToAddRows = false;
                tabelaClientes.AllowUserToResizeColumns = true;
                tabelaClientes.AllowUserToDeleteRows = false;
                tabelaClientes.Sort(tabelaClientes.Columns["cl_id"], ListSortDirection.Descending);
            }
        }

        public void PesquisarClienteNome(string _nomeCliente, BunifuCustomDataGrid tabelaClientes)
        {
            using (SqlConnection con = OpenConnection())
            {
                DataTable datatable = new DataTable();
                string query = "select cl_id, cl_nome, cl_cpf, cl_telefone, cl_telefone_recado from tb_clientes where cl_nome like @nomeCliente";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nomeCliente", String.Format("%{0}%", _nomeCliente));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.Fill(datatable);

                tabelaClientes.DataSource = datatable;
            }
        }
    }
}
