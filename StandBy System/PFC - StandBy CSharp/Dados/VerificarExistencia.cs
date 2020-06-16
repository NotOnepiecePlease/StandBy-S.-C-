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

                if(dr.HasRows == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
