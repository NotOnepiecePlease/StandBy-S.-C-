using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_PasswordPatternExibir : Form
    {
        int[] corGeral = new int[3] { 0,0,0};
        public form_PasswordPatternExibir(int[] _corRGB)
        {
            InitializeComponent();
            corGeral = _corRGB;
            MudarCores();
        }

        private void form_PasswordPatternExibir_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void MudarCores()
        {
            btnSim.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSim.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSim.onHoverState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSim.onHoverState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSim.OnIdleState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSim.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnSim.OnPressedState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnSim.OnPressedState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);


            btnNao.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNao.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnNao.onHoverState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNao.onHoverState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnNao.OnIdleState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNao.OnIdleState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnNao.OnPressedState.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNao.OnPressedState.FillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            form_PasswordPattern passShow = new form_PasswordPattern(corGeral, true);
            passShow.lblIDServico.Text = lblIDServico.Text;
            passShow.ShowDialog();
            this.Close();
        }
        public void CentralizarLabels(BunifuCustomLabel label)
        {
            label.Left = (this.Width / 2) - (label.Width / 2);
        }
    }
}
