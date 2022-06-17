using System;
using System.Drawing;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_ALERT : Form
    {
        public form_ALERT(string _message, AlertType type)
        {
            InitializeComponent();

            LabelResize();

            lblMensagem.Text = _message;
            switch (type)
            {
                case AlertType.Sucesso:
                    //pictureBox1.Image = imageList1.Images[0];
                    iconPictureBox1.ImageLocation = "../../Resources/Sucesso.png";
                    break;

                case AlertType.Aviso:
                    iconPictureBox1.ImageLocation = "../../Resources/Aviso.png";
                    break;

                case AlertType.Erro:
                    iconPictureBox1.ImageLocation = "../../Resources/Erro.png";
                    break;
            }
        }

        public enum AlertType
        {
            Sucesso, Aviso, Erro
        }

        private void LabelResize()
        {
            int x = (panelMensagem.Size.Width - lblMensagem.Width) / 2;
            int y = (panelMensagem.Size.Height - lblMensagem.Height) / 2;

            lblMensagem.Location = new Point(x, y);
        }

        private void form_ALERT_Load(object sender, EventArgs e)
        {
            form_StandBy fs = new form_StandBy();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            //this.Top = fs.Height - this.Height - 400;
            //this.Left = fs.Width - this.Width + 301;
            //this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 100;
            this.Opacity = 0;
            show.Start();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //closeform.Start();
            this.Close();
        }

        private void timerout_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.Close();
            closeform.Start();
            //timerout.Stop();
        }

        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.80)
            {
                this.TopMost = true;
                this.Opacity += 0.05;
            }
            else
            {
                //Thread.Sleep(200);
                show.Stop();
                //closeform.Start();
            }
        }

        private void closeform_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.TopMost = true;
                //show.Stop();
                this.Opacity -= 0.05;
            }
            else
            {
                this.Close();
            }
        }

        private void tiniFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}