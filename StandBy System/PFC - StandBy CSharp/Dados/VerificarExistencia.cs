using PFC___StandBy_CSharp.SqlDbConnect;
using System.Data.SqlClient;
using System.Data;

namespace PFC___StandBy_CSharp.Dados
{
    internal class VerificarExistencia : conexao
    {
        #region Verificar existencia de servico do cliente

        public bool VerificarExistenciaServicoCliente(int _idcliente)
        {
            using (SqlConnection con = OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("VerificarServicosCliente", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Value = _idcliente;

                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        #endregion Verificar existencia de servico do cliente

        #region Verificar existencia da garantia

        public bool VerificarExistenciaGarantia(int _fkServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select * from tb_garantias where fk_servico_id = @fkServicoID";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@fkServicoID", _fkServico);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                }
                {
                    return false;
                }
            }
        }

        #endregion Verificar existencia da garantia

        #region Verificar duplicidade do CPF

        public bool VerificarExistenciaCPF(string _cpfCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select * from tb_clientes where cl_cpf = @_cpf";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@_cpf", _cpfCliente);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion Verificar duplicidade do CPF

        #region Verificar existencia da Ordem de Servico

        public bool VerificarExistenciaOrdemServico(int _ordemServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "SELECT sv_id " +
                               "FROM tb_servicos " +
                               "WHERE sv_ordem_serv = @idOrdemServico";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@idOrdemServico", _ordemServico);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                {
                    return false;
                }
            }
        }

        #endregion Verificar existencia da Ordem de Servico

        //V2

        #region Verificar existencia da condicao fisica e do checklist

        public bool VerificarExistenciaCondFisicasChecklist(int _fkServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select ch_id, ch_sv_idservico " +
                               "from tb_checklist as chk " +
                               "inner join tb_condicoes_fisicas as cond " +
                               "on chk.ch_sv_idservico = cond.cf_sv_idservico " +
                               "where ch_sv_idservico = @idServico " +
                               "and ch_tipo = 'ENTRADA'";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@idServico", _fkServico);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                }
                {
                    return false;
                }
            }
        }

        #endregion Verificar existencia da condicao fisica e do checklist
    }
}