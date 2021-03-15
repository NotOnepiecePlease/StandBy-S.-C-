using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Dados
{
    class VerificarExistencia : conexao
    {
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
    }
}
