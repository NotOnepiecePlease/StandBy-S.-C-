using Bunifu.UI.WinForms;
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
    public partial class form_DiaEntrega : Form
    {
        form_OrdensServ formServ1;
        int[] corGeral = new int[] { 0, 0, 0 };
        InserirDados id = new InserirDados();
        BuscarDados bd = new BuscarDados();
        MensagensErro me = new MensagensErro();
        MensagensSucesso ms = new MensagensSucesso();
        PreencherTableOrdensServicos preencherTableServ = new PreencherTableOrdensServicos();
        public form_DiaEntrega(form_OrdensServ _formServ, int[] _cor)
        {
            InitializeComponent();
            corGeral = _cor;
            formServ1 = _formServ;
            
        }

        public void MudarCores()
        {
            BunifuCheckBox[] checkboxes = new BunifuCheckBox[] { chk0d, chk1d, chk2d, chk3d, chk4d, chk5d, chk7d };

            for (int i = 0; i < 7; i++)
            {
                checkboxes[i].OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                checkboxes[i].OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                checkboxes[i].OnUncheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                checkboxes[i].OnHoverChecked.BorderColor = Color.Gray;
                checkboxes[i].OnHoverChecked.CheckBoxColor = Color.Gray;
                checkboxes[i].OnHoverUnchecked.BorderColor = Color.Gray;
                checkboxes[i].Checked = false;
            }
            chk0d.Checked = true;

            btnConfirmarPrevisaoEntrega.IdleBorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnConfirmarPrevisaoEntrega.IdleFillColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnClose.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //chk0d.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk0d.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk0d.OnUncheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //chk1d.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk1d.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk1d.OnUncheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk1d.Checked = false;

            //chk2d.OnCheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk2d.OnCheck.CheckBoxColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk2d.OnUncheck.BorderColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //chk2d.Checked = false;
        }

        private void btnConfirmarPrevisaoEntrega_Click(object sender, EventArgs e)
        {
            VerificarBoxInserirServico();
        }

        public void VerificarBoxInserirServico()
        {
            if (chk0d.Checked)
            {
                InserirServico(0, 0);
            }
            else if (chk1d.Checked)
            {
                InserirServico(1, 1);
            }
            else if (chk2d.Checked)
            {
                InserirServico(2, 1);
            }
            else if (chk3d.Checked)
            {
                InserirServico(3, 1);
            }
            else if (chk4d.Checked)
            {
                InserirServico(4, 1);
            }
            else if (chk5d.Checked)
            {
                InserirServico(5, 1);
            }
            else if (chk7d.Checked)
            {
                InserirServico(7, 1);
            }
            else
            {
                MessageBox.Show("Voce precisa marcar uma opção ou pressione ESC para voltar.");
            }
        }
        public void InserirServico(int PrevisaoEntrega, int SeExistePrazo)
        {

            if (formServ1.txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(formServ1.txtAparelhoOrdens.Text))
            {
                MessageBox.Show("Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Pego a ID do cliente no banco de dados pelo nome dele na combobox.
                int _idCliente = bd.BuscarIdCliente(formServ1.cmbClientes.SelectedItem.ToString());
                //Pego a data de hoje.
                DateTime data = DateTime.Now;

                try
                {
                    //Insiro o servico com os dados.
                    if (formServ1.txtSenhaOrdens.Text.Equals("Digite a senha do celular"))
                    {
                        id.InserirServico(data, _idCliente, formServ1.txtAparelhoOrdens.Text, formServ1.txtDefeitoOrdens.Text, "------------", formServ1.txtSituacaoOrdens.Text, PrevisaoEntrega, SeExistePrazo);
                    }
                    else
                    {
                        id.InserirServico(data, _idCliente, formServ1.txtAparelhoOrdens.Text, formServ1.txtDefeitoOrdens.Text, formServ1.txtSenhaOrdens.Text, formServ1.txtSituacaoOrdens.Text, PrevisaoEntrega, SeExistePrazo);
                    }


                    //Reseto os campos.
                    formServ1.txtAparelhoOrdens.Text = "";
                    formServ1.txtDefeitoOrdens.Text = "";
                    formServ1.txtSenhaOrdens.Text = "";
                    formServ1.txtSituacaoOrdens.Text = "";

                    //Mensagem de Conclusao
                    ms.InserirServicoSucesso();

                    //Atualizo a tabela
                    preencherTableServ.Preencher(formServ1.table_OrdensServicos);
                }
                catch (Exception ex)
                {
                    //Mensagem de Erro
                    me.ErroInserirServico(ex);
                }
            }
            this.Close();
        }
        private void form_DiaEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void chk1d_Click(object sender, EventArgs e)
        {
            chk0d.Checked = false;
            chk2d.Checked = false;
            chk3d.Checked = false;
            chk4d.Checked = false;
            chk5d.Checked = false;
            chk7d.Checked = false;
        }

        private void chk2d_Click(object sender, EventArgs e)
        {
            chk0d.Checked = false;
            chk1d.Checked = false;
            chk3d.Checked = false;
            chk4d.Checked = false;
            chk5d.Checked = false;
            chk7d.Checked = false;
        }

        private void chk3d_Click(object sender, EventArgs e)
        {
            chk0d.Checked = false;
            chk1d.Checked = false;
            chk2d.Checked = false;
            chk4d.Checked = false;
            chk5d.Checked = false;
            chk7d.Checked = false;
        }

        private void chk4d_Click(object sender, EventArgs e)
        {
            chk0d.Checked = false;
            chk1d.Checked = false;
            chk2d.Checked = false;
            chk3d.Checked = false;
            chk5d.Checked = false;
            chk7d.Checked = false;
        }

        private void chk5d_Click(object sender, EventArgs e)
        {
            chk0d.Checked = false;
            chk1d.Checked = false;
            chk2d.Checked = false;
            chk3d.Checked = false;
            chk4d.Checked = false;
            chk7d.Checked = false;
        }

        private void chk7d_Click(object sender, EventArgs e)
        {
            chk0d.Checked = false;
            chk1d.Checked = false;
            chk2d.Checked = false;
            chk3d.Checked = false;
            chk4d.Checked = false;
            chk5d.Checked = false;
        }

        private void chk0d_Click(object sender, EventArgs e)
        {
            chk1d.Checked = false;
            chk2d.Checked = false;
            chk3d.Checked = false;
            chk4d.Checked = false;
            chk5d.Checked = false;
            chk7d.Checked = false;
        }

        private void form_DiaEntrega_Load(object sender, EventArgs e)
        {
            MudarCores();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
