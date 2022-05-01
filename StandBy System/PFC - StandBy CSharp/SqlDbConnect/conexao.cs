using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.SqlDbConnect
{
    public class conexao
    {
        private readonly BackupDados bckData = new BackupDados();

        //private string dataSQL = "a";
        //string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison para iPhone
        //                          "Server=localhost\\SQLEXPRESS;Database=SEU_BANCO;User Id=SEU_LOGIN;Password=SUA_SENHA;
        //string ConnectionString = "Data Source=localhost\\SQEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison
        private string connectionString = "";

        //string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        //static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        //SqlConnection con = new SqlConnection(ConnectionString);
        //
        private SqlConnection con;

        public void LerDataSourceSql()
        {
            string txtPath = bckData.CaminhoTxt;

            //Removo as letras e os espacos e deixo so as informações uteis

            List<string> dadosSqlConexao = File.ReadAllLines(txtPath).Where(x => !x.Contains("#")).ToList();
            string ip = dadosSqlConexao[0].TrimStart('I', 'P', '=').Trim();
            string porta = dadosSqlConexao[1].TrimStart('P', 'O', 'R', 'T', '=').Trim();
            string login = dadosSqlConexao[2].TrimStart('U', 'S', 'E', 'R', '=').Trim();
            string senha = dadosSqlConexao[3].TrimStart('P', 'A', 'S', '=').Trim();
            string type = dadosSqlConexao[4].TrimStart('T', 'Y', 'P', 'E', '=').Trim();

            if (type.Equals("0"))//Se o tipo do sistema for o 0 (Sistema principal stand by)
            {
                connectionString = $"Server={ip};Database=standby_org;User Id={login};Password={senha};";
            }
            else if (type.Equals("1"))// se nao, se for do tipo 1 (cliente - server)
            {
                connectionString = $"Server={ip},{porta};Database=standby_org;User Id={login};Password={senha};";
            }
            else
            {
                MessageBox.Show(@"Configura corretamente o campo TYPE nas configurações!\nUtilize 0 se for o sistema principal\nUtilize 1 se for o sistema secundário");
            }
        }

        public SqlConnection OpenConnection()
        {
            bckData.criarPasta();
            LerDataSourceSql();

            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show($"Nao foi possivel se conectar com o banco de dados!\n\nIP Local: {PegarIp()}", "SEM CONEXAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            return con;
        }

        public string PegarIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                string localIP = endPoint.Address.ToString();
                return localIP + ",1433";
            }
        }
    }
}