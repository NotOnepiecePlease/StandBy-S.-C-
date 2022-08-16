using System;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using PFC___StandBy_CSharp.APIs.License;
using PFC___StandBy_CSharp.MsgBox;
using Exception = System.Exception;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_License : Form
    {
        private MensagensErro mErro = new MensagensErro();
        private string enckey = "";
        private bool isConectadoNaInternet = false;

        //Data de Criacao da Licença = DCL
        //Data de Expiração da Licença = DEL
        //Chave da Licença = CL

        private const string DIRETORIO_REGEDIT = @"Software\TechnologiesSBS";
        private const string DIRETORIO_REGEDIT_UDR = @"Software\TechnologiesSBS\udr";
        private const string DATA_CRIACAO_LICENCA = @"dcl";
        private const string DATA_EXPIRACAO_LICENCA = @"del";
        private const string CHAVE_LICENCA = @"cl";
        private const string ULTIMA_DATA_REGISTRADA = @"udr";

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
            enckey = Encryption.sha256(Encryption.iv_key()); //""
        }

        private void form_License_Load(object sender, EventArgs e)
        {
            VerificarAlteracaoMaliciosaRelogioWindows();
            RegistrarUltimaDataDeExecucao();
            timerProgressBar.Stop();
            isConectadoInternet();
            if (isConectadoNaInternet == true)
            {
                if (isPrimeiraInicializacaoSistema() == true)
                {
                    SolicitarLicenca();
                }
                else
                {
                    CarregarLicenca();
                }
            }
            else
            {
                if (isPrimeiraInicializacaoSistema() == true)
                {
                    MessageBox.Show("É Necessário estar conectado à internet para efetuar o cadastro de sua licença, " +
                                    "após efetuar esse cadastro, você pode utilizar o sistema sem precisar estar com acesso a internet.", "Licença nao existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
                else
                {
                    //Dados nao existem no regedit, vou buscar local
                    CarregarLicenca();
                }
            }
        }

        private void RegistrarUltimaDataDeExecucao()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(DIRETORIO_REGEDIT_UDR);
            string ultimaDataRegistradaEncrypt = Encryption.Encrypt(DateTime.Now.ToString(CultureInfo.CurrentCulture), KeyAuthApp.secret, enckey);
            key.SetValue(ULTIMA_DATA_REGISTRADA, ultimaDataRegistradaEncrypt);
        }

        private void VerificarAlteracaoMaliciosaRelogioWindows()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(DIRETORIO_REGEDIT_UDR);
                if (key != null && key.GetValue(ULTIMA_DATA_REGISTRADA) != null)
                {
                    string ultimaDataRegistradaEncrypt = key.GetValue(ULTIMA_DATA_REGISTRADA).ToString();
                    DateTime ultimaDataRegistradaDecrypt = Convert.ToDateTime(Encryption.Decrypt(ultimaDataRegistradaEncrypt, KeyAuthApp.secret, enckey));

                    if (ultimaDataRegistradaDecrypt >= DateTime.Now)
                    {
                        MessageBox.Show($"Foi detectada uma alteração ilegal no sistema operacional, o StandBy System não será inicializado.", "ALTERAÇÂO ILEGAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao detectar alterações maliciosas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void isConectadoInternet()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 2000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                isConectadoNaInternet = (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                isConectadoNaInternet = false;
            }
        }

        public bool isPrimeiraInicializacaoSistema()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(DIRETORIO_REGEDIT);

            if (key == null || key.ValueCount == 0) //se for nullo ou nao tem chaves é porque nunca foi cadastrada uma licença
            {
                return true;
            }
            return false;

            //Poderia ser dessa forma mas acho a de cima mais legivel.
            //return key == null || key.ValueCount == 0;
        }

        private void EscreverDadosLicencaRegedit(DateTime _dataCriacaoLicenca, DateTime _dataExpiracaoLicenca, string _chaveLicenca)
        {
            string dataCriacaoEncrypt = Encryption.Encrypt(_dataCriacaoLicenca.ToString(CultureInfo.CurrentCulture), KeyAuthApp.secret, enckey);
            string dataExpiracaoEncrypt = Encryption.Encrypt(_dataExpiracaoLicenca.ToString(CultureInfo.CurrentCulture), KeyAuthApp.secret, enckey);
            string chaveLicencaEncrypt = Encryption.Encrypt(_chaveLicenca.ToString(CultureInfo.CurrentCulture), KeyAuthApp.secret, enckey);

            //Data de Criacao da Licença = DCL
            //Data de Expiração da Licença = DEL
            //Chave da Licença = CL
            RegistryKey key = Registry.CurrentUser.CreateSubKey(DIRETORIO_REGEDIT);
            key.SetValue(DATA_CRIACAO_LICENCA, dataCriacaoEncrypt);
            key.SetValue(DATA_EXPIRACAO_LICENCA, dataExpiracaoEncrypt);
            key.SetValue(CHAVE_LICENCA, chaveLicencaEncrypt);
            key.Close();
        }

        private struct Licenca
        {
            public DateTime dataCriacao;
            public DateTime dataExpiracao;
            public string chaveLicenca;

            public Licenca(DateTime _dataCriacao, DateTime _dataExpiracao, string _chaveLicenca)
            {
                dataCriacao = _dataCriacao;
                dataExpiracao = _dataExpiracao;
                chaveLicenca = _chaveLicenca;
            }
        }

        private Licenca LerDadosCriptografadosLicencaRegedit()
        {
            Licenca dadosLicenca = new Licenca();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(DIRETORIO_REGEDIT);
                string dataCriacaoEncrypt = key.GetValue(DATA_CRIACAO_LICENCA).ToString();
                DateTime dataCriacaoDecrypt = Convert.ToDateTime(Encryption.Decrypt(dataCriacaoEncrypt, KeyAuthApp.secret, enckey));

                string dataExpiracaoEncrypt = key.GetValue(DATA_EXPIRACAO_LICENCA).ToString();
                DateTime dataExpiracaoDecrypt = Convert.ToDateTime(Encryption.Decrypt(dataExpiracaoEncrypt, KeyAuthApp.secret, enckey));

                string chaveLicencaEncrypt = key.GetValue(CHAVE_LICENCA).ToString();
                string chaveLicencaDecrypt = Encryption.Decrypt(chaveLicencaEncrypt, KeyAuthApp.secret, enckey);

                //dadosLicenca = new Licenca(dataCriacao, dataExpiracao, chaveLicenca);
                dadosLicenca = new Licenca(Convert.ToDateTime(dataCriacaoDecrypt), Convert.ToDateTime(dataExpiracaoDecrypt), chaveLicencaDecrypt);
            }
            catch (Exception e)
            {
                mErro.ErroAoLerDadosLicencaRegedit(e);
            }

            return dadosLicenca;
        }

        private void CarregarLicenca()
        {
            lblCarregamento.Text = "Carregando licença...";
            lblCarregamento.Location = new Point(336, 205);

            timerProgressBar.Start();

            txtLicense.Visible = false;
            btnAtivarLicense.Visible = false;
        }

        private void SolicitarLicenca()
        {
            txtLicense.Visible = true;
            btnAtivarLicense.Visible = true;
            lblCarregamento.Location = new Point(319, 205);
            lblCarregamento.Text = "Digite sua licença abaixo";
            progressCarregando.Value = 0;
            progressCarregando.Visible = false;
        }

        private void btnAtivarLicense_Click(object sender, EventArgs e)
        {
            VerificarLicencaInternet(txtLicense.Text.Trim());
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (progressCarregando.Value == 100)
            {
                //Recebo os dados descriptografados dentro de dadosLicenca
                Licenca dadosLicenca = LerDadosCriptografadosLicencaRegedit();
                if (isConectadoNaInternet == true)
                {
                    VerificarLicencaInternet(dadosLicenca.chaveLicenca, false);
                    //lblCarregamento.Text = $"Licença válida, restam: {KeyAuthApp.GetExpiryDaysLeft()}";
                }
                else
                {
                    VerificarLicencaLocal(dadosLicenca);
                    //lblCarregamento.Text = $"Licença válida, restam: {KeyAuthApp.GetExpiryDaysLeft()}";
                }

                lblCarregamento.Location = new Point(294, 205);
                timerProgressBar.Stop();
                return;
            }
            progressCarregando.Value += 1;
        }

        private void VerificarLicencaLocal(Licenca _licenca)
        {
            VerificarAlteracaoMaliciosaRelogioWindows();
            if (_licenca.dataExpiracao < DateTime.Now)
            {
                lblCarregamento.Text = $"Licença expirada dia: {_licenca.dataExpiracao.ToShortDateString()}";
                lblCarregamento.Location = new Point(272, 205);
            }
            else
            {
                form_StandBy formStandBy = new form_StandBy();
                formStandBy.Show();
                this.Hide();
            }
        }

        private void VerificarLicencaInternet(string _licenseKey, bool _isPrimeiraAtivacao = true)
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

                if (_isPrimeiraAtivacao == true)
                {
                    //Se for a primeira vez que ta cadastrando uma licença, então o codigo pega essa licença
                    //e armazena dentro do regedit
                    EscreverDadosLicencaRegedit(dataCriacao, dataExpiracao, chaveLicenca);
                }
                form_StandBy formStandBy = new form_StandBy();
                formStandBy.Show();
                this.Hide();
            }
            else
            {
                //Mostrar de algum jeito que a licença do usuario nao esta valida e nao vai ser possivel abrir o sistema.
                lblCarregamento.Text = KeyAuthApp.response.message;
            }
        }
    }
}