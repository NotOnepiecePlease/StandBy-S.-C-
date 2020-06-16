using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.Forms;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Dados
{
    class AlterarDados : conexao
    {
        MensagensErro mErro = new MensagensErro();
        MensagensSucesso mSucesso = new MensagensSucesso();
        public void AlterarServico(int _idServico, DateTime _data, string _aparelho, string _defeito, string _senha,
            string _situacao, float _valorServico, float _valorPeca, float _lucro, string _servico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    //string query = "update tb_servicos set sv_data = @Data, sv_aparelho = @Aparelho, sv_defeito = @Defeito, " +
                    //                    "sv_senha = @Senha, sv_situacao = @Situacao, sv_valorservico = @ValorServico, sv_valorpeca = @ValorPeca," +
                    //                    "sv_lucro = @Lucro, sv_servico = @Servico where sv_id = @IdServico";

                    SqlCommand cmd = new SqlCommand("AlterarServicos", con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = _data;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.NVarChar).Value = _aparelho;
                    cmd.Parameters.Add("@Defeito", SqlDbType.NVarChar).Value = _defeito;
                    cmd.Parameters.Add("@Senha", SqlDbType.NVarChar).Value = _senha;
                    cmd.Parameters.Add("@Situacao", SqlDbType.NVarChar).Value = _situacao;
                    cmd.Parameters.Add("@ValorServico", SqlDbType.Float).Value = _valorServico;
                    cmd.Parameters.Add("@ValorPeca", SqlDbType.Float).Value = _valorPeca;
                    cmd.Parameters.Add("@Lucro", SqlDbType.Float).Value = _lucro;
                    cmd.Parameters.Add("@Servico", SqlDbType.NVarChar).Value = _servico;
                    cmd.Parameters.Add("@IdServico", SqlDbType.Int).Value = _idServico;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    //MessageBox.Show("SUCESSO");
                    //formServ.refreshTable();
                    mSucesso.AlterarServicoSucesso();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
                mErro.ErroAlterarServico(ex);
            }
        } //Procedure

        public void AlterarClientes(int _idcliente, string _nome, string _telefone, string _cpf)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand("AlterarClientes", con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@_nome", SqlDbType.VarChar).Value = _nome;
                    cmd.Parameters.AddWithValue("@_telefone", SqlDbType.VarChar).Value = _telefone;
                    cmd.Parameters.AddWithValue("@_cpf", SqlDbType.VarChar).Value = _cpf;
                    cmd.Parameters.AddWithValue("@_idcliente", SqlDbType.VarChar).Value = _idcliente;

                    cmd.ExecuteNonQuery();

                    mSucesso.AlterarClienteSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAlterarCliente(ex);
                
            }
        }

        public void ConcluirServicos(int _idServico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string procedure = "Servico_Concluir";

                    SqlCommand cmd = new SqlCommand(procedure, con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv_id", _idServico);
                    cmd.ExecuteNonQuery();

                    mSucesso.ConcluirServicoSucesso();
                }
            }
            catch (Exception ex)
            {

                mErro.ErroAoConcluirServico(ex);
            }
        }

        public void CancelarConclusaoServicos(int _idServico)
        {
            try
            {
                using(SqlConnection con = OpenConnection())
                {
                    string procedure = "Servico_Cancelar_Conclusao";
                    SqlCommand cmd = new SqlCommand(procedure, con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv_id", _idServico);

                    cmd.ExecuteNonQuery();

                    mSucesso.CancelarConclusaoSucesso();
                }
            }
            catch (Exception ex)
            {

                mErro.ErroAoCancelarConclusao(ex);
            }
        }

        public void AlterarGastos(int _idGasto, int _realORtemp)
        {
            //Alterar para gasto fixo ou temporario
            using(SqlConnection conexao = OpenConnection())
            {
                string procedure = "GastosAlterarRealOrTemp";
                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_RealOrTemp", _realORtemp);
                cmd.Parameters.AddWithValue("@_ID", _idGasto);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }

        public void AtualizarGastos(DateTime _data, string _produto, decimal _valor, int _id)
        {
            //Atualizar dados dos gastos, como data ou nome do produto.
            using (SqlConnection conexao = OpenConnection())
            {
                string procedure = "GastosAlterar";
                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_Data", _data);
                cmd.Parameters.AddWithValue("@_Produto", _produto);
                cmd.Parameters.AddWithValue("@_Valor", _valor);
                cmd.Parameters.AddWithValue("@_ID", _id);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
