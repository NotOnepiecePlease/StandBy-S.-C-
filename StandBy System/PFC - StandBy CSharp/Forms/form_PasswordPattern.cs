using Bunifu.Framework.UI;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.LockScreenAndroid;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_PasswordPattern : Form
    {
        private static string pastaRaiz = @"./PasswordPattern";

        private conexao con = new conexao();
        private AlterarDados ad = new AlterarDados();
        private Image image1 = null;
        private form_OrdemServicoEntrada formOrdemServico;

        private int[] corGeral = new int[3] { 0, 0, 0 };
        private bool isUpdate = false;

        public form_PasswordPattern(int[] _corRgb)
        {
            InitializeComponent();
            criarPastaDasSenhas();
            corGeral = _corRgb;
            MudarCores();
            isUpdate = false;
            this.Size = new Size(261, 239);
        }

        public form_PasswordPattern(form_OrdemServicoEntrada _formOrdemServico, int[] _corRgb)
        {
            InitializeComponent();
            criarPastaDasSenhas();
            formOrdemServico = _formOrdemServico;
            corGeral = _corRgb;
            MudarCores();
            isUpdate = false;
            this.Size = new Size(261, 239);
        }

        public form_PasswordPattern(int[] _corRgb, bool _isUpdate)
        {
            InitializeComponent();
            criarPastaDasSenhas();
            corGeral = _corRgb;
            MudarCores();
            isUpdate = _isUpdate;
            this.Size = new Size(261, 239);
        }

        public void MudarCores()
        {
            //Senha certa
            btnSenhaCorreta.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaCorreta.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaCorreta.onHoverState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaCorreta.onHoverState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaCorreta.OnIdleState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaCorreta.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaCorreta.OnPressedState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaCorreta.OnPressedState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //Senha errada
            btnSenhaIncorreta.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaIncorreta.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaIncorreta.onHoverState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaIncorreta.onHoverState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaIncorreta.OnIdleState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaIncorreta.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSenhaIncorreta.OnPressedState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSenhaIncorreta.OnPressedState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        public void criarPastaDasSenhas()
        {
            if (Directory.Exists(pastaRaiz))
            {
            }
            else
            {
                Directory.CreateDirectory(pastaRaiz);
            }
        }

        private static void SaveScreenshot(Form frm)
        {
            string ImagePath = string.Format(@"./PasswordPattern/Screen.png", DateTime.Now.Ticks);
            //Bitmap Image = new Bitmap(frm.Width, frm.Height);
            Bitmap Image = new Bitmap(261, 264);
            frm.DrawToBitmap(Image, new Rectangle(0, 0, frm.Width, frm.Height));
            Image.Save(ImagePath, ImageFormat.Png);
        }

        public void CentralizarLabels(BunifuCustomLabel label)
        {
            label.Left = (this.Width / 2) - (label.Width / 2);
        }

        private void lockScreenControl1_PassCodeSubmitted(object sender, PassCodeSubmittedEventArgs e)
        {
            lblPasswordInNumbers.Text = "";
            lblPasswordInNumbers.Visible = true;

            int qntd = lockScreenControl1.inputtedPassCode.Count();
            int cnt = 0;
            foreach (var item in lockScreenControl1.inputtedPassCode)
            {
                if (cnt < qntd)
                {
                    lblPasswordInNumbers.Text += (item + 1).ToString() + " "; //item+1 porque contagem comeca em 0
                }
                else
                {
                    lblPasswordInNumbers.Text += (item + 1);
                }
                cnt++;
            }
            CentralizarLabels(lblPasswordInNumbers);
            this.Size = new Size(261, 337);
            SaveScreenshot(this);
            //Desativo a visibilidade da lockscreen
            lockScreenControl1.Visible = false;
            //Mostro o picture box para mostrar a print da senha feita
            pictureBox1.Visible = true;
            //Aqui eu pego a imagem salva da senha e mostro do picturebox
            //pictureBox1.Image = ConvertByteArrayToImage(buscarImagem());
            Image image1 = GetCopyImage(@"./PasswordPattern/Screen.png");

            //Deleto a imagem
            //var dir = new DirectoryInfo(@"./PasswordPattern/");
            //var files = dir.GetFiles().FirstOrDefault();
            //files.Delete();

            pictureBox1.Image = image1;

            //Label q pergunta se a senha esta correta
            lblPasswordIsCorrect.Visible = true;
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        public void inserirImage(byte[] image)
        {
            try
            {
                using (SqlConnection cone = con.OpenConnection())
                {
                    string query = "insert into tb_imagem(imagem) values (@image)";

                    SqlCommand cmd = new SqlCommand(query, cone);

                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        public byte[] buscarImagem()
        {
            byte[] bytes;
            using (SqlConnection cone = con.OpenConnection())
            {
                string query = "select imagem from tb_imagem where id = 1";

                SqlCommand cmd = new SqlCommand(query, cone);

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                reader.Read();

                bytes = (byte[])reader[0];

                return bytes;
            }
        }

        private byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnSenhaCorreta_Click(object sender, EventArgs e)
        {
            if (isUpdate == false)
            {
                this.Close();
                formOrdemServico.picSenhaPattern.Image = GetCopyImage(@"./PasswordPattern/Screen.png");
            }
            else
            {
                try
                {
                    image1 = GetCopyImage(@"./PasswordPattern/Screen.png");
                    var dir = new DirectoryInfo(@"./PasswordPattern/");
                    var files = dir.GetFiles().FirstOrDefault();
                    files.Delete();
                }
                catch (Exception)
                {
                }
                //Atualizar senha
                ad.AlterarSenhaPattern(ConvertImageToByte(image1), Convert.ToInt32(lblIDServico.Text));
                this.Close();
            }
        }

        private void btnSenhaIncorreta_Click(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(@"./PasswordPattern/");
            var files = dir.GetFiles().FirstOrDefault();
            files.Delete();

            this.Size = new Size(261, 239);
            lockScreenControl1.Visible = true;
            pictureBox1.Visible = false;
            lblPasswordIsCorrect.Visible = false;
            lblPasswordInNumbers.Visible = false;
            pictureBox1.Image = null;
        }

        private void form_PasswordPattern_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}