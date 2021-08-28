using PFC___StandBy_CSharp.SqlDbConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_PasswordPattern : Form
    {
        private static string pastaRaiz = @"./PasswordPattern";

        conexao con = new conexao();
        public form_PasswordPattern()
        {
            InitializeComponent();
            criarPastaDasSenhas();

            this.Size = new Size(261, 264);
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
        private void lockScreenControl1_PassCodeSubmitted(object sender, GestureLockApp.GestureLockControl.PassCodeSubmittedEventArgs e)
        {
            foreach (var item in lockScreenControl1.inputtedPassCode)
            {
                // MessageBox.Show(item.ToString());
            }

            SaveScreenshot(this);
            this.Size = new Size(261, 320);
            //Desativo a visibilidade da lockscreen
            lockScreenControl1.Visible = false;
            //Mostro o picture box para mostrar a print da senha feita
            pictureBox1.Visible = true;
            //Aqui eu pego a imagem salva da senha e mostro do picturebox
            //pictureBox1.Image = ConvertByteArrayToImage(buscarImagem());
            Image image1 = GetCopyImage(@"./PasswordPattern/Screen.png");
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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Image image1 = Image.FromFile(@"./PasswordPattern/Screen.png");
            inserirImage(ConvertImageToByte(image1));

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            //lockScreenControl1.Visible = false;
            //pictureBox1.Visible = true;

            //pictureBox1.Image = ConvertByteArrayToImage(buscarImagem());
            var dir = new DirectoryInfo(@"./PasswordPattern/");
            var files = dir.GetFiles().FirstOrDefault();
            files.Delete();

            this.Size = new Size(261, 264);
            lockScreenControl1.Visible = true;
            pictureBox1.Visible = false;
            lblPasswordIsCorrect.Visible = false;
            pictureBox1.Image = null;

        }
    }
}
