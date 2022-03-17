using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        form_Concluidos formConcl1;
        form_Lucros formLucros1;
        form_DiaEntrega formDiaEntrega1;
        AlterarDados ad = new AlterarDados();
        BuscarDados bd = new BuscarDados();
        MensagensErro mErro = new MensagensErro();
        //form_OrdensServ form = new form_OrdensServ();
        int[] corGeral = new int[] { 0, 0, 0 };
        public int ImprimiuAlgumaNota = 0;
        public bool atualizarOuNaoATabelaDeServicos = false;


        public form_OrdensServ_Edit(form_OrdensServ formServ, int[] _cor)
        {
            InitializeComponent();
            formServ1 = formServ;
            this.ActiveControl = txtAparelhoEdit;
            corGeral = _cor;
            MudarCores();
            CalcularLucro();
            dtpDataEditPrevisao.Value = DateTime.Parse("26/03/2020");
        }
        public form_OrdensServ_Edit(form_Lucros formLucros, int[] _cor)
        {
            InitializeComponent();
            formLucros1 = formLucros;
            this.ActiveControl = txtAparelhoEdit;
            corGeral = _cor;
            MudarCores();
            CalcularLucro();
            dtpDataEditPrevisao.Value = DateTime.Parse("26/03/2020");
            btnConcluirServico.Visible = false;
        }
        public form_OrdensServ_Edit(form_Concluidos formConcluidos, int[] _cor)
        {
            InitializeComponent();
            formConcl1 = formConcluidos;
            this.ActiveControl = txtAparelhoEdit;
            corGeral = _cor;
            MudarCores();
            CalcularLucro();
            dtpDataEditPrevisao.Value = DateTime.Parse("26/03/2020");
        }
        public form_OrdensServ_Edit(form_DiaEntrega formDiaEntrega, int[] _cor)
        {
            InitializeComponent();
            formDiaEntrega1 = formDiaEntrega;
            this.ActiveControl = txtAparelhoEdit;
            corGeral = _cor;
            MudarCores();
            CalcularLucro();
            dtpDataEditPrevisao.Value = DateTime.Parse("26/03/2020");
            atualizarOuNaoATabelaDeServicos = true;
        }
        public form_OrdensServ_Edit(form_Concluidos form_Concluidos)
        {
            InitializeComponent();
        }

        public void MudarCores()
        {
            //CalcularLucro();
            groupBox1.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            groupBox2.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            groupBox3.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            groupBox4.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            txtAparelhoEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtDefeitoEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPecaValorEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSenhaEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtServicoValorEdit.LineMouseHoverColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
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
            catch (Exception)
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
            if (chkSemData.Checked == true)
            {
                SalvarEdicoesServico(DateTime.Parse("26/03/2020"));
                try
                {
                    if (atualizarOuNaoATabelaDeServicos == false)
                    {
                        formServ1.refreshTable();
                        formServ1.refreshTable();
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                SalvarEdicoesServico(dtpDataEditPrevisao.Value);
                try
                {
                    if (atualizarOuNaoATabelaDeServicos == false)
                    {

                        formServ1.refreshTable();
                        formServ1.refreshTable();
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        private void chkSemData_Click(object sender, EventArgs e)
        {
            if (chkSemData.Checked == true)
            {
                dtpDataEditPrevisao.Enabled = false;
                dtpDataEditPrevisao.Value = DateTime.Parse("26/03/2020");
                dtpDataEditPrevisao.FormatCustom = " ";
                dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtpDataEditPrevisao.Enabled = true;
                dtpDataEditPrevisao.Value = DateTime.Today;
                dtpDataEditPrevisao.FormatCustom = "dd/MM/yyyy";
                dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
            }
        }
        private void SalvarEdicoesServico(DateTime DataPrevisao)
        {
            float valorServico = float.Parse(txtServicoValorEdit.Text);
            float valorPeca = float.Parse(txtPecaValorEdit.Text);
            float lucro = valorServico - valorPeca;

            ad.AlterarServico(Int32.Parse(lblIDservico.Text), dtpDataEdit.Value, txtAparelhoEdit.Text, txtDefeitoEdit.Text, txtSenhaEdit.Text, txtSituacaoEdit.Text,
                float.Parse(txtServicoValorEdit.Text), float.Parse(txtPecaValorEdit.Text), lucro, txtServicoEdit.Text, DataPrevisao, txtAcessoriosEdit.Text);
            //formServ1.refreshTable();
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
            if (dtpDataEditPrevisao.Value.Date == DateTime.Parse("26/03/2020"))
            {
                //MessageBox.Show("e igual sim: " + dtpDataEditPrevisao.Value.ToString());
                SalvarEdicoesServico(DateTime.Parse("26/03/2020"));
            }
            else
            {
                SalvarEdicoesServico(dtpDataEditPrevisao.Value);
            }

            form_QntdGarantia darGarantia = new form_QntdGarantia(corGeral);
            darGarantia.lblIDServico.Text = lblIDservico.Text;
            darGarantia.lblIDCliente.Text = lblIDcliente.Text;
            darGarantia.ShowDialog();
            formServ1.refreshTable();
            this.Close();
            //ConcluirServico();
        }

        public void ConcluirServico()
        {
            ad.ConcluirServicos(Int32.Parse(lblIDservico.Text));
            formServ1.refreshTable();
            this.Close();
        }
        private void form_OrdensServ_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DeletarArquivoWordCliente();
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
            string cpfCliente = bd.BuscarCPFCliente(Convert.ToInt32(lblIDcliente.Text));
            if (cpfCliente.Length < 14)
            {
                MessageBox.Show(@"A Nota só pode ser emitida para clientes com CPF cadastrado.", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                imprimirNota();
            }
            //MessageBox.Show(""+cpfCliente.Length);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Iae adriano, to ligado que voce ta nesse metodo aqui pra adicionar o padrao na etiqueta
            //aqui o video pra lhe ajudar a por imagem no docword:
            //https://www.youtube.com/watch?v=2GcxY0nQxvA

            StringFormat sfcenter = new StringFormat();
            sfcenter.LineAlignment = StringAlignment.Center;
            sfcenter.Alignment = StringAlignment.Center;


            int x = 220, y = 10; //start position
            x += 0; //left align texts with logo image
            y += 30; //some space below logo

            var fntregular = new Font("Calibri (Corpo)", 10, FontStyle.Regular);
            var fntbold = new Font("Calibri (Corpo)", 10, FontStyle.Bold);
            int dy = (int)fntregular.GetHeight(e.Graphics); //20; //line height spacing

            e.Graphics.DrawString("STANDBY ASSISTÊNCIA TÉCNICA", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("CNPJ - 33.393.551/0001-11", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("Rua Segundo Sendes, 197B. Gleba B, Camaçari BA", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("Contato 71 98305-5871", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("Técnico Responsável - Cleison Ribeiro", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("Documento Auxiliar de Venda", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            y += dy;
            y += dy;
            e.Graphics.DrawString("____________________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("DESCRIÇÃO DO SERVIÇO", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            e.Graphics.DrawString("____________________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("♥ Serviço - <serviço>", fntregular, Brushes.Black, new PointF(x - 215, y));
            y += dy;
            e.Graphics.DrawString("♣ Modelo do aparelho - <aparelho>", fntregular, Brushes.Black, new PointF(x - 215, y));
            y += dy;
            e.Graphics.DrawString("♦ Valor - <valor>", fntregular, Brushes.Black, new PointF(x - 215, y));
            y += dy;
            e.Graphics.DrawString("♠ Cliente - <cliente>", fntregular, Brushes.Black, new PointF(x - 215, y));
            y += dy;
            e.Graphics.DrawString("• CPF - ", fntregular, Brushes.Black, new PointF(x - 180, y));
            e.Graphics.DrawString(txtCPFCliente.Text, fntbold, Brushes.Black, new PointF(x - 130, y));
            y += dy;
            y += dy;
            e.Graphics.DrawString("____________________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("GARANTIA", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            e.Graphics.DrawString("____________________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("<dias>.", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("Não cobre danos causados pelo cliente.", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("DATA <data>", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("____________________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("Volte Sempre!", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("NÃO É VÁLIDO COMO DOCUMENTO FISCAL", fntbold, Brushes.Black, new PointF(x, y), sfcenter);


        }

        public void imprimirNota()
        {
            using (form_WordNota imprimirNota = new form_WordNota(this, corGeral))
            {
                ImprimiuAlgumaNota = 0;
                imprimirNota.txtCliente.Text = lblClienteNome.Text;
                imprimirNota.txtServico.Text = txtServicoEdit.Text;
                imprimirNota.txtModelo.Text = txtAparelhoEdit.Text;
                imprimirNota.txtValor.Text = txtServicoValorEdit.Text;
                imprimirNota.lblIDServico.Text = lblIDservico.Text;
                imprimirNota.lblIDCliente.Text = lblIDcliente.Text;
                imprimirNota.txtCPF.Text = bd.BuscarCPFCliente(Convert.ToInt32(lblIDcliente.Text));
                imprimirNota.ShowDialog();
                DeletarArquivoWordCliente();
                if (ImprimiuAlgumaNota == 1)
                {
                    ConcluirServico();
                }
            }
        }

        private void txtServicoValorEdit_Enter(object sender, EventArgs e)
        {
            txtServicoValorEdit.Text = "0";
        }

        private void txtPecaValorEdit_Enter(object sender, EventArgs e)
        {
            txtPecaValorEdit.Text = "0";
        }

        private void txtLucroValorEdit_Enter(object sender, EventArgs e)
        {
            //txtLucroValorEdit.Text = "";
        }

        private void txtServicoEdit_Enter(object sender, EventArgs e)
        {
            txtServicoEdit.Text = "";
        }

        private void dtpDataEditPrevisao_onValueChanged(object sender, EventArgs e)
        {
            dtpDataEditPrevisao.FormatCustom = "dd/MM/yyyy";
            dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
            if (dtpDataEditPrevisao.Value != DateTime.Parse("26/03/2020"))
            {
                chkSemData.Checked = false;
            }
        }

        private void btnSemData_Click(object sender, EventArgs e)
        {
            dtpDataEditPrevisao.Value = DateTime.Parse("26/03/2020");
            dtpDataEditPrevisao.FormatCustom = " ";
            dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
        }

        private Image ConvertByteArrayToImage(byte[] data)
        {
            if (data[0] != 0)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }
        private void btn_ExibirPadraoSenha_Click(object sender, EventArgs e)
        {
            using (form_PasswordPatternExibir passShow = new form_PasswordPatternExibir(corGeral))
            {
                passShow.pictureBox1.Image = ConvertByteArrayToImage(bd.BuscarImagem(lblIDservico.Text));
                if (passShow.pictureBox1.Image == null)
                {
                    passShow.lblSemPadrao.Visible = true;
                    passShow.lblDesejaCadastrar.Visible = true;
                    passShow.btnSim.Visible = true;
                    passShow.btnNao.Visible = true;
                    passShow.lblIDServico.Text = lblIDservico.Text;
                }
                else
                {
                    passShow.lblSemPadrao.Visible = false;
                    passShow.lblDesejaCadastrar.Visible = false;
                    passShow.btnSim.Visible = false;
                    passShow.btnNao.Visible = false;
                    passShow.lblIDServico.Text = lblIDservico.Text;
                }

                passShow.ShowDialog();
            }
        }

        private void btn_EditarPadraoSenha_Click(object sender, EventArgs e)
        {
            using (form_PasswordPatternExibir passShow = new form_PasswordPatternExibir(corGeral))
            {
                //passShow.pictureBox1.Image = ConvertByteArrayToImage(bd.BuscarImagem(lblIDservico.Text));
                passShow.lblSemPadrao.Visible = true;
                passShow.lblDesejaCadastrar.Text = "Deseja Alterar?";
                passShow.CentralizarLabels(passShow.lblDesejaCadastrar);
                passShow.lblDesejaCadastrar.Visible = true;
                passShow.btnSim.Visible = true;
                passShow.btnNao.Visible = true;
                passShow.lblIDServico.Text = lblIDservico.Text;


                passShow.ShowDialog();
            }
        }
    }
}
