using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using PFC___StandBy_CSharp.APIs.License;
using Exception = System.Exception;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_License : Form
    {
        public static Api KeyAuthApp = new Api(
            name: "StandBy_System",
            ownerid: "0Rsf85nHh3",
            secret: "e1966a726019c5fd86801cabeda8f889bb9d54c679c46750c160d7e8c0b1d900",
            version: "1.0"
        );

        public form_License()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public bool isConectadoInternet()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 2000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void BuscarLicenca(string _licenseKey)
        {
            KeyAuthApp.InitializeConnectionKeyAuth();
            KeyAuthApp.LicenseAuth(_licenseKey);
            if (KeyAuthApp.response.success)
            {
                lblCarregamento.Text = KeyAuthApp.response.message == "Logged in!" ? $"Software Ativado por: {KeyAuthApp.GetExpiryDaysHoursMinutesLeft()}" : KeyAuthApp.response.message;
                lblCarregamento.Location = new Point(212, 205);
                DateTime dataCriacao = KeyAuthApp.UnixTimeToDateTime(long.Parse(KeyAuthApp.user_data.createdate));
                DateTime dataExpiracao = KeyAuthApp.UnixTimeToDateTime(long.Parse(KeyAuthApp.user_data.subscriptions[0].expiry));
                string chaveLicenca = KeyAuthApp.user_data.username;
                EscreverDadosLicencaRegedit(dataCriacao, dataExpiracao, chaveLicenca);
                //form_StandBy formStandBy = new form_StandBy();
                //formStandBy.Show();
                //this.Hide();
            }
            else
            {
                //Mostrar de algum jeito que a licença do usuario nao esta valida e nao vai ser possivel abrir o sistema.
                lblCarregamento.Text = KeyAuthApp.response.message;
            }
        }

        public bool isPrimeiraInicializacaoSistema()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\TechnologiesSBS");

            if (key == null || key.ValueCount == 0) //se for nullo ou nao tem chaves é porque nunca foi cadastrada uma licença
            {
                return true;
            }
            return false;
        }

        private void EscreverDadosLicencaRegedit(DateTime _dataCriacaoLicenca, DateTime _dataExpiracaoLicenca, string _chaveLicenca)
        {
            //Data de Criacao da Licença = DCL
            //Data de Expiração da Licença = DEL
            //Chave da Licença = CL
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TechnologiesSBS");
            key.SetValue("dcl", _dataCriacaoLicenca);
            key.SetValue("del", _dataExpiracaoLicenca);
            key.SetValue("cl", _chaveLicenca);
            key.Close();
        }

        private struct Licenca
        {
            private DateTime dataCriacao;
            private DateTime dataExpiracao;
            public string chaveLicenca;

            public Licenca(DateTime _dataCriacao, DateTime _dataExpiracao, string _chaveLicenca)
            {
                dataCriacao = _dataCriacao;
                dataExpiracao = _dataExpiracao;
                chaveLicenca = _chaveLicenca;
            }
        }

        private Licenca LerDadosLicencaRegedit()
        {
            Licenca dadosLicenca = new Licenca();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\TechnologiesSBS");
            try
            {
                dadosLicenca = new Licenca(Convert.ToDateTime(key.GetValue("dcl")), Convert.ToDateTime(key.GetValue("del")),
                    key.GetValue("cl").ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return dadosLicenca;
        }

        private void form_License_Load(object sender, EventArgs e)
        {
            timerProgressBar.Stop();
            if (isConectadoInternet() == true)
            {
                if (isPrimeiraInicializacaoSistema() == true)
                {
                    txtLicense.Visible = true;
                    btnAtivarLicense.Visible = true;
                    lblCarregamento.Location = new Point(319, 205);
                    lblCarregamento.Text = "Digite sua licença abaixo";
                    progressCarregando.Value = 0;
                    progressCarregando.Visible = false;
                }
                else
                {
                    lblCarregamento.Text = "Carregando licença...";
                    lblCarregamento.Location = new Point(336, 205);

                    timerProgressBar.Start();

                    txtLicense.Visible = false;
                    btnAtivarLicense.Visible = false;
                }
            }
        }

        private void CarregarProgressBar()
        {
            for (int i = 0; i < 99; i++)
            {
                progressCarregando.Value += 1;
                Thread.Sleep(100);
            }
        }

        private void btnAtivarLicense_Click(object sender, EventArgs e)
        {
            BuscarLicenca(txtLicense.Text.Trim());
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (progressCarregando.Value == 100)
            {
                Licenca dadosLicenca = new Licenca();
                dadosLicenca = LerDadosLicencaRegedit();
                BuscarLicenca(dadosLicenca.chaveLicenca);
                lblCarregamento.Text = $"Licença válida, restam: {KeyAuthApp.GetExpiryDaysLeft()}";
                lblCarregamento.Location = new Point(294, 205);
                timerProgressBar.Stop();
                return;
            }
            progressCarregando.Value += 1;
        }
    }
}