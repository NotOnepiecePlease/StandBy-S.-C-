﻿using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_5___Lucros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_Lucros : Form
    {
        PreencherTabelaLucros tab_Lucros = new PreencherTabelaLucros();
        PreencherTabelaGastos tab_Gastos = new PreencherTabelaGastos();
        AlterarDados ad = new AlterarDados();
        DeletarDados dd = new DeletarDados();
        int[] corGeral = new[] { 0, 0, 0 };
        DateTime datep1;
        DateTime datep2;
        int gastoID = 0;
        public form_Lucros(int[] corRgb)
        {
            corGeral = corRgb;
            InitializeComponent();
            //Impedir que a thread de erro
            CheckForIllegalCrossThreadCalls = false;
            MudarCores();
            datepicker1.Value = new DateTime(2020, 01, 01);
            datepicker2.Value = DateTime.Now;
        }

        public void MudarCores()
        {
            btnAddGastos.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circle1.ProgressColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circle2.ProgressColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circle3.ProgressColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circle4.ProgressColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            checkGastos.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelBarH.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[0].BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[1].BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        public void PegarDatasDatePicker()
        {
            datep1 = datepicker1.Value;
            datep2 = datepicker2.Value;
        }
        private void btnExecutarThread_Click(object sender, EventArgs e)
        {
            //If pra impedir do usuario interromper o thread.
            if (!backWork1.IsBusy && !backWork2.IsBusy && !backWork3.IsBusy)
            {
                PegarDatasDatePicker();
                lblSemDados.Visible = false;

                //If para saber com qual dado preencher a table gastos
                //se vai ser gastos reais ou temporarios
                if (checkGastos.Checked == true)
                {
                    lblGastos.Text = "Exibindo Gastos Temp";
                    tab_Gastos.PreencherEntreDatas(tabelaGastos, datep1, datep2, 1);
                }
                else
                {
                    lblGastos.Text = "Exibindo Gastos Reais";
                    tab_Gastos.PreencherEntreDatas(tabelaGastos, datep1, datep2, 0);
                }
                tab_Lucros.Preencher(tabelaLucros, datep1, datep2, lblLucro);

                //If pra mostrar a label "Nao existem dados"
                if (tabelaLucros.RowCount == 0)
                {
                    lblSemDados.Visible = true;
                }

                //Começa o trabalho com threads
                circle1.Visible = false;
                circle2.Visible = false;
                circle3.Visible = false;
                circle4.Visible = false;

                panelResults.Visible = true;
                Thread.Sleep(100);

                circle1.animated = true;
                backWork1.RunWorkerAsync();

                circle2.animated = true;
                backWork2.RunWorkerAsync();

                circle3.animated = true;
                backWork3.RunWorkerAsync();

                circle4.animated = true;
                backWork4.RunWorkerAsync();
            }
        }

        private void backWork1_DoWork(object sender, DoWorkEventArgs e)
        {
            lblValorServico.Location = new Point(341, 94);
            lblValorServico.Text = "Carregando...";

            animateCircle1.ShowSync(circle1);
            circle1.Visible = true;

            animateCircle1.ShowSync(lblValorServico);
            lblValorServico.Visible = true;

            animateCircle1.ShowSync(lblDesc1);
            lblDesc1.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circle1.Value = i;
                Thread.Sleep(20);
            }
        }
        private void backWork1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Nao entra aqui porque a thread executa direto pra o completo
            //nao fica muito tempo dentro do "Do Work"
        }
        private void backWork1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            decimal valorDecimal = Convert.ToDecimal(tab_Lucros.getServicos().ToString("0.00"));
            lblValorServico.Text = valorDecimal.ToString();
            //MessageBox.Show(valorDecimal.ToString("0.00"));
            if (Convert.ToDecimal(lblValorServico.Text) <= 0)
            {
                lblValorServico.Text = "00.00";
                lblValorServico.Location = new Point(377, 94);
            }
            decimal valor = Convert.ToDecimal(lblValorServico.Text);
            if (valor > 99.99m && valor < 999.99m)
            {
                lblValorServico.Location = new Point(372, 94);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblValorServico.Location = new Point(363, 94);
                lblValorServico.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            else if (valor > 9999.99m)
            {
                lblValorServico.Location = new Point(358, 94);
                lblValorServico.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            circle1.animated = false;
        }

        private void backWork2_DoWork(object sender, DoWorkEventArgs e)
        {
            lblValorPeca.Location = new Point(581, 94);
            lblValorPeca.Text = "Calculando...";

            animateCircle2.ShowSync(circle2);
            circle2.Visible = true;

            animateCircle2.ShowSync(lblValorPeca);
            lblValorPeca.Visible = true;

            animateCircle2.ShowSync(lblDesc2);
            lblDesc2.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circle2.Value = i;
                Thread.Sleep(20);
            }
        }

        private void backWork2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            decimal valorDecimal = Convert.ToDecimal(tab_Lucros.getPecas().ToString("0.00"));
            lblValorPeca.Text = valorDecimal.ToString();
            if (Convert.ToDecimal(lblValorPeca.Text) <= 0)
            {
                lblValorPeca.Text = "00.00";
                lblValorPeca.Location = new Point(617, 94);
            }
            decimal valor = Convert.ToDecimal(lblValorPeca.Text);
            if (valor > 99.99m && valor < 999.99m)
            {
                lblValorPeca.Location = new Point(612, 94);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblValorPeca.Location = new Point(603, 94);
                lblValorPeca.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            else if (valor > 9999.99m)
            {
                lblValorPeca.Location = new Point(598, 94);
                lblValorPeca.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            lblDesc2.Text = "Peças Totais";
            circle2.animated = false;
        }

        private void backWork3_DoWork(object sender, DoWorkEventArgs e)
        {
            lblLucro.Location = new Point(819, 94);
            lblLucro.Text = "Carregando...";
            //Animando a circleProgressBar
            animateCircle3.ShowSync(circle3);
            circle3.Visible = true;

            //Animando a Label de valor
            animateCircle3.ShowSync(lblLucro);
            lblLucro.Visible = true;

            //Animando a label de descricao
            animateCircle3.ShowSync(lblDesc3);
            lblDesc3.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circle3.Value = i;
                Thread.Sleep(20);
            }
        }

        private void backWork3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            decimal valorDecimal = Convert.ToDecimal(tab_Lucros.getLucros().ToString("0.00"));
            lblLucro.Text = valorDecimal.ToString();
            if (Convert.ToDecimal(lblLucro.Text) <= 0)
            {
                lblLucro.Text = "00.00";
                lblLucro.Location = new Point(855, 94);
            }
            //lblLucro.Text = (r3.NextDouble() * 1000).ToString("0.00");
            decimal valor = Convert.ToDecimal(lblLucro.Text);
            if (valor > 99.99m && valor < 999.99m)
            {
                lblLucro.Location = new Point(850, 94);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblLucro.Location = new Point(841, 94);
                lblLucro.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            else if (valor > 9999.99m)
            {
                lblLucro.Location = new Point(836, 94);
                lblLucro.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            //lblDesc3.Text = "Lucro Total";
            circle3.animated = false;
        }

        private void backWork4_DoWork(object sender, DoWorkEventArgs e)
        {
            lblGastosValor.Location = new Point(119, 94);
            lblGastosValor.Text = "Carregando...";
            //Animando a circleProgressBar
            animateCircle4.ShowSync(circle4);
            circle4.Visible = true;

            //Animando a Label de valor
            animateCircle4.ShowSync(lblGastosValor);
            lblGastosValor.Visible = true;

            //Animando a label de descricao
            animateCircle4.ShowSync(lblDesc4);
            lblDesc4.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circle4.Value = i;
                Thread.Sleep(20);
            }
        }

        private void backWork4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            decimal valorDecimal = Convert.ToDecimal(tab_Gastos.getGastos().ToString("0.00"));
            lblGastosValor.Text = valorDecimal.ToString();
            if (Convert.ToDecimal(lblGastosValor.Text) <= 0)
            {
                lblGastosValor.Text = "00.00";
                lblGastosValor.Location = new Point(155, 94);
            }
            decimal valor = Convert.ToDecimal(lblGastosValor.Text);
            if (valor > 99.99m && valor < 999.99m)
            {
                lblGastosValor.Location = new Point(150, 94);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblGastosValor.Location = new Point(141, 94);
                lblGastosValor.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            else if (valor > 9999.99m)
            {
                lblGastosValor.Location = new Point(136, 94);
                lblGastosValor.Text = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            //lblDesc4.Text = "Lucro Total";
            circle4.animated = false;
        }

        private void checkGastos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGastos.Checked == true)
            {
                //tornar temp
                menu.Items[0].Visible = false;
                //tornar real
                menu.Items[1].Visible = true;
                lblGastos.Text = "Exibindo Gastos Temp";
                PegarDatasDatePicker();
                tab_Gastos.PreencherEntreDatas(tabelaGastos, datep1, datep2, 1);
                //tab_Gastos.Preencher(tabelaGastos, 1);
                //tabelaGastos.Columns[0].Visible = false;
            }
            else
            {
                //tornar temp
                menu.Items[0].Visible = true;
                //tornar real
                menu.Items[1].Visible = false;
                lblGastos.Text = "Exibindo Gastos Reais";
                PegarDatasDatePicker();
                tab_Gastos.PreencherEntreDatas(tabelaGastos, datep1, datep2, 0);
                //tab_Gastos.Preencher(tabelaGastos, 0);
                //tabelaGastos.Columns[0].Visible = false;
            }
        }

        public void PreencherTableConformCheck()
        {
            if (checkGastos.Checked == true)
            {
                PegarDatasDatePicker();
                tab_Gastos.PreencherEntreDatas(tabelaGastos, datep1, datep2, 1);
            }
            else
            {
                PegarDatasDatePicker();
                tab_Gastos.PreencherEntreDatas(tabelaGastos, datep1, datep2, 0);
            }
        }

        private void btnAddGastos_Click(object sender, EventArgs e)
        {
            using (form_Lucros_Gastos formLucro = new form_Lucros_Gastos(this, corGeral))
            {
                formLucro.ShowDialog();
            }
        }

        private void tabelaGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_Lucros_Gastos_Exibir gastosExibir = new form_Lucros_Gastos_Exibir(this, corGeral, checkGastos.Checked);
            gastosExibir.ShowDialog();
        }

        private void tornarTemporarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() +
                "\n\nDeseja tornar um gasto temporario?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                ad.AlterarGastos(gastoID, 1);
                tab_Gastos.Preencher(tabelaGastos, 0);
            }
            else
            {
            }
        }

        private void tornarRealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() +
                "\n\nDeseja tornar um gasto real?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                ad.AlterarGastos(gastoID, 0);
                tab_Gastos.Preencher(tabelaGastos, 1);
            }
            else
            {
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            int status = Convert.ToInt32(tabelaGastos.SelectedCells[4].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja deletar esse gasto?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                if (status == 0)
                {
                    dd.DeletarGastos(gastoID, tabelaGastos);
                    tab_Gastos.Preencher(tabelaGastos, 0);
                }
                else if (status == 1)
                {
                    dd.DeletarGastos(gastoID, tabelaGastos);
                    tab_Gastos.Preencher(tabelaGastos, 1);
                }
            }
            else
            {
            }
        }

        private void tabelaGastos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Calma, primeiro voce deve carregar dados na tabela antes de clicar",
                        "Calma...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (gastoID == 0)
                {
                    MessageBox.Show("Primeiro clique no gasto que deseja alterar/deletar", "ALERTA!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            //int status = Convert.ToInt32(tabelaGastos.SelectedCells[4].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja alterar esse gasto?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                form_Lucros_Gastos_Exibir_Alterar formGastosAlterar = new form_Lucros_Gastos_Exibir_Alterar(this, corGeral);
                formGastosAlterar.lblID.Text = tabelaGastos.SelectedCells[0].Value.ToString();
                formGastosAlterar.datePicker1.Value = Convert.ToDateTime(tabelaGastos.SelectedCells[1].Value.ToString());
                formGastosAlterar.txtProdutoGastosEditar.Text = tabelaGastos.SelectedCells[2].Value.ToString();
                formGastosAlterar.txtValorGastosEditar.Text = tabelaGastos.SelectedCells[3].Value.ToString();
                formGastosAlterar.ShowDialog();
            }
            else
            {
            }
        }
    }
}
