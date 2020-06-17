using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_OrdensServ_Edit : Form
    {
        form_OrdensServ formServ1;
        AlterarDados ad = new AlterarDados();
        MensagensErro mErro = new MensagensErro();
        //form_OrdensServ form = new form_OrdensServ();
        int[] corGeral = new int[] { 0, 0, 0 };
        public int ImprimiuAlgumaNota = 0;
        public form_OrdensServ_Edit(form_OrdensServ formServ, int[] _cor)
        {
            InitializeComponent();
            formServ1 = formServ;
            this.ActiveControl = txtAparelhoEdit;
            corGeral = _cor;
            MudarCores();
            CalcularLucro();
        }

        public form_OrdensServ_Edit()
        {
            InitializeComponent();
        }

        public void MudarCores()
        {
            //CalcularLucro();
            groupBox1.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            groupBox2.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            groupBox3.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtAparelhoEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtDefeitoEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPecaValorEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSenhaEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtServicoValorEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //txtLucroValorEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtServicoEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panel2.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        public void CalcularLucro()
        {
            float valorServico = 0.0f;
            float valorPeca = 0.0f;
            float lucro = valorServico - valorPeca;
            try
            {
                valorServico = float.Parse(txtServicoValorEdit.Text);
                valorPeca = float.Parse(txtPecaValorEdit.Text);
                lucro = valorServico - valorPeca;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            if (lucro > 0)
            {
                txtLucroValorEdit.ForeColor = Color.LimeGreen;
                txtLucroValorEdit.LineIdleColor = Color.LimeGreen;
                txtLucroValorEdit.LineMouseHoverColor = Color.LimeGreen;
                txtLucroValorEdit.LineFocusedColor = Color.LimeGreen;
                txtLucroValorEdit.Font = new Font(this.Font.Name, 14, FontStyle.Bold);
                txtLucroValorEdit.Text = "R$: " + lucro.ToString();
            }
            else if (lucro == 0)
            {
                txtLucroValorEdit.ForeColor = Color.White;
                txtLucroValorEdit.LineIdleColor = Color.White;
                txtLucroValorEdit.LineMouseHoverColor = Color.White;
                txtLucroValorEdit.LineFocusedColor = Color.White;
                txtLucroValorEdit.Text = "R$: " + lucro.ToString();
            }
            else if (lucro < 0)
            {
                txtLucroValorEdit.ForeColor = Color.Red;
                txtLucroValorEdit.LineIdleColor = Color.Red;
                txtLucroValorEdit.LineMouseHoverColor = Color.Red;
                txtLucroValorEdit.LineFocusedColor = Color.Red;
                txtLucroValorEdit.Text = "R$: " + lucro.ToString();
            }
        }

        public void LabelResize()
        {
            int x = (panelNome.Size.Width - lblClienteNome.Width) / 2;
            int y = (panelNome.Size.Height - lblClienteNome.Height) / 2;

            lblClienteNome.Location = new Point(x, y);
        }

        private void btnEditarServico_Click(object sender, EventArgs e)
        {
            float valorServico = float.Parse(txtServicoValorEdit.Text);
            float valorPeca = float.Parse(txtPecaValorEdit.Text);
            float lucro = valorServico - valorPeca;

            ad.AlterarServico(Int32.Parse(lblIDservico.Text), dtpDataEdit.Value, txtAparelhoEdit.Text, txtDefeitoEdit.Text, txtSenhaEdit.Text, txtSituacaoEdit.Text,
                float.Parse(txtServicoValorEdit.Text), float.Parse(txtPecaValorEdit.Text), lucro, txtServicoEdit.Text);
            formServ1.refreshTable();
            this.Close();
        }

        private void txtServicoValorEdit_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularLucro();
            //txtServicoValorEdit.Text = "R$ " + txtServicoValorEdit.Text;
        }

        private void txtPecaValorEdit_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularLucro();
        }

        private void form_OrdensServ_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnConcluirServico_Click(object sender, EventArgs e)
        {
            ConcluirServico();
        }

        public void ConcluirServico()
        {
            ad.ConcluirServicos(Int32.Parse(lblIDservico.Text));
            formServ1.refreshTable();
            this.Close();
        }
        private void form_OrdensServ_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeletarArquivoWordCliente();
        }

        public void DeletarArquivoWordCliente()
        {
            try
            {
                DirectoryInfo directorySave = new DirectoryInfo(@".\NotaWord\cliente1.docx");
                File.Delete(directorySave.FullName);
            }
            catch (Exception)
            {
            }
        }
        private void btnConcluirImprimir_Click(object sender, EventArgs e)
        {
            using (form_WordNota imprimirNota = new form_WordNota(this, corGeral))
            {
                ImprimiuAlgumaNota = 0;
                imprimirNota.txtCliente.Text = lblClienteNome.Text;
                imprimirNota.txtServico.Text = txtServicoEdit.Text;
                imprimirNota.txtModelo.Text = txtAparelhoEdit.Text;
                imprimirNota.txtValor.Text = txtServicoValorEdit.Text;
                imprimirNota.ShowDialog();
                DeletarArquivoWordCliente();
                if (ImprimiuAlgumaNota == 1)
                {
                    ConcluirServico();
                }
            }
        }
    }
}
