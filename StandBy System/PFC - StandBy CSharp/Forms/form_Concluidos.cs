using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_3___ServicosConcluidos;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_Concluidos : Form
    {
        PreencherTableConcluidos preencherTableConcluidos = new PreencherTableConcluidos();
        AlterarDados ad = new AlterarDados();
        BuscarDados bd = new BuscarDados();
        //MessageErro mErro = new MessageErro();
        VerificarExistencia ve = new VerificarExistencia();
        int[] corGeral = new int[3] { 0, 0, 0 };
        int linhasExibidas = 24;
        int paginaAtual = 1;
        public form_Concluidos(int[] corGeral)
        {
            InitializeComponent();
            preencherTableConcluidos.Preencher(table_ServicosConcluidos, 1, 24);
            atualizarLinhasExibidas();
            lblResultadosTotais.Text = Convert.ToString(bd.BuscarTotalServicosConcluidos());
            this.corGeral = corGeral;

            //Slider
            //horizontalSlider.Maximum = Convert.ToInt32(Math.Ceiling(bd.BuscarTotalServicosConcluidos() / 24d));
            //MessageBox.Show(horizontalSlider.Maximum.ToString());
            //horizontalSlider.Value = 1;

            MudarCores();
        }

        public void atualizarLinhasExibidas()
        {
            lblResultadosExibidos.Text = Convert.ToString(linhasExibidas);
        }

        public void refreshTable()
        {
            preencherTableConcluidos.Preencher(table_ServicosConcluidos, 1, 24);
        }

        public void MudarCores()
        {
            txtPesquisarConcluidos.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnPesquisarConcluidos.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //table_ServicosConcluidos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[0].BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void btnPesquisarConcluidos_Click(object sender, EventArgs e)
        {

        }

        private void naoConcluidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar a conclusão desse serviço?", "CANCELAR CONCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int idservico = int.Parse(table_ServicosConcluidos.SelectedCells[0].Value.ToString());
                ad.CancelarConclusaoServicos(idservico);
                refreshTable();
            }
        }

        private void txtPesquisarConcluidos_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarConcluidos.Text == "Digite o nome do cliente que deseja buscar os serviços")
            {
                txtPesquisarConcluidos.Text = "";
                txtPesquisarConcluidos.Font = new Font(txtPesquisarConcluidos.Font, FontStyle.Regular);
                txtPesquisarConcluidos.BorderColorIdle = Color.White;
                txtPesquisarConcluidos.ForeColor = Color.White;
            }
        }

        private void txtPesquisarConcluidos_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarConcluidos.Text == "")
            {
                txtPesquisarConcluidos.Text = "Digite o nome do cliente que deseja buscar os serviços";
                txtPesquisarConcluidos.Font = new Font(txtPesquisarConcluidos.Font, FontStyle.Italic);
                txtPesquisarConcluidos.ForeColor = Color.Silver;
                txtPesquisarConcluidos.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void naoConcluidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int idServico = Convert.ToInt32(table_ServicosConcluidos.SelectedCells[0].Value);
            DateTime Data = (DateTime)table_ServicosConcluidos.SelectedCells[2].Value;
            string NomeCliente = table_ServicosConcluidos.SelectedCells[3].Value.ToString();
            string Aparelho = table_ServicosConcluidos.SelectedCells[4].Value.ToString();
            string Defeito = table_ServicosConcluidos.SelectedCells[5].Value.ToString();

            form_Concluido_Desfazer desfazer = new form_Concluido_Desfazer(this, corGeral);
            desfazer.lblData.Text = String.Format("{0:d}", Data);
            desfazer.lblNomeCliente.Text = NomeCliente;
            desfazer.lblAparelho.Text = Aparelho;
            desfazer.lblDefeito.Text = Defeito;
            desfazer.lblIDServico.Text = idServico.ToString();
            desfazer.CentralizarLabels();
            desfazer.ShowDialog();
        }

        private void txtPesquisarConcluidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisarConcluidos.Text == "")
            {
                preencherTableConcluidos.Preencher(table_ServicosConcluidos, 1, 24);
                linhasExibidas = 24;
                paginaAtual = 1;
                lblResultadosExibidos.Text = Convert.ToString(24);
            }
            else
            {
                try
                {
                    preencherTableConcluidos.PreencherPorNomeCliente(table_ServicosConcluidos, txtPesquisarConcluidos.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
                    //mErr
                }
            }
        }

        private void menuVerGarantia_Click(object sender, EventArgs e)
        {
            form_VerGarantia verGarantia = new form_VerGarantia(corGeral);
            if (ve.VerificarExistenciaGarantia(Convert.ToInt32(table_ServicosConcluidos.SelectedCells[0].Value)))
            {
                verGarantia.lblIDServico.Text = table_ServicosConcluidos.SelectedCells[0].Value.ToString();
                verGarantia.lblNomeCliente.Text = table_ServicosConcluidos.SelectedCells[3].Value.ToString();
                verGarantia.lblAparelho.Text = table_ServicosConcluidos.SelectedCells[4].Value.ToString();
                verGarantia.lblServico.Text = table_ServicosConcluidos.SelectedCells[11].Value.ToString();
                verGarantia.lblSemGarantia.Visible = false;
                bd.BuscarDiasGarantia(verGarantia.lblDataInicial, verGarantia.lblDataFinal, verGarantia.lblDiasDeGarantia, Convert.ToInt32(verGarantia.lblIDServico.Text));
                bd.BuscarDiasFaltantesGarantia(verGarantia.lblDataInicial, verGarantia.lblDataFinal, verGarantia.lblDiasQueFaltam, Convert.ToInt32(verGarantia.lblIDServico.Text));
                verGarantia.CentralizarLabels();
                verGarantia.ShowDialog();
            }
            else
            {
                verGarantia.EsconderComponentes();
                verGarantia.lblSemGarantia.Visible = true;
                verGarantia.ShowDialog();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);
            editarServicos.lblIDservico.Text = table_ServicosConcluidos.SelectedCells[0].Value.ToString();
            editarServicos.dtpDataEdit.Value = Convert.ToDateTime(table_ServicosConcluidos.SelectedCells[2].Value.ToString());
            editarServicos.txtClienteNome.Text = table_ServicosConcluidos.SelectedCells[3].Value.ToString();
            editarServicos.txtAparelhoEdit.Text = table_ServicosConcluidos.SelectedCells[4].Value.ToString();
            editarServicos.txtDefeitoEdit.Text = table_ServicosConcluidos.SelectedCells[5].Value.ToString();
            editarServicos.txtSituacaoEdit.Text = table_ServicosConcluidos.SelectedCells[6].Value.ToString();
            editarServicos.txtServicoValorEdit.Text = table_ServicosConcluidos.SelectedCells[8].Value.ToString();
            editarServicos.txtPecaValorEdit.Text = table_ServicosConcluidos.SelectedCells[9].Value.ToString();
            editarServicos.txtLucroValorEdit.Text = table_ServicosConcluidos.SelectedCells[10].Value.ToString();
            editarServicos.btnConcluirServico.Visible = false;
            editarServicos.ShowDialog();
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            linhasExibidas += 24;
            paginaAtual += 1;

            if (linhasExibidas < Convert.ToInt32(lblResultadosTotais.Text)+24)
            {
                btnArrowRight.Enabled = false;
                btnArrowRight.IconColor = Color.Gray;
                preencherTableConcluidos.Preencher(table_ServicosConcluidos, paginaAtual, 24);
                table_ServicosConcluidos.Update();
                table_ServicosConcluidos.Refresh();
                //btnArrowRight.Enabled = false;
                atualizarLinhasExibidas();
            }
            else
            {
                linhasExibidas = Convert.ToInt32(lblResultadosTotais.Text);
                atualizarLinhasExibidas();
            }
            btnArrowRight.Enabled = true;
            btnArrowRight.IconColor = Color.White;
        }

        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            linhasExibidas -= 24;
            paginaAtual -= 1;
            if (linhasExibidas < 24) { linhasExibidas = 24; }
            else
            {
                preencherTableConcluidos.Preencher(table_ServicosConcluidos, paginaAtual, 24);
                table_ServicosConcluidos.Update();
                table_ServicosConcluidos.Refresh();
            }
            atualizarLinhasExibidas();
        }

        private void horizontalSlider_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            //preencherTableConcluidos.Preencher(table_ServicosConcluidos, horizontalSlider.Value, 24);
        }

        private void table_ServicosConcluidos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // MessageBox.Show("Teste");
            //btnArrowRight.Enabled = true;
        }
    }
}
