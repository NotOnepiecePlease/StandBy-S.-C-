using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.PreencherComponentes;
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
    public partial class form_OrdensServ : Form
    {

        BuscarDados bd = new BuscarDados();
        InserirDados id = new InserirDados();
        AlterarDados ad = new AlterarDados();
        DeletarDados dd = new DeletarDados();
        PreencherComboBoxCliente pc = new PreencherComboBoxCliente();
        MensagensErro me = new MensagensErro();
        MensagensSucesso ms = new MensagensSucesso();
        PreencherTableOrdensServicos preencherTableServ = new PreencherTableOrdensServicos();
        int[] corGeral = new int[3] { 0, 0, 0 };
        public form_OrdensServ(int[] corRGB)
        {
            InitializeComponent();
            preencherTableServ.Preencher(table_OrdensServicos);
            pc.Preencher(cmbClientes);
            corGeral = corRGB;
            MudarTodasCores();
            //cmbClientes.SelectedIndex = 0;
            cmbClientes.SelectedIndex = cmbClientes.Items.Count - 1;
        }

        public void MudarTodasCores()
        {
            btnCadastrarOrdem.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnPesquisarCliente.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtSituacaoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPesquisarCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //table_OrdensServicos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //cmbClientes.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            contextMenuStrip1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        public void refreshTable()
        {
            preencherTableServ.Preencher(table_OrdensServicos);
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                preencherTableServ.PreencherServicosPorNomeCliente(table_OrdensServicos, txtPesquisarCliente.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex + "");
            }
        }

        private void btnCadastrarOrdem_Click(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            {
                MessageBox.Show("Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Pego a ID do cliente no banco de dados pelo nome dele na combobox.
                int _idCliente = bd.BuscarIdCliente(cmbClientes.SelectedItem.ToString());
                //Pego a data de hoje.
                DateTime data = DateTime.Now;

                try
                {
                    //Insiro o servico com os dados.
                    if (txtSenhaOrdens.Text.Equals("Digite a senha do celular"))
                    {
                        id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, "------------", txtSituacaoOrdens.Text);
                    }
                    else
                    {
                        id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, txtSenhaOrdens.Text, txtSituacaoOrdens.Text);
                    }


                    //Reseto os campos.
                    txtAparelhoOrdens.Text = "";
                    txtDefeitoOrdens.Text = "";
                    txtSenhaOrdens.Text = "";
                    txtSituacaoOrdens.Text = "";

                    //Mensagem de Conclusao
                    ms.InserirServicoSucesso();

                    //Atualizo a tabela
                    preencherTableServ.Preencher(table_OrdensServicos);
                }
                catch (Exception ex)
                {
                    //Mensagem de Erro
                    me.ErroInserirServico(ex);
                }
            }
        }

        private void txtAparelhoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text == "Modelo do aparelho")
            {
                txtAparelhoOrdens.Text = "";
                txtAparelhoOrdens.Font = new Font(txtAparelhoOrdens.Font, FontStyle.Regular);
                txtAparelhoOrdens.LineIdleColor = Color.White;
                txtAparelhoOrdens.ForeColor = Color.White;
            }
        }

        private void txtAparelhoOrdens_Leave(object sender, EventArgs e)
        {
            if (txtAparelhoOrdens.Text == "" || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            {
                txtAparelhoOrdens.Text = "Modelo do aparelho";
                txtAparelhoOrdens.Font = new Font(txtAparelhoOrdens.Font, FontStyle.Italic);
                txtAparelhoOrdens.ForeColor = Color.Silver;
                txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtDefeitoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtDefeitoOrdens.Text == "Digite o defeito")
            {
                txtDefeitoOrdens.Text = "";
                txtDefeitoOrdens.Font = new Font(txtDefeitoOrdens.Font, FontStyle.Regular);
                txtDefeitoOrdens.LineIdleColor = Color.White;
                txtDefeitoOrdens.ForeColor = Color.White;
            }
        }

        private void txtDefeitoOrdens_Leave(object sender, EventArgs e)
        {
            if (txtDefeitoOrdens.Text == "" || string.IsNullOrWhiteSpace(txtDefeitoOrdens.Text))
            {
                txtDefeitoOrdens.Text = "Digite o defeito";
                txtDefeitoOrdens.Font = new Font(txtDefeitoOrdens.Font, FontStyle.Italic);
                txtDefeitoOrdens.ForeColor = Color.Silver;
                txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                //txtDefeitoOrdens.LineIdleColor = Color.White;
            }
        }

        private void txtSenhaOrdens_Enter(object sender, EventArgs e)
        {
            if (txtSenhaOrdens.Text == "Digite a senha do celular")
            {
                txtSenhaOrdens.Text = "";
                txtSenhaOrdens.Font = new Font(txtSenhaOrdens.Font, FontStyle.Regular);
                txtSenhaOrdens.LineIdleColor = Color.White;
                txtSenhaOrdens.ForeColor = Color.White;
            }
        }

        private void txtSenhaOrdens_Leave(object sender, EventArgs e)
        {
            if (txtSenhaOrdens.Text == "" || string.IsNullOrWhiteSpace(txtSenhaOrdens.Text))
            {
                txtSenhaOrdens.Text = "Digite a senha do celular";
                txtSenhaOrdens.Font = new Font(txtSenhaOrdens.Font, FontStyle.Italic);
                txtSenhaOrdens.ForeColor = Color.Silver;
                txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtSituacaoOrdens_Enter(object sender, EventArgs e)
        {
            if (txtSituacaoOrdens.Text == "Situação do aparelho")
            {
                txtSituacaoOrdens.Text = "";
                txtSituacaoOrdens.Font = new Font(txtSituacaoOrdens.Font, FontStyle.Regular);
                txtSituacaoOrdens.LineIdleColor = Color.White;
                txtSituacaoOrdens.ForeColor = Color.White;
            }
        }

        private void txtSituacaoOrdens_Leave(object sender, EventArgs e)
        {
            if (txtSituacaoOrdens.Text == "" || string.IsNullOrWhiteSpace(txtSituacaoOrdens.Text))
            {
                txtSituacaoOrdens.Text = "Situação do aparelho";
                txtSituacaoOrdens.Font = new Font(txtSituacaoOrdens.Font, FontStyle.Italic);
                txtSituacaoOrdens.ForeColor = Color.Silver;
                txtSituacaoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtPesquisarCliente_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarCliente.Text == "Digite o nome do cliente que deseja buscar os serviços")
            {
                txtPesquisarCliente.Text = "";
                txtPesquisarCliente.Font = new Font(txtPesquisarCliente.Font, FontStyle.Regular);
                txtPesquisarCliente.BorderColorIdle = Color.White;
                txtPesquisarCliente.ForeColor = Color.White;
            }
        }

        private void txtPesquisarCliente_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarCliente.Text == "" || string.IsNullOrWhiteSpace(txtPesquisarCliente.Text))
            {
                txtPesquisarCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
                txtPesquisarCliente.Font = new Font(txtSituacaoOrdens.Font, FontStyle.Italic);
                txtPesquisarCliente.ForeColor = Color.Silver;
                txtPesquisarCliente.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            }
        }

        private void txtPesquisarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisarCliente.Text == "")
            {
                preencherTableServ.Preencher(table_OrdensServicos);
            }
            else
            {
                try
                {
                    preencherTableServ.PreencherServicosPorNomeCliente(table_OrdensServicos, txtPesquisarCliente.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
                }
            }
        }

        private void table_OrdensServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void table_OrdensServicos_DoubleClick(object sender, EventArgs e)
        {
            float lucro = float.Parse(table_OrdensServicos.SelectedCells[10].Value.ToString());
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);
            editarServicos.lblIDservico.Text = table_OrdensServicos.SelectedCells[0].Value.ToString();
            editarServicos.lblIDcliente.Text = table_OrdensServicos.SelectedCells[1].Value.ToString();
            editarServicos.dtpDataEdit.Value = Convert.ToDateTime(table_OrdensServicos.SelectedCells[2].Value.ToString());
            editarServicos.lblClienteNome.Text = table_OrdensServicos.SelectedCells[3].Value.ToString();
            editarServicos.txtAparelhoEdit.Text = table_OrdensServicos.SelectedCells[4].Value.ToString();
            editarServicos.txtDefeitoEdit.Text = table_OrdensServicos.SelectedCells[5].Value.ToString();
            editarServicos.txtSenhaEdit.Text = table_OrdensServicos.SelectedCells[7].Value.ToString();
            editarServicos.txtSituacaoEdit.Text = table_OrdensServicos.SelectedCells[6].Value.ToString();
            editarServicos.txtServicoValorEdit.Text = table_OrdensServicos.SelectedCells[8].Value.ToString();
            editarServicos.txtPecaValorEdit.Text = table_OrdensServicos.SelectedCells[9].Value.ToString();
            editarServicos.txtLucroValorEdit.Text = table_OrdensServicos.SelectedCells[10].Value.ToString();
            editarServicos.txtServicoEdit.Text = table_OrdensServicos.SelectedCells[11].Value.ToString();

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

            editarServicos.ShowDialog(this);
            table_OrdensServicos.Refresh();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float lucro = float.Parse(table_OrdensServicos.SelectedCells[10].Value.ToString());
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);
            editarServicos.lblIDservico.Text = table_OrdensServicos.SelectedCells[0].Value.ToString();
            editarServicos.lblIDcliente.Text = table_OrdensServicos.SelectedCells[1].Value.ToString();
            editarServicos.dtpDataEdit.Value = Convert.ToDateTime(table_OrdensServicos.SelectedCells[2].Value.ToString());
            editarServicos.lblClienteNome.Text = table_OrdensServicos.SelectedCells[3].Value.ToString();
            editarServicos.txtAparelhoEdit.Text = table_OrdensServicos.SelectedCells[4].Value.ToString();
            editarServicos.txtDefeitoEdit.Text = table_OrdensServicos.SelectedCells[5].Value.ToString();
            editarServicos.txtSenhaEdit.Text = table_OrdensServicos.SelectedCells[7].Value.ToString();
            editarServicos.txtSituacaoEdit.Text = table_OrdensServicos.SelectedCells[6].Value.ToString();
            editarServicos.txtServicoValorEdit.Text = table_OrdensServicos.SelectedCells[8].Value.ToString();
            editarServicos.txtPecaValorEdit.Text = table_OrdensServicos.SelectedCells[9].Value.ToString();
            editarServicos.txtLucroValorEdit.Text = table_OrdensServicos.SelectedCells[10].Value.ToString();
            editarServicos.txtServicoEdit.Text = table_OrdensServicos.SelectedCells[11].Value.ToString();

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
            table_OrdensServicos.Refresh();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja deletar esse serviço?", "DELETAR SERVIÇO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int _idServico = int.Parse(table_OrdensServicos.SelectedCells[0].Value.ToString());
                dd.DeletarServico(_idServico);
                refreshTable();
            }
        }

        private void txtAparelhoOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtDefeitoOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtSenhaOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        private void txtSituacaoOrdens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarServicoNovo();
            }
        }

        public void CadastrarServicoNovo()
        {
            if (txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(txtAparelhoOrdens.Text))
            {
                MessageBox.Show("Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Pego a ID do cliente no banco de dados pelo nome dele na combobox.
                int _idCliente = bd.BuscarIdCliente(cmbClientes.SelectedItem.ToString());
                //Pego a data de hoje.
                DateTime data = DateTime.Now;

                try
                {
                    //Insiro o servico com os dados.
                    if (txtSenhaOrdens.Text.Equals("Digite a senha do celular") || string.IsNullOrWhiteSpace(txtSenhaOrdens.Text))
                    {
                        id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, "------------", txtSituacaoOrdens.Text);
                    }
                    else
                    {
                        id.InserirServico(data, _idCliente, txtAparelhoOrdens.Text, txtDefeitoOrdens.Text, txtSenhaOrdens.Text, txtSituacaoOrdens.Text);
                    }

                    //Reseto os campos.
                    txtAparelhoOrdens.Text = "";
                    txtDefeitoOrdens.Text = "";
                    txtSenhaOrdens.Text = "";
                    txtSituacaoOrdens.Text = "";

                    //Mensagem de Conclusao
                    ms.InserirServicoSucesso();

                    //Atualizo a tabela
                    preencherTableServ.Preencher(table_OrdensServicos);
                }
                catch (Exception ex)
                {
                    //Mensagem de Erro
                    me.ErroInserirServico(ex);
                }
            }
        }
    }
}
