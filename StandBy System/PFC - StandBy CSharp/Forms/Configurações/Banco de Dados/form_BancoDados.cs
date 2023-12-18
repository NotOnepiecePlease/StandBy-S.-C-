using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PFC___StandBy_CSharp.Forms.Configurações.Banco_de_Dados
{
    public partial class form_BancoDados : Form
    {
        public form_BancoDados()
        {
            InitializeComponent();

            BuscarInstancias();

            //Testes();
        }

        private void Testes()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    cmbServers.Properties.Items.Add($"{i}");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void BuscarInstancias()
        {
            //string serverName = Dns.GetHostName();
            string serverName = Environment.MachineName;

            RegistryView registryView =
                Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey =
                    hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        cmbServers.Properties.Items.Add(serverName + "\\" + instanceName);
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string server = cmbServers.SelectedItem.ToString();
            //UpdateSqlConnection(server);

            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexão estabelecida com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao estabelecer conexão: " + ex.Message);
                }
            }
        }

        private void UpdateSqlConnection(string server)
        {
            // Atualizar a conexão com o servidor e as credenciais de login
            string connectionString = GetConnectionString(server, txtLogin.Text, txtSenha.Text);

            // Use a connectionString conforme necessário para outras operações de banco de dados
        }

        private string GetConnectionString()
        {
            // Obter a string de conexão com o servidor e as credenciais de login
            string server = cmbServers.SelectedItem.ToString();
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            return GetConnectionString(server, login, senha);
        }

        private string GetConnectionString(string server, string login, string senha)
        {
            // Construir a string de conexão com base no servidor e nas credenciais de login
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource     = server;
            builder.InitialCatalog = "standby_org"; // Substitua pelo nome do banco de dados desejado
            builder.UserID         = login;
            builder.Password       = senha;
            return builder.ConnectionString;
        }
    }
}