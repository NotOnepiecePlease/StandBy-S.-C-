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
        PreencherTableConcluidos preencherTable = new PreencherTableConcluidos();
        AlterarDados ad = new AlterarDados();
        BuscarDados bd = new BuscarDados();
        VerificarExistencia ve = new VerificarExistencia();
        int[] corGeral = new int[3] { 0, 0, 0 };
        public form_Concluidos(int[] corGeral)
        {
            InitializeComponent();
            preencherTable.Preencher(table_ServicosConcluidos);
            this.corGeral = corGeral;
            MudarCores();
        }

        public void refreshTable()
        {
            preencherTable.Preencher(table_ServicosConcluidos);
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
            //DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar a conclusão do serviço abaixo?\n\n" +
            //    "Data: "+String.Format("{0:d}",Data)+"\n" +
            //    "Cliente: "+NomeCliente+"\n" +
            //    "Aparelho: "+Aparelho+"\n" +
            //    "Defeito: "+Defeito+"\n" +
            //    "Situação: "+Situacao+"\n", "CANCELAR CONCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (resultado == DialogResult.Yes)
            //{
            //    int idservico = int.Parse(table_ServicosConcluidos.SelectedCells[0].Value.ToString());
            //    ad.CancelarConclusaoServicos(idservico);
            //    refreshTable();
            //}
        }

        private void txtPesquisarConcluidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisarConcluidos.Text == "")
            {
                preencherTable.Preencher(table_ServicosConcluidos);
            }
            else
            {
                try
                {
                    preencherTable.PreencherPorNomeCliente(table_ServicosConcluidos, txtPesquisarConcluidos.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
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
                bd.BuscarDiasGarantia(verGarantia.lblDataInicial, verGarantia.lblDataFinal, verGarantia.lblDiasRestantes, Convert.ToInt32(verGarantia.lblIDServico.Text));
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
    }
}
