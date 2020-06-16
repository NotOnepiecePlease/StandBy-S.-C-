using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    class PreencherTableOrdensServicos : conexao
    {
        MensagensErro mErro = new MensagensErro();
        MensagensSucesso mSucesso = new MensagensSucesso();
        public void Preencher(DataGridView tabelaServicos)
        {
            try
            {
                SqlConnection con = OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select sv_id, sv_cl_idcliente, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha, " +
                    "sv_valorservico, sv_valorpeca, sv_lucro, sv_servico from tb_servicos INNER JOIN tb_clientes on tb_servicos.sv_cl_idcliente = tb_clientes.cl_id WHERE sv_status = 1", con);
                //SqlDataAdapter adapter = new SqlDataAdapter("Select sv_data, sv_aparelho, sv_defeito, sv_senha, sv_situacao from tb_servicos", con);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                tabelaServicos.AutoGenerateColumns = false;
                tabelaServicos.AllowUserToAddRows = false;
                tabelaServicos.AllowUserToResizeColumns = true;
                tabelaServicos.AllowUserToDeleteRows = false;
                tabelaServicos.DataSource = datatable;
                tabelaServicos.Sort(tabelaServicos.Columns["idServico"], ListSortDirection.Descending);
                CloseConnection();
            }
            catch (Exception ex)
            {
                mErro.ErroPreencherTabelaServicos(ex);
            }
            
        }

        public void PreencherServicosPorNomeCliente(DataGridView tabelaServicos, string _nomeCliente)
        {
            try
            {
                //Abro a Conexao
                SqlConnection con = OpenConnection();

                //Defino a query de select
                string Query = "select sv_id, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha from tb_servicos " +
                    "inner join tb_clientes on tb_servicos.sv_cl_idcliente = tb_clientes.cl_id where cl_nome like @NomeCliente";

                //Crio um novo objeto pra armazenar a Query e a conexao.
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);

                //Defino os parametros
                adapter.SelectCommand.Parameters.AddWithValue("@NomeCliente", String.Format("%{0}%", _nomeCliente));

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                tabelaServicos.AutoGenerateColumns = false;
                tabelaServicos.AllowUserToAddRows = false;
                tabelaServicos.AllowUserToResizeColumns = true;
                tabelaServicos.AllowUserToDeleteRows = false;
                tabelaServicos.DataSource = datatable;
                tabelaServicos.Sort(tabelaServicos.Columns["idServico"], ListSortDirection.Descending);
                CloseConnection();


                //A Forma abaixo tambem funciona mas de uma forma diferente, entao vou deixar comentado
                //pra nivel de conhecimento mesmo.



                ////Abro a Conexao
                //SqlConnection con = OpenConnection();

                ////Defino a query de select
                //string Query = "select sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha from tb_servicos " +
                //    "inner join tb_clientes on tb_servicos.sv_cl_idcliente = tb_clientes.cl_id where cl_nome like @NomeCliente";

                ////Crio um novo objeto pra armazenar a Query e a conexao.
                //SqlCommand cmd = new SqlCommand(Query, con);

                ////Defino os parametros
                //cmd.Parameters.AddWithValue("@NomeCliente", String.Format("%{0}%", _nomeCliente));

                ////
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //DataTable datatable = new DataTable();

                //adapter.Fill(datatable);

                //tabelaServicos.AutoGenerateColumns = false;
                //tabelaServicos.AllowUserToAddRows = false;
                //tabelaServicos.AllowUserToResizeColumns = true;
                //tabelaServicos.AllowUserToDeleteRows = false;
                //tabelaServicos.DataSource = datatable;
                //CloseConnection();
            }
            catch (Exception ex)
            {
                mErro.ErroPreencherServicosCliente(ex);
            }
            
        }
    }
}
