using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.SqlDbConnect
{


    public class conexao
    {
        BackupDados bckData = new BackupDados();
        //private string dataSQL = "a";
        //string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison para iPhone
        //string ConnectionString = "Data Source=localhost\\SQEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison
        private string ConnectionString = "";
        //string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        //static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        //SqlConnection con = new SqlConnection(ConnectionString);
        //
        SqlConnection con;

        public void lerDataSourceSQL()
        {
            string txtPath = bckData.caminhoTXT;

            List<string> datasourceTXT = new List<string>();

            datasourceTXT = File.ReadAllLines(txtPath).ToList();
            ConnectionString = String.Format("Data Source={0};Initial Catalog=standby_org;Integrated Security=True", datasourceTXT.FirstOrDefault().ToString());
            Console.Write("teste");
        }
        public SqlConnection OpenConnection()
        {
            bckData.criarPasta();
            lerDataSourceSQL();

            con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar com o banco de dados!", "SEM CONEXAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
