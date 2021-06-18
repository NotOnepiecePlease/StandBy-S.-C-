using StandBy___CLIENT.SERVER.SqlDbConnect;
using StandBy___CLIENT.SERVER.MsgBox;
using System;
using System.Data;
using System.Data.SqlClient;
using Guna.UI.WinForms;

namespace StandBy___CLIENT.SERVER.Dados
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
                cmd.Parameters.AddWithValue("@_nomeCliente", _nomeCliente);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }

        public void BuscarDiasGarantia(GunaLabel _Emissao, GunaLabel _DataFinal, GunaLabel _DiasRestantes, int _idServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string procedure = "GarantiaQuantosDias";

                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_fkServico", _idServico);
                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                dr.Read();

                _Emissao.Text = dr.GetDateTime(0).ToShortDateString();
                _DataFinal.Text = dr.GetDateTime(1).ToShortDateString();
                _DiasRestantes.Text = "Garantia: " + dr.GetInt32(2).ToString() + " Dias";

                dr.Close();
            }
        }

        public void BuscarDiasFaltantesGarantia(GunaLabel _LabelDiasFaltantes, GunaLabel _DataFinal, GunaLabel _DiasRestantes, int _idServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select gar_data_inicial, gar_data_final, datediff(DD, GETDATE(), gar_data_final) as diferenca from tb_garantias where fk_servico_id = @_fkServico";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@_fkServico", _idServico);
                cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();

                dr.Read();

                _LabelDiasFaltantes.Text = dr.GetDateTime(0).ToShortDateString();
                _DataFinal.Text = dr.GetDateTime(1).ToShortDateString();
                if (dr.GetInt32(2) < 0)
                {
                    _DiasRestantes.Text = "Faltam: 0 Dias";
                }
                else
                {
                    _DiasRestantes.Text = "Faltam: " + dr.GetInt32(2).ToString() + " Dias";
                }

                dr.Close();
            }
        }

        public string BuscarCPFCliente(int _idCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select cl_cpf from tb_clientes where cl_id = @IdCliente";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                dr = cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
        }

        public string BuscarTelefoneCliente(int _idCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select cl_telefone from tb_clientes where cl_id = @IdCliente";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                dr = cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
        }
    }
}
