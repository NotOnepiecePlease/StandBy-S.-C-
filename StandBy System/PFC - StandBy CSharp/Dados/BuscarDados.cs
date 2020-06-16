using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Dados
{
    class BuscarDados : conexao
    {
        MensagensErro me = new MensagensErro();
        public int BuscarIdCliente(string _nome)
        {
            int idCliente = 0;
            SqlDataReader reader;
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string Query = "Select cl_id from tb_clientes where cl_nome = @Nome";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = _nome;

                    reader = cmd.ExecuteReader();
                    reader.Read();
                    idCliente = reader.GetInt32(0);

                    reader.Close();
                    //con.Close();
                }

            }
            catch (Exception e)
            {
                me.ErroBuscarIdCliente(e);
            }
            return idCliente;
        }

        public void BuscarServicosDoCliente(string _nomeCliente)
        {
            using (SqlConnection con = OpenConnection())
            {
                string Query = "select sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha from tb_servicos inner join tb_clientes on tb_servicos.sv_cl_idcliente = tb_clientes.cl_id where cl_nome like '%@NomeCliente%'";
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = _nomeCliente;

                cmd.ExecuteNonQuery();
                //con.Close();
            }
        }

        public void BuscarServicosConcluidos(string _nomeCliente)
        {
            using (SqlConnection con = OpenConnection())
            {
                //@_nomeCliente
                SqlCommand cmd = new SqlCommand("SelecionarServicos_Done_NomeCliente", con);
                cmd.Parameters.AddWithValue("@_nomeCliente", SqlDbType.VarChar).Value = _nomeCliente;

                SqlDataReader dr;

                dr = cmd.ExecuteReader();

            }
        }
    }
}
