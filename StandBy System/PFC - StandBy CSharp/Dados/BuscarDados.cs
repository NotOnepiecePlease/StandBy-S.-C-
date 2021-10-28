using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI.WinForms;
using System.Windows;

namespace PFC___StandBy_CSharp.Dados
{
    class BuscarDados : conexao
    {
        MensagensErro me = new MensagensErro();
        #region Buscar a ID do Cliente
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
        #endregion

        #region Buscar imagem do banco (Senha de padrao)
        public byte[] BuscarImagem(string _idServico)
        {
            byte[] bytes;
            using (SqlConnection con = OpenConnection())
            {
                string query = "select sv_senha_pattern from tb_servicos where sv_id = @idServico";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;

                cmd.Parameters.AddWithValue("@idServico", SqlDbType.Int).Value = Convert.ToInt32(_idServico);
                reader = cmd.ExecuteReader();

                reader.Read();
                try
                {
                    bytes = (byte[])reader[0];
                    return bytes;
                }
                catch (Exception)
                {
                    return new byte[] { 0 };
                }
            }
        }
        #endregion

        #region Buscar servicos do cliente
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
        #endregion

        #region Buscar servicos concluidos (pesquisa por nome)
        public void BuscarServicosConcluidosPorNome(string _nomeCliente)
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
        #endregion

        #region Buscar dias totais de garantia
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
        #endregion

        #region Buscar dias faltantes da garantia
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
        #endregion

        #region Buscar CPF do cliente
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
        #endregion

        #region Buscar Telefone do Cliente
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
        #endregion

        #region Buscar telefone secundario do cliente
        public string BuscarTelefoneRecadoCliente(int _idCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select cl_telefone_recado from tb_clientes where cl_id = @IdCliente";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                dr = cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
        }
        #endregion

        #region Buscar total de servicos concluidos
        public int BuscarTotalServicosConcluidos()
        {
            try
            {
                using(SqlConnection con = OpenConnection())
                {
                    string query = "SELECT COUNT(sv_id) FROM tb_servicos WHERE sv_status = 0 and sv_ativo = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                return 0;
            }
        }
        #endregion

        #region Buscar ID do ultimo servico adicionado
        public int BuscarIdUltimoServicoAdicionado()
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "select max(sv_id) from tb_servicos";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return 0;
            }
        }
        #endregion

        #region Buscar servico por ID
        public List<object> BuscarServicoPorID(int _idServico)
        {
            try
            {
                using(SqlConnection con = OpenConnection())
                {
                    string query = "select sv_id, sv_cl_idcliente, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha, " +
                    "sv_valorservico, sv_valorpeca, sv_lucro, sv_servico, sv_previsao_entrega, sv_existe_um_prazo, sv_acessorios, sv_cor_tempo " +
                    "FROM tb_servicos " +
                    "INNER JOIN tb_clientes ON tb_servicos.sv_cl_idcliente = tb_clientes.cl_id " +
                    "WHERE sv_id = @IdServico";

                    List<object> dados = new List<object>();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdServico", _idServico);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dados.Add(dr.GetValue(0));//id
                        dados.Add(dr.GetValue(1));//id cliente
                        dados.Add(dr.GetValue(2));//sv_data
                        dados.Add(dr.GetValue(3));//cl_nome
                        dados.Add(dr.GetValue(4));//sv_aparelho
                        dados.Add(dr.GetValue(5));//sv_defeito
                        dados.Add(dr.GetValue(6));//sv_situacao
                        dados.Add(dr.GetValue(7));//sv_senha
                        dados.Add(dr.GetValue(8));//sv_valorservico
                        dados.Add(dr.GetValue(9));//sv_valorpeca
                        dados.Add(dr.GetValue(10));//sv_lucro
                        dados.Add(dr.GetValue(11));//sv_servico
                        dados.Add(dr.GetValue(12));//sv_previsao_entrega
                        dados.Add(dr.GetValue(13));//sv_existe_um_prazo
                        dados.Add(dr.GetValue(14));//sv_acessorios
                        dados.Add(dr.GetValue(15));//sv_cor_tempo

                        return dados;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
        #endregion
    }
}
