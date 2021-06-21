using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.SqlDbConnect
{
    public class conexao
    {
        //string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison para iPhone
        string ConnectionString = "Data Source=localhost\\SQEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison
       //string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=standby_org;Integrated Security=True";
        SqlConnection con;
        public SqlConnection OpenConnection()
        {
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
