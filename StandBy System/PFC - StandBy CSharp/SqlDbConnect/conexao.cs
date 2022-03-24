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

        public void lerDataSourceSQL()
        {
            string txtPath = bckData.caminhoTXT;

            List<string> datasourceTXT = File.ReadAllLines(txtPath).ToList();
            connectionString = String.Format("Data Source={0};Initial Catalog=standby_org;Integrated Security=True", datasourceTXT.FirstOrDefault().ToString());
        }

        public SqlConnection OpenConnection()
        {
            bckData.criarPasta();
            lerDataSourceSQL();

            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show($"Nao foi possivel se conectar com o banco de dados!\nIP Local: {PegarIp()}", "SEM CONEXAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            return con;
        }

        public void CloseConnection()
        {
            con.Close();
        }

        //Metodo para executar qualquer query que precise de Insert,Update ou Delete.
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
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