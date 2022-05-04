using System;
using System.Data.SqlClient;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System.Data;
using Bunifu.Framework.UI;

namespace PFC___StandBy_CSharp.Dados
{
    internal class DeletarDados : conexao
    {
        private MensagensErro mErro = new MensagensErro();
        private MensagensSucesso mSucesso = new MensagensSucesso();
        private VerificarExistencia ve = new VerificarExistencia();

        public void DeletarServico(int _idServico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "delete from tb_servicos where sv_id = @IdServico";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@IdServico", SqlDbType.Int).Value = _idServico;

                    cmd.ExecuteNonQuery();
                    //con.Close();
                    mSucesso.DeletarServicoSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroDeletarServico(ex);
            }
        }

        public void DeletarCliente(int _idcliente)
        {
            bool existeServico = ve.VerificarExistenciaServicoCliente(_idcliente);

            if (existeServico == false)
            {
                try
                {
                    using (SqlConnection con = OpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("DeletarCliente", con);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", SqlDbType.Int).Value = _idcliente;
                        cmd.ExecuteNonQuery();
                        mSucesso.DeletarClienteSucesso();
                        //MessageBox.Show("DELETADO");
                    }
                }
                catch (Exception ex)
                {
                    mErro.ErroDeletarCliente(ex);
                }
            }
            else
            {
                mErro.ErroClientePossuiServicos();
            }
        }

        public void DeletarGastos(int _id, BunifuCustomDataGrid tabelaGastos)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                string procedure = "GastosDeletar";

                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_ID", _id);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                tabelaGastos.Refresh();
                tabelaGastos.Update();
            }
        }

        public void DeletarGarantia(int _idServico)
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string procedure = "GarantiaDeletar";

                    SqlCommand cmd = new SqlCommand(procedure, conexao);
                    cmd.Parameters.AddWithValue("@_fkServico", _idServico);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoDeletarGarantia(ex);
            }
        }
    }
}