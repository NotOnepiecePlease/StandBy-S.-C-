﻿using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_5___Lucros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_LucrosV2 : DevExpress.XtraEditors.XtraForm
    {
        PreencherTabelaLucros tab_Lucros = new PreencherTabelaLucros();
        PreencherTabelaGastos tab_Gastos = new PreencherTabelaGastos();
        AlterarDados ad = new AlterarDados();
        DeletarDados dd = new DeletarDados();
        BuscarDados bd = new BuscarDados();
        int[] corGeral = new[] { 255, 0, 103 };
        DateTime datep1;
        DateTime datep2;
        int gastoID = 0;

        public form_LucrosV2()
        {
            InitializeComponent();

            //Impedir que a thread de erro
            CheckForIllegalCrossThreadCalls = false;
            MudarCores();
            datepicker1.Value = new DateTime(DateTime.Now.Year, 01, 01);
            datepicker2.Value = DateTime.Now;
        }

        public void MudarCores()
        {
            btnLucroUltimos30Dias.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circleLucroLiquido.ProgressColor       = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //circle2.ProgressColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circleLucroBruto.ProgressColor   = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            circleGastosTotais.ProgressColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            checkGastos.CheckedOnColor       = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            // panelBarH.BackColor                = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.BackColor                     = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[0].BackColor            = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[1].BackColor            = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnAddGastos.BorderColor           = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnAddGastos.OnHoverBaseColor      = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnGastosControle.BorderColor      = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnGastosControle.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
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
                    tab_Gastos.PreencherGastosTotais(tabelaGastos, datep1, datep2, 1);
                }
                else
                {
                    lblGastos.Text = "Exibindo Gastos Reais";
                    tab_Gastos.PreencherGastosTotais(tabelaGastos, datep1, datep2, 0);
                }

                tab_Lucros.Preencher(tabelaLucros, datep1, datep2, lblLucro);

                //If pra mostrar a label "Nao existem dados"
                if (tabelaLucros.RowCount == 0)
                {
                    lblSemDados.Visible = true;
                }

                //Começa o trabalho com threads
                lblREAL1.Visible           = true;
                lblREAL2.Visible           = true;
                lblREAL3.Visible           = true;
                circleLucroLiquido.Visible = false;
                circleLucroBruto.Visible   = false;
                circleGastosTotais.Visible = false;

                //circle2.Visible = false;

                //panelResults.Visible = true;
                Thread.Sleep(100);

                circleLucroLiquido.animated = true;
                backWork1.RunWorkerAsync();

                circleLucroBruto.animated = true;
                backWork3.RunWorkerAsync();

                circleGastosTotais.animated = true;
                backWork4.RunWorkerAsync();
            }
        }

        private void backWork1_DoWork(object sender, DoWorkEventArgs e)
        {
            lblLucroLiquido.Location = new Point(370, 79);
            lblLucroLiquido.Text     = "Carregando...";

            animateCircle1.ShowSync(circleLucroLiquido);
            circleLucroLiquido.Visible = true;

            animateCircle1.ShowSync(lblLucroLiquido);
            lblLucroLiquido.Visible = true;

            animateCircle1.ShowSync(lblDesc1);
            lblDesc1.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circleLucroLiquido.Value = i;
                Thread.Sleep(20);
            }
        }

        private void backWork1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //decimal valorDecimal = Convert.ToDecimal(tab_Lucros.getServicos().ToString("0.00"));
            decimal valorGastos = Convert.ToDecimal(tab_Gastos.getGastos().ToString("0.00"));
            decimal valorLucrosBruto = Convert.ToDecimal(tab_Lucros.getLucros().ToString("0.00"));
            decimal valorLucroLiquido = valorLucrosBruto - valorGastos;
            lblLucroLiquido.Text = valorLucroLiquido.ToString();

            //MessageBox.Show(valorDecimal.ToString("0.00"));
            if (Convert.ToDecimal(lblLucroLiquido.Text) <= 0)
            {
                lblLucroLiquido.Text = "00.00";

                lblLucroLiquido.Location = new Point(409, 82);
            }

            decimal valor = Convert.ToDecimal(lblLucroLiquido.Text);
            if (valor > 10.00m && valor < 999.99m)
            {
                lblLucroLiquido.Location = new Point(403, 82);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblLucroLiquido.Location = new Point(398, 82);
                lblLucroLiquido.Text     = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorLucroLiquido);
            }
            else if (valor > 9999.99m)
            {
                lblLucroLiquido.Location = new Point(394, 82);
                lblLucroLiquido.Text     = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorLucroLiquido);
            }

            circleLucroLiquido.animated = false;
        }

        private void backWork3_DoWork(object sender, DoWorkEventArgs e)
        {
            lblLucro.Location = new Point(569, 82);
            lblLucro.Text     = "Carregando...";

            //Animando a circleProgressBar
            animateCircle3.ShowSync(circleLucroBruto);
            circleLucroBruto.Visible = true;

            //Animando a Label de valor
            animateCircle3.ShowSync(lblLucro);
            lblLucro.Visible = true;

            //Animando a label de descricao
            animateCircle3.ShowSync(lblDesc3);
            lblDesc3.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circleLucroBruto.Value = i;
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

                lblLucro.Location = new Point(608, 82);
            }

            //lblLucro.Text = (r3.NextDouble() * 1000).ToString("0.00");
            decimal valor = Convert.ToDecimal(lblLucro.Text);
            if (valor > 10.00m && valor < 999.99m)
            {
                lblLucro.Location = new Point(603, 82);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblLucro.Location = new Point(597, 82);
                lblLucro.Text     = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            else if (valor > 9999.99m)
            {
                lblLucro.Location = new Point(592, 82);
                lblLucro.Text     = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }

            //lblDesc3.Text = "Lucro Total";
            circleLucroBruto.animated = false;
        }

        private void backWork4_DoWork(object sender, DoWorkEventArgs e)
        {
            lblGastosValor.Location = new Point(768, 82);
            lblGastosValor.Text     = "Carregando...";

            //Animando a circleProgressBar
            animateCircle4.ShowSync(circleGastosTotais);
            circleGastosTotais.Visible = true;

            //Animando a Label de valor
            animateCircle4.ShowSync(lblGastosValor);
            lblGastosValor.Visible = true;

            //Animando a label de descricao
            animateCircle4.ShowSync(lblDesc4);
            lblDesc4.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                circleGastosTotais.Value = i;
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

                lblGastosValor.Location = new Point(807, 82);
            }

            decimal valor = Convert.ToDecimal(lblGastosValor.Text);
            if (valor > 10.00m && valor < 999.99m)
            {
                lblGastosValor.Location = new Point(802, 82);
            }
            else if (valor > 999.99m && valor < 9999.99m)
            {
                lblGastosValor.Location = new Point(796, 82);
                lblGastosValor.Text     = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }
            else if (valor > 9999.99m)
            {
                lblGastosValor.Location = new Point(791, 82);
                lblGastosValor.Text     = String.Format(new CultureInfo("pt-BR"), "{0:n}", valorDecimal);
            }

            //lblDesc4.Text = "Lucro Total";
            circleGastosTotais.animated = false;
        }

        private void checkGastos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGastos.Checked == true)
            {
                //tornar temp
                menu.Items[0].Visible = false;

                //tornar real
                menu.Items[1].Visible = true;
                lblGastos.Text        = "Exibindo Gastos Temp";
                PegarDatasDatePicker();
                tab_Gastos.PreencherGastosEntreDatas(tabelaGastos, datep1, datep2, 1);

                //tab_Gastos.PreencherGastosTotais(tabelaGastos, datep1, datep2, 1);
            }
            else
            {
                //tornar temp
                menu.Items[0].Visible = true;

                //tornar real
                menu.Items[1].Visible = false;
                lblGastos.Text        = "Exibindo Gastos Reais";
                PegarDatasDatePicker();
                tab_Gastos.PreencherGastosEntreDatas(tabelaGastos, datep1, datep2, 0);

                //tab_Gastos.PreencherGastosTotais(tabelaGastos, datep1, datep2, 0);
            }
        }

        public void PreencherTableConformCheck()
        {
            if (checkGastos.Checked == true)
            {
                PegarDatasDatePicker();
                tab_Gastos.PreencherGastosTotais(tabelaGastos, datep1, datep2, 1);
            }
            else
            {
                PegarDatasDatePicker();
                tab_Gastos.PreencherGastosTotais(tabelaGastos, datep1, datep2, 0);
            }
        }

        private void btnAddGastos_Click(object sender, EventArgs e)
        {
            using (form_Lucros_Gastos formLucro = new form_Lucros_Gastos(this, corGeral))
            {
                formLucro.ShowDialog();
            }
        }

        private void tabelaLucros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja deletar esse gasto?", "ALERTA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
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

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            //int status = Convert.ToInt32(tabelaGastos.SelectedCells[4].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja alterar esse gasto?", "ALERTA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                form_Lucros_Gastos_Exibir_Alterar formGastosAlterar = new form_Lucros_Gastos_Exibir_Alterar(this, corGeral);
                formGastosAlterar.lblID.Text                  = tabelaGastos.SelectedCells[0].Value.ToString();
                formGastosAlterar.datePicker1.Value           = Convert.ToDateTime(tabelaGastos.SelectedCells[1].Value.ToString());
                formGastosAlterar.txtProdutoGastosEditar.Text = tabelaGastos.SelectedCells[2].Value.ToString();
                formGastosAlterar.txtValorGastosEditar.Text   = tabelaGastos.SelectedCells[3].Value.ToString();
                formGastosAlterar.ShowDialog();
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
                    MessageBox.Show(@"Calma, primeiro voce deve carregar dados na tabela antes de clicar",
                        "Calma...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (gastoID == 0)
                {
                    MessageBox.Show(@"Primeiro clique no gasto que deseja alterar/deletar", "ALERTA!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLucroUltimos30Dias_Click(object sender, EventArgs e)
        {
            LucroUltimos30Dias();
        }

        public void LucroUltimos30Dias()
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
                    tab_Gastos.PreencherGastosMesAtual(tabelaGastos, datep1, datep2, 1);
                }
                else
                {
                    lblGastos.Text = "Exibindo Gastos Reais";
                    tab_Gastos.PreencherGastosMesAtual(tabelaGastos, datep1, datep2, 0);
                }

                //tab_Lucros.Preencher(tabelaLucros, datep1, datep2, lblLucro);
                tab_Lucros.PreencherLucroMesAtual(tabelaLucros, lblLucro);

                //If pra mostrar a label "Nao existem dados"
                if (tabelaLucros.RowCount == 0)
                {
                    lblSemDados.Visible = true;
                }

                //Começa o trabalho com threads
                circleLucroLiquido.Visible = false;

                //circle2.Visible = false;
                circleLucroBruto.Visible   = false;
                circleGastosTotais.Visible = false;

                //panelResults.Visible = true;
                Thread.Sleep(100);

                circleLucroLiquido.animated = true;
                backWork1.RunWorkerAsync();

                //circle2.animated = true;
                //backWork2.RunWorkerAsync();

                circleLucroBruto.animated = true;
                backWork3.RunWorkerAsync();

                circleGastosTotais.animated = true;
                backWork4.RunWorkerAsync();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarServico();
        }

        public void EditarServico()
        {
            int idServico = Convert.ToInt32(tabelaLucros.SelectedCells[0].Value.ToString());
            List<object> dados = new List<object>();

            dados = bd.BuscarServicoPorID(idServico);
            EditarUmServicoPelaID(dados);
        }

        public void EditarUmServicoPelaID(List<object> dados)
        {
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);

            string _TELCliente = bd.BuscarTelefoneCliente(Convert.ToInt32(dados[1]));
            string _TEL_RECCliente = bd.BuscarTelefoneRecadoCliente(Convert.ToInt32(dados[1]));
            float lucro = float.Parse(dados[10].ToString());
            try
            {
                string _CPFCliente = bd.BuscarCPFCliente(Convert.ToInt32(dados[1]));
                editarServicos.txtCPFCliente.Text     = _CPFCliente;
                editarServicos.txtAcessoriosEdit.Text = dados[14].ToString();
            }
            catch (Exception)
            {
            }

            editarServicos.lblIDservico.Text   = dados[0].ToString();
            editarServicos.lblIDcliente.Text   = dados[1].ToString();
            editarServicos.dtpDataEdit.Value   = Convert.ToDateTime(dados[2].ToString());
            editarServicos.lblClienteNome.Text = dados[3].ToString();
            editarServicos.txtClienteNome.Text = dados[3].ToString();

            editarServicos.txtTelefoneCliente.Text = _TELCliente;
            editarServicos.txtTelefoneRecado.Text  = _TEL_RECCliente;
            editarServicos.txtAparelhoEdit.Text    = dados[4].ToString();
            editarServicos.txtDefeitoEdit.Text     = dados[5].ToString();
            editarServicos.txtSenhaEdit.Text       = dados[7].ToString();
            editarServicos.txtSituacaoEdit.Text    = dados[6].ToString();

            editarServicos.txtServicoValorEdit.Text = dados[8].ToString();
            editarServicos.txtPecaValorEdit.Text    = dados[9].ToString();
            editarServicos.txtLucroValorEdit.Text   = dados[10].ToString();
            editarServicos.txtServicoEdit.Text      = dados[11].ToString();
            if (dados[12] == DBNull.Value)
            {
                //MessageBox.Show("Sem data");
                editarServicos.dtpDataEditPrevisao.FormatCustom = " ";
                editarServicos.dtpDataEditPrevisao.Format       = DateTimePickerFormat.Custom;
                editarServicos.chkSemData.Checked               = true;
            }
            else
            {
                editarServicos.dtpDataEditPrevisao.Value = Convert.ToDateTime(dados[12].ToString());
                editarServicos.chkSemData.Checked        = false;
            }

            if (lucro > 0)
            {
                editarServicos.txtLucroValorEdit.LineIdleColor = Color.LimeGreen;
            }
            else if (lucro == 0)
            {
                editarServicos.txtLucroValorEdit.LineIdleColor = Color.White;
            }
            else
            {
                editarServicos.txtLucroValorEdit.LineIdleColor = Color.Red;
            }

            editarServicos.LabelResize();

            editarServicos.ShowDialog();

            //table_OrdensServicos.Refresh();
            //refreshTable();
        }

        private void tabelaLucros_DoubleClick(object sender, EventArgs e)
        {
            EditarServico();
        }

        private void btnGastosControle_Click(object sender, EventArgs e)
        {
            form_Gastos formGastos = new form_Gastos(corGeral);
            formGastos.ShowDialog();
        }
    }
}