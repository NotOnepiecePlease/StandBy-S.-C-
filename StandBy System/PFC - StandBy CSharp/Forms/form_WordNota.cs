using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Word
//using System.Reflection;
//using Word = Microsoft.Office.Interop.Word;
using System.IO;
//using System.Diagnostics;
using PFC___StandBy_CSharp.Properties;
//using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;
using PFC___StandBy_CSharp.Formatar_Campos;
using PFC___StandBy_CSharp.Dados;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_WordNota : Form
    {

        int qntDiasGarantia = 0;
        string diretorioArquivoPadrao = Settings.Default.diretorio_default_word;
        string diretorioPadrao = @".\NotaWord";
        int[] corGeral = { 0, 0, 0 };
        form_OrdensServ_Edit ordensServ;
        Formatar apenasNumeros = new Formatar();
        InserirDados ins_Dados = new InserirDados();

        public form_WordNota(form_OrdensServ_Edit _ordensServ, int[] _corRgb)
        {
            InitializeComponent();
            tFilename.Text = diretorioArquivoPadrao;
            DirectoryInfo directoryInfo = new DirectoryInfo(diretorioArquivoPadrao);
            ordensServ = _ordensServ;
            corGeral = _corRgb;
            switchGarantia.Checked = true;
            CentralizarLabels();
            MudarCores();
        }
        public form_WordNota()
        {
            InitializeComponent();
            tFilename.Text = diretorioArquivoPadrao;
            DirectoryInfo directoryInfo = new DirectoryInfo(diretorioArquivoPadrao);
            corGeral = new int[] { 255, 0, 103 };
            switchGarantia.Checked = true;
            CentralizarLabels();
            MudarCores();
        }

        public void MudarCores()
        {
            tFilename.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCarregarWord.OnPressedColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnPastaPadrao.OnPressedColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCriarWord.BaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCriarWord.OnHoverBaseColor = Color.FromArgb(120, corGeral[0], corGeral[1], corGeral[2]);
            btnCriarWord.OnPressedColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblImpressoraPdrao.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtCliente.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtCPF.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtModelo.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtServico.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtValor.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            tFilename.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtGarantia.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            iconClose.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            iconClose.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            gunaLabel1.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            gunaLabel2.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            gunaLabel3.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            gunaLabel4.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            gunaLabel5.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //lblMes1.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //lblMes2.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //lblMes3.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblGarantia.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //checkboxUmMes.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //checkboxDoisMeses.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //checkboxTresMeses.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            gunaPanel1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            switchGarantia.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

        }
        private void CentralizarLabels()
        {
            var configImpressora = new PrinterSettings();
            lblImpressoraPdrao.Text = configImpressora.PrinterName;
            lblImpressoraPdrao.Left = (this.Width / 2) - (lblImpressoraPdrao.Width / 2);
            lblArquivoPadrao.Left = (this.Width / 2) - (lblArquivoPadrao.Width / 2);
        }

        //Méthode Enabled Controles:
        private void tEnabled(bool state)
        {
            txtCliente.Enabled = state;
            txtCPF.Enabled = state;
            txtModelo.Enabled = state;
            txtServico.Enabled = state;
            txtValor.Enabled = state;
        }

        private void btnCarregarWord_Click(object sender, EventArgs e)
        {
            if (LoadDoc.ShowDialog() == DialogResult.OK)
            {
                //txt Recebe o caminho do arquivo carregado
                tFilename.Text = LoadDoc.FileName;
                //Salvo esse caminho nas configuracoes
                Settings.Default.diretorio_default_word = LoadDoc.FileName;
                //e Salvo esse caminho tambem na variavel global de diretorio
                diretorioArquivoPadrao = Settings.Default.diretorio_default_word;
                //Salvo.
                Settings.Default.Save();
                tEnabled(true);
            }
        }

        private void btnCriarWord_Click(object sender, EventArgs e)
        {
            ImprimirNota();
            //GerarImpressaoNota();
        }

        public void GerarImpressaoNota()
        {
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                dialog.Document = printDocument1;
                ((Form)dialog).WindowState = FormWindowState.Maximized;
                dialog.PrintPreviewControl.Zoom = 200 / 100f;
                //dialog.ShowDialog();
                printDocument1.Print();
                //dialog.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat sfcenter = new StringFormat();
            sfcenter.LineAlignment = StringAlignment.Center;
            sfcenter.Alignment = StringAlignment.Center;
            //this.PrintPreviewControl1.Zoom = 0.25;

            int x = 140, y = 10; //start position
            x += 0; //left align texts with logo image
            y += 30; //some space below logo

            var fntregular = new Font("Calibri (Corpo)", 8, FontStyle.Regular);
            var fntbold = new Font("Calibri (Corpo)", 9, FontStyle.Bold);
            int dy = (int)fntregular.GetHeight(e.Graphics); //20; //line height spacing

            //e.Graphics.ScaleTransform(0.5F, 0.5F);
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
            e.Graphics.DrawString("____________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("DESCRIÇÃO DO SERVIÇO", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            e.Graphics.DrawString("____________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy; //Menos = Direita | Mais valor = Esquerda
            e.Graphics.DrawString("♥ Serviço - ", fntregular, Brushes.Black, new PointF(x - 140, y));
            e.Graphics.DrawString(txtServico.Text, fntbold, Brushes.Black, new PointF(x - 80, y));
            y += dy;
            e.Graphics.DrawString("♣ Modelo do Aparelho - ", fntregular, Brushes.Black, new PointF(x - 140, y));
            e.Graphics.DrawString(txtModelo.Text, fntbold, Brushes.Black, new PointF(x - 15, y));
            y += dy;
            e.Graphics.DrawString("♦ Valor - ", fntregular, Brushes.Black, new PointF(x - 140, y));
            e.Graphics.DrawString(txtValor.Text, fntbold, Brushes.Black, new PointF(x - 90, y));
            y += dy;
            e.Graphics.DrawString("♠ Cliente - ", fntregular, Brushes.Black, new PointF(x - 140, y));
            e.Graphics.DrawString(txtCliente.Text, fntbold, Brushes.Black, new PointF(x - 80, y));
            y += dy;
            e.Graphics.DrawString("• CPF - ", fntregular, Brushes.Black, new PointF(x - 100, y + 5));
            e.Graphics.DrawString(txtCPF.Text, fntbold, Brushes.Black, new PointF(x - 60, y + 4));
            y += dy;
            y += dy;
            e.Graphics.DrawString("____________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("GARANTIA", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            e.Graphics.DrawString("____________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString(qntDiasGarantia + " dias.", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("Não cobre danos causados pelo cliente.", fntregular, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("DATA " + DateTime.Now.ToShortDateString(), fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            e.Graphics.DrawString("____________________________________________", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("Volte Sempre!", fntbold, Brushes.Black, new PointF(x, y), sfcenter);
            y += dy;
            y += dy;
            e.Graphics.DrawString("NÃO É VÁLIDO COMO DOCUMENTO FISCAL", fntbold, Brushes.Black, new PointF(x, y), sfcenter);

        }

        public void ImprimirNota()
        {
            string DiasGarantia = QuantosDiasGarantia();
            GerarImpressaoNota();
            //Caso de um bug e nada de garantia seja preenchido a impressao nao vai acontecer.
            if (!DiasGarantia.Equals("0"))
            {
                if (switchGarantia.Checked == true)
                {
                    ins_Dados.InserirGarantia(Convert.ToInt32(lblIDServico.Text), Convert.ToInt32(lblIDCliente.Text), Convert.ToInt32(qntDiasGarantia));
                }
            }
            this.Close();
        }

        public string QuantosDiasGarantia()
        {
            int numero;
            //MessageBox.Show(int.TryParse(txtGarantia.Text, out numero).ToString());

            //Se a garantia estiver habilitada, todas as checks desmarcadas e o usuario digitar algum numero na textbox, garantia valida.
            if (switchGarantia.Checked == true && checkboxUmMes.Checked == false && checkboxDoisMeses.Checked == false && checkboxTresMeses.Checked == false && int.TryParse(txtGarantia.Text, out numero) == true)
            {
                //MessageBox.Show(txtGarantia.Text);
                qntDiasGarantia = Convert.ToInt32(txtGarantia.Text);
                return "Garantia de " + txtGarantia.Text + " dias sob o serviço executado";
            }
            //se checkbox 1 mes tiver marcada e o resto nao, garantia = 30 dias
            else if (checkboxUmMes.Checked == true && checkboxDoisMeses.Checked == false && checkboxTresMeses.Checked == false && txtGarantia.Enabled == false)
            {
                //MessageBox.Show("30");
                qntDiasGarantia = 30;
                return "Garantia de 30 dias sob o serviço executado";

            }
            //se checkbox 2 meses tiver marcada e o resto nao, garantia = 60 dias
            else if (checkboxDoisMeses.Checked == true && checkboxUmMes.Checked == false && checkboxTresMeses.Checked == false && txtGarantia.Enabled == false)
            {
                //MessageBox.Show("60");
                qntDiasGarantia = 60;
                return "Garantia de 60 dias sob o serviço executado";
            }
            //se checkbox 3 meses tiver marcada e o resto nao, garantia = 90 dias
            else if (checkboxTresMeses.Checked == true && checkboxUmMes.Checked == false && checkboxDoisMeses.Checked == false && txtGarantia.Enabled == false)
            {
                //MessageBox.Show("90");
                qntDiasGarantia = 90;
                return "Garantia de 90 dias sob o serviço executado";
            }
            //se todas checkboxs estiverem desmarcadas, mesmo com a garantia habilitada e sem numeros na textbox (deu bug) cai aqui.
            else if (switchGarantia.Checked == true && checkboxUmMes.Checked == false && checkboxDoisMeses.Checked == false && checkboxTresMeses.Checked == false && string.IsNullOrWhiteSpace(txtGarantia.Text) || txtGarantia.Text.Equals("Nenhuma acima? especifique aqui"))
            {
                MessageBox.Show("Algo errado aconteceu, voce nao marcou nenhuma opção de garantia e nao preencheu" +
                    " o campo de garantia personalizada, por favor, informe a garantia ou desative-a.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                qntDiasGarantia = 0;
                return "0";
            }
            //senao, entao a txtGarantia ta habilitada e retorna o valor customizado
            else
            {
                //MessageBox.Show("ULTIMAO");
                qntDiasGarantia = 0;
                return "Sem garantia";
            }
        }

        private void btnPastaPadrao_Click(object sender, EventArgs e)
        {
            diretorioArquivoPadrao = @".\NotaWord\Cupom fiscal.docx";
            Settings.Default.diretorio_default_word = diretorioArquivoPadrao;
            Settings.Default.Save();
            tFilename.Text = diretorioArquivoPadrao;
            tEnabled(true);
        }

        private void form_WordNota_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (processosAntes != null || processosDepois != null)
            //{
            //    killProcesses(processosAntes, processosDepois);
            //}
            //try
            //{
            //    //DirectoryInfo directorySave = new DirectoryInfo(@".\NotaWord\cliente1.docx");
            //    //File.Delete(directorySave.FullName);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void form_WordNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                //ordensServ.ImprimiuAlgumaNota = 0;
            }
        }

        private void form_WordNota_Load(object sender, EventArgs e)
        {

        }

        public void DeletarArquivoNoInicio()
        {
            DirectoryInfo directorySave = new DirectoryInfo(@".\NotaWord\cliente1.docx");
            File.Delete(directorySave.FullName);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkboxUmMes_Click(object sender, EventArgs e)
        {
            if (checkboxUmMes.Checked == true)
            {
                txtGarantia.Enabled = false;
                checkboxDoisMeses.Checked = false;
                checkboxTresMeses.Checked = false;
            }
            else
            {
                txtGarantia.Enabled = true;
            }
        }

        private void checkboxDoisMeses_Click(object sender, EventArgs e)
        {
            if (checkboxDoisMeses.Checked == true)
            {
                txtGarantia.Enabled = false;
                checkboxUmMes.Checked = false;
                checkboxTresMeses.Checked = false;
            }
            else
            {
                txtGarantia.Enabled = true;
            }
        }

        private void checkboxTresMeses_Click(object sender, EventArgs e)
        {
            if (checkboxTresMeses.Checked == true)
            {
                txtGarantia.Enabled = false;
                checkboxUmMes.Checked = false;
                checkboxDoisMeses.Checked = false;
            }
            else
            {
                txtGarantia.Enabled = true;
            }
        }

        private void switchGarantia_CheckedChanged(object sender, EventArgs e)
        {
            if (switchGarantia.Checked == false)
            {
                checkboxUmMes.Enabled = false;
                checkboxUmMes.Checked = false;

                checkboxDoisMeses.Enabled = false;
                checkboxDoisMeses.Checked = false;

                checkboxTresMeses.Enabled = false;
                checkboxTresMeses.Checked = false;

                txtGarantia.Enabled = false;
                txtGarantia.Text = "";

                lblGarantiaStatus.Text = "Sem garantia";
                lblGarantiaStatus.ForeColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                checkboxUmMes.Enabled = true;
                checkboxUmMes.Checked = false;

                checkboxDoisMeses.Enabled = true;
                checkboxDoisMeses.Checked = false;

                checkboxTresMeses.Enabled = true;
                checkboxTresMeses.Checked = true;

                txtGarantia.Enabled = false;
                txtGarantia.Text = "";

                lblGarantiaStatus.Text = "Com garantia";
                lblGarantiaStatus.ForeColor = Color.LimeGreen;

                txtGarantia.Text = "Nenhuma acima? especifique aqui";
                txtGarantia.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Italic);
                txtGarantia.ForeColor = Color.Silver;
            }
        }

        private void txtGarantia_Enter(object sender, EventArgs e)
        {
            txtGarantia.Text = "";
            txtGarantia.Font = new System.Drawing.Font("Segoe UI", 12.25f, FontStyle.Regular);
            txtGarantia.ForeColor = Color.White;
        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGarantia.Text))
            {
                txtGarantia.Text = "Nenhuma acima? especifique aqui";
                txtGarantia.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Italic);
                txtGarantia.ForeColor = Color.Silver;
            }
        }

        private void txtGarantia_KeyUp(object sender, KeyEventArgs e)
        {
            //apenasNumeros.AplicarApenasNumerosSemVirgula(txtGarantia);
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtGarantia.Text.Contains(','));
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Apenas numeros!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void form_WordNota_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
