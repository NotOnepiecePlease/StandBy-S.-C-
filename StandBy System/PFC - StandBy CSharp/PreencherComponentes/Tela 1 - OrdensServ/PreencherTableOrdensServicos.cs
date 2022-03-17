using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    public class PreencherTableOrdensServicos : conexao
    {
        private MensagensErro mErro = new MensagensErro();
        private MensagensSucesso mSucesso = new MensagensSucesso();
        private AlterarDados ad = new AlterarDados();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public void Preencher(DataGridView _tabelaServicos)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    //Query antiga:
                    //"select sv_id, sv_cl_idcliente, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha, " +
                    //"sv_valorservico, sv_valorpeca, sv_lucro, sv_servico, sv_previsao_entrega, sv_existe_um_prazo, sv_acessorios, sv_cor_tempo " +
                    //"FROM tb_servicos " +
                    //"INNER JOIN tb_clientes ON tb_servicos.sv_cl_idcliente = tb_clientes.cl_id " +
                    //"WHERE sv_status = 1 and sv_ativo = 1 order by sv_id desc"

                    SqlDataAdapter adapter = new SqlDataAdapter("select sv_id, sv_cl_idcliente, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha, " +
                    "sv_valorservico, sv_valorpeca, sv_lucro, sv_servico, sv_previsao_entrega, sv_existe_um_prazo, sv_acessorios, sv_cor_tempo " +
                    "FROM tb_servicos " +
                    "INNER JOIN tb_clientes ON tb_servicos.sv_cl_idcliente = tb_clientes.cl_id " +
                    "WHERE sv_status = 1 and sv_ativo = 1 order by sv_cor_tempo asc, sv_data desc, sv_id desc", con);

                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);

                    foreach (DataRow linha in datatable.Rows)
                    {
                        if (linha[12] != DBNull.Value)
                        {
                            //linha[0] = sv_id
                            //linha[12] = sv_previsao_entrega
                            ad.atualizarColunaTempoCores(Convert.ToInt32(linha[0].ToString()), Convert.ToDateTime(linha[12]));
                        }
                    }
                    //Sendmessage é um macete bem de corno pra melhorar performance da lista.
                    //SendMessage(_tabelaServicos.Handle, WM_SETREDRAW, false, 0); //Estava dando erro ao trocar de form, portanto foi removido.
                    _tabelaServicos.AutoGenerateColumns = false;
                    _tabelaServicos.AllowUserToAddRows = false;
                    _tabelaServicos.AllowUserToResizeColumns = true;
                    _tabelaServicos.AllowUserToDeleteRows = false;
                    _tabelaServicos.DataSource = datatable;
                    //SendMessage(_tabelaServicos.Handle, WM_SETREDRAW, true, 0); //Estava dando erro ao trocar de form, portanto foi removido.
                    _tabelaServicos.Refresh();
                    //tabelaServicos.Sort(tabelaServicos.Columns["idServico"], ListSortDirection.Descending);
                    _tabelaServicos.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroPreencherTabelaServicos(ex);
            }
        }

        public void PreencherServicosPorNomeCliente(DataGridView _tabelaServicos, string _nomeCliente)
        {
            try
            {
                //Abro a Conexao
                using (SqlConnection con = OpenConnection())
                {
                    //Defino a query de select
                    string Query =
                        "SELECT sv_id, sv_cl_idcliente, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha, " +
                        "sv_valorservico, sv_valorpeca, sv_lucro, sv_servico, sv_previsao_entrega, sv_existe_um_prazo from tb_servicos " +
                        "INNER JOIN tb_clientes " +
                        "ON tb_servicos.sv_cl_idcliente = tb_clientes.cl_id " +
                        "WHERE cl_nome like @NomeCliente " +
                        "AND sv_status = 1 and sv_ativo = 1 order by sv_id desc";

                    //Crio um novo objeto pra armazenar a Query e a conexao.
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, con);

                    //Defino os parametros
                    adapter.SelectCommand.Parameters.AddWithValue("@NomeCliente", String.Format("%{0}%", _nomeCliente));

                    DataTable datatable = new DataTable();

                    adapter.Fill(datatable);

                    _tabelaServicos.AutoGenerateColumns = false;
                    _tabelaServicos.AllowUserToAddRows = false;
                    _tabelaServicos.AllowUserToResizeColumns = true;
                    _tabelaServicos.AllowUserToDeleteRows = false;
                    _tabelaServicos.DataSource = datatable;
                    //tabelaServicos.Sort(tabelaServicos.Columns["idServico"], ListSortDirection.Descending);
                }

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