using PFC___StandBy_CSharp.Forms;
using System;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp
{
    public partial class form_Loading : Form
    {
        public form_Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (bunifuCircleProgressbar1.Value < 100)
            //{
            //    bunifuCircleProgressbar1.Value += 1;
            //}
            if (gunaCircleProgressBar1.Value < 100)
            {
                gunaCircleProgressBar1.Value += 1;
                lblPorcento.Text = gunaCircleProgressBar1.Value.ToString();
            }
            else
            {
                this.Hide();
                timer1.Stop();
                //Thread.Sleep(2000);
                form_StandBy formst = new form_StandBy();
                formst.Show();
            }
        }

        private void lblPorcento_Click(object sender, EventArgs e)
        {
        }
    }
}