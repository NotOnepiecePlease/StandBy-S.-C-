using Bunifu.UI.WinForms;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.PreencherComponentes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Models;
using static PFC___StandBy_CSharp.Enum.Enum;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_DiaEntrega : Form
    {
        private form_OrdensServ formServ1;
        private form_OrdemServicoEntrada formOrdemServico;
        private InserirDados id = new InserirDados();
        private BuscarDados bd = new BuscarDados();
        private AlterarDados ad = new AlterarDados();
        private MensagensErro me = new MensagensErro();
        private MensagensSucesso ms = new MensagensSucesso();
        private PreencherTableOrdensServicos preencherTableServ = new PreencherTableOrdensServicos();
        private Image imagemSenhaPatternDoCliente = null;
        private ClienteEstrutura clienteDados;
        private ServicoEstrutura servicoDados;
        private ChecklistEstrutura checklistDados;
        private CondicoesFisicasEstrutura condicoesFisicasDados;
        private int[] corGeral;
        private OrdemServico ordemServico;

        public form_DiaEntrega(form_OrdensServ _formServ, int[] _cor)
        {
            InitializeComponent();
            corGeral = _cor;
            formServ1 = _formServ;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="_formServ">Instancia do form_OrdemServico</param>
        /// <param name="_cor">Passagem de cores do form principal, em R - G - B  (255,255,255)</param>
        /// <param name="_clienteDados">Dados do cliente</param>
        /// <param name="_servicoDados">Dados do servico</param>
        /// <param name="_checklistDados">Dados do checklist</param>
        /// <param name="_condicoesFisicasDados">Dados das condicoes fisicas</param>
        /// <param name="_isAtualizacao">true = se o form for pra atualizar dados que ja existem | false = se o form for pra inserir dados que ainda nao existem</param>
        public form_DiaEntrega(form_OrdemServicoEntrada _formServ, int[] _cor, ClienteEstrutura _clienteDados, ServicoEstrutura _servicoDados, ChecklistEstrutura _checklistDados, CondicoesFisicasEstrutura _condicoesFisicasDados, OrdemServico _tipo)
        {
            InitializeComponent();
            ordemServico = _tipo;
            corGeral = _cor;
            formOrdemServico = _formServ;
            clienteDados = _clienteDados;
            servicoDados = _servicoDados;
            checklistDados = _checklistDados;
            condicoesFisicasDados = _condicoesFisicasDados;
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

        private byte[] ConvertImageToByte(Image img)
        {
            if (imagemSenhaPatternDoCliente != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    img.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                return new byte[] { 0 };
            }
        }

        public void InserirServico(int _diasParaEntrega, int _seExistePrazo)
        {
            try
            {
                imagemSenhaPatternDoCliente = GetCopyImage(@"./PasswordPattern/Screen.png");
                var dir = new DirectoryInfo(@"./PasswordPattern/");
                var files = dir.GetFiles().FirstOrDefault();
                files?.Delete();
            }
            catch (Exception)
            {
                // ignored
            }

            DateTime previsaoEntrega = DateTime.Now;
            previsaoEntrega = previsaoEntrega.AddDays(_diasParaEntrega);

            servicoDados.PrevisaoEntrega = previsaoEntrega;
            servicoDados.ExistePrazo = _seExistePrazo;
            servicoDados.SenhaPatternAndroid = ConvertImageToByte(imagemSenhaPatternDoCliente);

            if (ordemServico == OrdemServico.AtualizarTudo)
            {
                ad.AtualizarOS(clienteDados, servicoDados);

                //TEM Q TERMINAR AQUI
                ad.AtualizarCheckList(servicoDados.ID, checklistDados);

                ad.AtualizarCondicoesFisicas(servicoDados.ID, condicoesFisicasDados);

                ms.AlterarServicoSucesso();
            }
            else if (ordemServico == OrdemServico.NovaInsercao)
            {
                //Inserir a OS e pegar a ID do serv que ele acabou de inserir
                int idUltimoServico = id.InserirOS(clienteDados, servicoDados);

                //-1 = Servico nao foi inserido
                if (idUltimoServico != -1)
                {
                    //Inserir o checklist
                    id.InserirCheckList(idUltimoServico, checklistDados);

                    //inserir as Condicoes fisicas
                    id.InserirCondicoesFisicas(idUltimoServico, condicoesFisicasDados);

                    ////Mensagem de Conclusao
                    ms.InserirServicoSucesso();
                }
            }
            else if (ordemServico == OrdemServico.ExisteApenasServico)
            {
                ad.AtualizarOS(clienteDados, servicoDados);
                //Inserir o checklist
                id.InserirCheckList(servicoDados.ID ?? 0, checklistDados);

                //inserir as Condicoes fisicas
                id.InserirCondicoesFisicas(servicoDados.ID ?? 0, condicoesFisicasDados);

                ////Mensagem de Conclusao
                ms.InserirServicoSucesso();
            }

            this.Close();

            #region Metodo antigo de insercao (tela antiga)

            //if (formServ1.txtAparelhoOrdens.Text.Equals("Modelo do aparelho") || string.IsNullOrWhiteSpace(formServ1.txtAparelhoOrdens.Text))
            //{
            //    MessageBox.Show(@"Voce esqueceu de digitar o nome do Aparelho", "ALERTA!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    try
            //    {
            //        //Pego a ID do cliente no banco de dados pelo nome dele na combobox.
            //        //int _idCliente = bd.BuscarIdCliente(formServ1.cmbClientes.SelectedItem.ToString());
            //        int _idCliente = Convert.ToInt32(formServ1.lblIdCliente.Text);
            //        //Pego a data de hoje.
            //        DateTime data = DateTime.Now;

            //        try
            //        {
            //            imagemSenhaPatternDoCliente = GetCopyImage(@"./PasswordPattern/Screen.png");
            //            var dir = new DirectoryInfo(@"./PasswordPattern/");
            //            var files = dir.GetFiles().FirstOrDefault();
            //            files?.Delete();
            //        }
            //        catch (Exception)
            //        {
            //            // ignored
            //        }

            //inserirImage(ConvertImageToByte(imagemSenhaPatternDoCliente));

            //        //Insiro o servico com os dados.
            //        string senha;
            //        string acessorios;
            //        if (formServ1.txtSenhaOrdens.Text.Equals("Digite a senha do celular"))
            //        {
            //            senha = "------------";
            //        }
            //        else
            //        {
            //            senha = formServ1.txtSenhaOrdens.Text;
            //        }

            //        if (formServ1.txtAcessoriosOrdens.Text.Equals("Acessorios que vieram junto c/ aparelho"))
            //        {
            //            acessorios = "------------";
            //        }
            //        else
            //        {
            //            acessorios = formServ1.txtAcessoriosOrdens.Text;
            //        }

            //        string situacaoAparelho = (formServ1.txtSituacaoOrdens.Text == "Situação do aparelho") ? "" : formServ1.txtSituacaoOrdens.Text;
            //        id.InserirServico(data, _idCliente, formServ1.txtAparelhoOrdens.Text, formServ1.txtDefeitoOrdens.Text, senha, situacaoAparelho, _diasParaEntrega, _seExistePrazo, ConvertImageToByte(imagemSenhaPatternDoCliente), acessorios);

            //        //Abrir tela de edição após o cadastro
            //        int idUltimoServicoAdicionado = bd.BuscarIdUltimoServicoAdicionado();
            //        List<object> dados = new List<object>();

            //        dados = bd.BuscarServicoPorID(idUltimoServicoAdicionado);
            //        EditarUmServicoPelaID(dados);

            //        //if (formServ1.txtSenhaOrdens.Text.Equals("Digite a senha do celular"))
            //        //{
            //        //    id.InserirServico(data, _idCliente, formServ1.txtAparelhoOrdens.Text, formServ1.txtDefeitoOrdens.Text, senha, formServ1.txtSituacaoOrdens.Text, _diasParaEntrega, _seExistePrazo, ConvertImageToByte(imagemSenhaPatternDoCliente));
            //        //}
            //        //else
            //        //{
            //        //    id.InserirServico(data, _idCliente, formServ1.txtAparelhoOrdens.Text, formServ1.txtDefeitoOrdens.Text, formServ1.txtSenhaOrdens.Text, formServ1.txtSituacaoOrdens.Text, _diasParaEntrega, _seExistePrazo, ConvertImageToByte(imagemSenhaPatternDoCliente));
            //        //}

            //        //Reseto os campos.
            //        ResetarCamposDeCadastro();

            //        //Mensagem de Conclusao
            //        ms.InserirServicoSucesso();

            //        //Atualizo a tabela
            //        preencherTableServ.Preencher(formServ1.table_OrdensServicos);
            //        preencherTableServ.Preencher(formServ1.table_OrdensServicos);
            //    }
            //    catch (Exception ex)
            //    {
            //        //Mensagem de Erro
            //        me.ErroInserirServico(ex);
            //    }
            //}
            //this.Close();

            #endregion Metodo antigo de insercao (tela antiga)
        }

        public void ResetarCamposDeCadastro()
        {
            formServ1.txtAparelhoOrdens.Text = "Modelo do aparelho";
            formServ1.txtAparelhoOrdens.Font = new Font(formServ1.txtAparelhoOrdens.Font, FontStyle.Italic);
            formServ1.txtAparelhoOrdens.ForeColor = Color.Silver;
            formServ1.txtAparelhoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            formServ1.txtDefeitoOrdens.Text = "Digite o defeito";
            formServ1.txtDefeitoOrdens.Font = new Font(formServ1.txtDefeitoOrdens.Font, FontStyle.Italic);
            formServ1.txtDefeitoOrdens.ForeColor = Color.Silver;
            formServ1.txtDefeitoOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            formServ1.txtSenhaOrdens.Text = "Digite a senha do celular";
            formServ1.txtSenhaOrdens.Font = new Font(formServ1.txtSenhaOrdens.Font, FontStyle.Italic);
            formServ1.txtSenhaOrdens.ForeColor = Color.Silver;
            formServ1.txtSenhaOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            //formServ1.txtSituacaoOrdens.Text = "";
            formServ1.txtAcessoriosOrdens.Text = "Vieram junto c/ aparelho";
            formServ1.txtAcessoriosOrdens.Font = new Font(formServ1.txtAcessoriosOrdens.Font, FontStyle.Italic);
            formServ1.txtAcessoriosOrdens.ForeColor = Color.Silver;
            formServ1.txtAcessoriosOrdens.LineIdleColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        public void EditarUmServicoPelaID(List<object> dados)
        {
            try
            {
                form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(this, corGeral);

                string _TELCliente = bd.BuscarTelefoneCliente(Convert.ToInt32(dados[1]));
                string _TEL_RECCliente = bd.BuscarTelefoneRecadoCliente(Convert.ToInt32(dados[1]));
                float lucro = float.Parse(dados[10].ToString());
                try
                {
                    string _CPFCliente = bd.BuscarCPFCliente(Convert.ToInt32(dados[1]));
                    editarServicos.txtCPFCliente.Text = _CPFCliente;
                    editarServicos.txtAcessoriosEdit.Text = dados[14].ToString();
                }
                catch
                {
                    // ignored
                }

                editarServicos.lblIDservico.Text = dados[0].ToString();
                editarServicos.lblIDcliente.Text = dados[1].ToString();
                editarServicos.dtpDataEdit.Value = Convert.ToDateTime(dados[2].ToString());
                editarServicos.lblClienteNome.Text = dados[3].ToString();
                editarServicos.txtClienteNome.Text = dados[3].ToString();

                editarServicos.txtTelefoneCliente.Text = _TELCliente;
                editarServicos.txtTelefoneRecado.Text = _TEL_RECCliente;
                editarServicos.txtAparelhoEdit.Text = dados[4].ToString();
                editarServicos.txtDefeitoEdit.Text = dados[5].ToString();
                editarServicos.txtSenhaEdit.Text = dados[7].ToString();
                editarServicos.txtSituacaoEdit.Text = dados[6].ToString();

                editarServicos.txtServicoValorEdit.Text = dados[8].ToString();
                editarServicos.txtPecaValorEdit.Text = dados[9].ToString();
                editarServicos.txtLucroValorEdit.Text = dados[10].ToString();
                editarServicos.txtServicoEdit.Text = dados[11].ToString();
                if (dados[12] == DBNull.Value)
                {
                    //MessageBox.Show("Sem data");
                    editarServicos.dtpDataEditPrevisao.FormatCustom = " ";
                    editarServicos.dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
                    editarServicos.chkSemData.Checked = true;
                }
                else
                {
                    editarServicos.dtpDataEditPrevisao.Value = Convert.ToDateTime(dados[12].ToString());
                    editarServicos.chkSemData.Checked = false;
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
            catch (Exception ex)
            {
                me.ErroAoAbrirTelaDeEdicaoServicos(ex);
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
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