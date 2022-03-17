﻿using PFC___StandBy_CSharp.Dados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.SqlDbConnect
{
    public class conexao
    {
        private BackupDados bckData = new BackupDados();

        //private string dataSQL = "a";
        //string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison para iPhone
        //                          "Server=localhost\\SQLEXPRESS;Database=SEU_BANCO;User Id=SEU_LOGIN;Password=SUA_SENHA;
        //string ConnectionString = "Data Source=localhost\\SQEXPRESS;Initial Catalog=standby_org;Integrated Security=True"; //de Cleison
        private string ConnectionString = "";

        //string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        //static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        //SqlConnection con = new SqlConnection(ConnectionString);
        //
        private SqlConnection con;

        public void lerDataSourceSQL()
        {
            string txtPath = bckData.caminhoTXT;

            List<string> datasourceTXT = new List<string>();

            datasourceTXT = File.ReadAllLines(txtPath).ToList();
            //Desenvolvimento
            ConnectionString = String.Format("Data Source={0};Initial Catalog=standby_org;Integrated Security=True", datasourceTXT.FirstOrDefault().ToString());
            //Produção
            //ConnectionString = String.Format("Data Source={0};Network Library=DBMSSOCN;Initial Catalog=standby_org;User ID=admintcp;Password=123adr;", datasourceTXT.FirstOrDefault().ToString());
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
                MessageBox.Show(@"Nao foi possivel se conectar com o banco de dados!", "SEM CONEXAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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