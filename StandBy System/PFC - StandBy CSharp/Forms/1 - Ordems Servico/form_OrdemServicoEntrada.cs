using DevExpress.XtraPrinting;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Impressao;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.PreencherComponentes;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_6___Usada_por_Varias_Telas;
using PFC___StandBy_CSharp.Utils;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using BunifuDropdown = Bunifu.UI.WinForms.BunifuDropdown;
using ConvertImage = PFC___StandBy_CSharp.Utils.ConvertImage;
using static PFC___StandBy_CSharp.Enums.EnumStandby;

namespace PFC___StandBy_CSharp.Forms
{
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
    public partial class form_OrdemServicoEntrada : Form
    {
        private MensagensErro mErro = new MensagensErro();
        private standby_orgContext context = new standby_orgContext();
        private BuscarDados buscarDados = new BuscarDados();
        private VerificarExistencia verifExistencia = new VerificarExistencia();
        private List<ClienteEstrutura> listClientesComId = new List<ClienteEstrutura>();
        private MensagensSucesso msgSucess = new MensagensSucesso();
        private readonly PreencherComboBoxCliente preencherCombobox = new PreencherComboBoxCliente();
        private int ultimoClienteAdicionadoID = 0;
        private int ultimaOrdemServicoID = 0;
        private DataTable dt;
        private Aparelho tipoAparelhoGlobal;
        private int[] corGeral = new[] { 0, 0, 0 };
        private bool isNovaOrdemServico = false;

        public form_OrdemServicoEntrada(Aparelho _tipoAparelhoGlobal, int _idClientePreSetado, bool _isNovaOrdemServico,
            int[] _corGeral)
        {
            InitializeComponent();
            corGeral = _corGeral;
            isNovaOrdemServico = _isNovaOrdemServico;
            //txtChecklistMotivoAusencia.BackColor = Color.FromArgb(64, 64, 64);
            //txtChecklistMotivoAusencia.ReadOnly = true;
            SetarCores();
            CarregarComboxClientes();
            if (_isNovaOrdemServico == true)
            {
                //Se o form for chamado em modo de "Nova ordem de servico"
                //entao vai ter q ser gerada uma nova OS e seto o ultimo cliente adicionado
                GerarNovaOrdemServico();
                SetarComboboxComUltimoClienteAdicionado(dt, ultimoClienteAdicionadoID);
            }
            else
            {
                //Caso seja o form em modo de atualizacao de uma OS q existe, entao seto o cliente
                //responsavel pelo servico.
                SetarComboboxComUltimoClienteAdicionado(dt, _idClientePreSetado);
                cmbCliente.Enabled = true;
            }

            //ZerarTodosCampos();
            InicializarDatas();
            tipoAparelhoGlobal = _tipoAparelhoGlobal;
            cmbStatusServico.SelectedItem = "AVALIAÇÃO";

            string tipoAparelho = System.Enum.GetName(typeof(Aparelho), (int)tipoAparelhoGlobal);
            btnTipoAparelho.ImageOptions.SvgImage = svgCollection[tipoAparelho];
        }

        private void form_OrdemServicoEntrada_Shown(object sender, EventArgs e)
        {
            InicializarOpcoesCombobox();
        }

        private void InicializarOpcoesCombobox()
        {
            DesabilitarOpcoesDeAcordoTipoAparelho();
            PreencherComboboxServicos p = new PreencherComboboxServicos();
            //checklist
            p.PreencherInfoChecklist(this);
            //info aparelho
            p.PreencherInfoAparelho(this);
            //cond fisicas
            p.PreencherInfoCondFisicas(this);
        }

        private void DesabilitarOpcoesDeAcordoTipoAparelho()
        {
            if (tipoAparelhoGlobal == Aparelho.Computador || tipoAparelhoGlobal == Aparelho.Notebook)
            {
                foreach (var control in group_CondicoesFisicas.Controls)
                {
                    if (control is BunifuDropdown)
                    {
                        var controle = (BunifuDropdown)control;
                        controle.Enabled = false;
                    }
                    else if (control is BunifuSeparator)
                    {
                        var controle = (BunifuSeparator)control;
                        controle.BackColor = Color.FromArgb(64, 64, 64);
                    }
                }


                foreach (Control control in group_Checklist.Controls)
                {
                    if (control is BunifuDropdown)
                    {
                        var controle = (BunifuDropdown)control;
                        controle.Enabled = false;
                    }
                    //else if (control is RichTextBox)
                    //{
                    //    var teste = (RichTextBox)control;
                    //    teste.Enabled = false;
                    //}

                    switchChecklistAusente.Enabled = false;
                    cmbMarca.Enabled = false;
                    sepMARCA.BackColor = Color.FromArgb(64, 64, 64);
                    txtModelo.Enabled = false;
                    sepMODELO.BackColor = Color.FromArgb(64, 64, 64);
                    cmbCor.Enabled = false;
                    sepCOR.BackColor = Color.FromArgb(64, 64, 64);
                    txtMei_SerialNumber.Enabled = false;
                    txtMei_SerialNumber.BackColor = Color.FromArgb(64, 64, 64);
                    sepMei.BackColor = Color.FromArgb(64, 64, 64);

                    txtModelo.BackColor = Color.FromArgb(64, 64, 64);

                    if (control.Name == "txtChecklistObservacoes" || control.Name == "txtChecklistMotivoAusencia")
                    {
                        var richTextBox = (RichTextBox)control;
                        control.BackColor = Color.FromArgb(64, 64, 64);
                        control.Text = string.Empty;
                        richTextBox.ReadOnly = true;
                    }
                    //else if (control.Name == "txtChecklistMotivoAusencia")
                    //{
                    //    var richTextBox = (RichTextBox)control;
                    //    control.BackColor = Color.FromArgb(23, 23, 36);
                    //    richTextBox.ReadOnly = false;
                    //}
                }
            }
        }

        private void SetarCores()
        {
            group_InformacoesAparelho.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            group_CondicoesFisicas.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            group_OutrasObservacoes.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            group_RelatoCliente.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            group_CondicoesBalcao.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void ZerarTodosCampos()
        {
            SetarComboboxComUltimoClienteAdicionado(dt, ultimoClienteAdicionadoID);
            InicializarDatas();

            cmbStatusServico.SelectedItem = "AVALIAÇÃO";

            cmbMarca.Text = "";
            txtModelo.Text = "";
            cmbCor.Text = "";
            txtMei_SerialNumber.Text = "";
            txtSenhaDispositivo.Text = "";

            cmbPelicula.Text = "";
            cmbTela.Text = "";
            cmbTampa.Text = "";
            cmbAro.Text = "";
            cmbBotoes.Text = "";
            cmbLenteCamera.Text = "";

            txtObservacoes.Text = "";
            txtRelatoCliente.Text = "";
            txtCondicoesBalcao.Text = "";

            cmbChecklistBiometria.Text = "";
            cmbChecklistMicrofone.Text = "";
            cmbChecklistTela.Text = "";
            cmbChecklistChip.Text = "";
            cmbChecklistBotoes.Text = "";
            cmbChecklistSensor.Text = "";
            cmbChecklistCameras.Text = "";
            cmbChecklistAuricular.Text = "";
            cmbChecklistWifi.Text = "";
            cmbChecklistAltoFaltante.Text = "";
            cmbChecklistBluetooth.Text = "";
            cmbChecklistCarregamento.Text = "";

            txtChecklistObservacoes.Text = "";
            txtChecklistMotivoAusencia.Text = "";

            switchChecklistAusente.IsOn = false;
        }

        private void BuscarSenhaPattern()
        {
            try
            {
                picSenhaPattern.Image =
                    ConvertImage.ConvertByteArrayToImage(buscarDados.BuscarImagem(lblIdServico.Text));
            }
            catch (Exception)
            {
            }
        }

        private void InicializarDatas()
        {
            lblDataOrdemServico.Text = $"{DateTime.Now:G}";
            dtpDataServico.Value = DateTime.Now;
        }

        public void CarregarComboxClientes()
        {
            cmbCliente.SelectedIndexChanged -= cmbCliente_SelectedIndexChanged;
            ultimoClienteAdicionadoID = preencherCombobox.CarregarComboxClientes(cmbCliente, ref dt);
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
        }

        private void SetarComboboxComUltimoClienteAdicionado(DataTable _dt, int _id)
        {
            //Pego a linha que tem o ultimo ID cadastrado
            DataRow[] rows = _dt.Select($"ID ='{_id}'");
            //Seto a index da combobox para a index dessa linha que peguei acima.
            cmbCliente.SelectedIndex = _dt.Rows.IndexOf(rows[0]);
        }

        private void GerarNovaOrdemServico()
        {
            //int ultimaOrdemServicoAdicionada = buscarDados.BuscarUltimaIdOrdemServico();
            int ultimaOrdemServicoAdicionada = buscarDados.BuscarUltimaIdOrdemServico();

            if (ultimaOrdemServicoAdicionada != -1)
            {
                int novaOrdemServico = ultimaOrdemServicoAdicionada + 1;
                lblOrdemServico.Text = $@"OS {novaOrdemServico:0000}";
                ultimaOrdemServicoID = novaOrdemServico;
            }
        }

        private void txtStatusServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxStatus.MudarCor(cmbStatusServico);
        }

        private void btnSalvarOrdemServico_Click(object sender, EventArgs e)
        {
            SalvarOrdemServico();
        }

        private void SalvarOrdemServico()
        {
            //Validacao dos campos de condicoes fisicas, verificando se pelo menos 1 possui dados.
            int camposCondFisicasSemDados = 0;
            foreach (Control control in group_CondicoesFisicas.Controls)
            {
                if (control is BunifuDropdown && control.Name.StartsWith("cmb") &&
                    string.IsNullOrWhiteSpace(control.Text))
                    camposCondFisicasSemDados++;
            }

            //Validacao dos campos de checklist, verificando se pelo menos 1 possui dados.
            int camposChecklistSemDados = 0;
            if (switchChecklistAusente.IsOn == false)
            {
                foreach (Control control in group_Checklist.Controls)
                {
                    if (control is BunifuDropdown && control.Name.StartsWith("cmbChecklist") &&
                        string.IsNullOrWhiteSpace(control.Text))
                        camposChecklistSemDados++;
                }
            }

            if (string.IsNullOrWhiteSpace(cmbMarca.Text))
            {
                MessageBox.Show(@"Voce esqueceu de selecionar a marca do aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show(@"Voce esqueceu de selecionar o modelo do aparelho", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (camposCondFisicasSemDados == 6)
            {
                MessageBox.Show(@"Voce deve preencher ao menos um campo das condições fisicas do aparelho.", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (camposChecklistSemDados == 12)
            {
                MessageBox.Show(
                    @"Voce deve preencher ao menos um campo de checklist do aparelho ou marcar a opção 'Impossivel fazer checklist'",
                    "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (switchChecklistAusente.IsOn == true && string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text))
            {
                MessageBox.Show(@"Especifique o motivo para a ausência do checklist", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isExisteOrdemServico =
                    verifExistencia.VerificarExistenciaOrdemServico(
                        Convert.ToInt32(lblOrdemServico.Text.TrimStart('O', 'S', ' ')));
                if (isExisteOrdemServico == true)
                {
                    bool isExisteCondFisicasChecklist =
                        verifExistencia.VerificarExistenciaCondFisicasChecklist(Convert.ToInt32(lblIdServico.Text));
                    if (isExisteCondFisicasChecklist == true)
                    {
                        //InserirOrdemServico(OrdemServico.AtualizarTudo);
                        AtualizarOrdemServicoEntradaExistente();
                    }
                    else
                    {
                        InserirOrdemServico(OrdemServico.ExisteApenasServico);
                    }
                }
                else
                {
                    InserirOrdemServico(OrdemServico.NovaInsercao);
                }

                standby_orgContext context = new standby_orgContext();
                lblIdServico.Text = context.tb_servicos.First(x => x.sv_ordem_serv == ultimaOrdemServicoID).sv_id
                    .ToString();
                this.Close();
            }
        }

        private void InserirOrdemServico(OrdemServico _tipo)
        {
            try
            {
                ClienteEstrutura clienteDados = new ClienteEstrutura();
                ServicoEstrutura servicoDados = new ServicoEstrutura();
                ChecklistEstrutura checklistDados = new ChecklistEstrutura();
                CondicoesFisicasEstrutura condicoesFisicasDados = new CondicoesFisicasEstrutura();

                //Dados do cliente
                clienteDados.ID = Convert.ToInt32(lblIdCliente.Text);

                #region If pra verificar o tipo do aparelho de acordo com o icone setado no form que chama esse aqui

                string tipoAparelho = "NAO SETADA";
                if (tipoAparelhoGlobal == Aparelho.Celular)
                {
                    tipoAparelho = "Celular";
                }
                else if (tipoAparelhoGlobal == Aparelho.Computador)
                {
                    tipoAparelho = "Computador";
                }
                else if (tipoAparelhoGlobal == Aparelho.Notebook)
                {
                    tipoAparelho = "Notebook";
                }

                #endregion If pra verificar o tipo do aparelho de acordo com o icone setado no form que chama esse aqui

                //Dados do servico
                if (lblIdServico.Text != "IdServico")
                {
                    servicoDados.ID = Convert.ToInt32(lblIdServico.Text);
                }

                //servicoDados.OrdemServico = ordemServicoID;
                servicoDados.OrdemServico = Convert.ToInt32(lblOrdemServico.Text.TrimStart('O', 'S', ' '));
                servicoDados.DataServico = DateTime.Now;
                servicoDados.FK_IdCliente = clienteDados.ID;
                servicoDados.TipoAparelho = tipoAparelho;
                servicoDados.Marca = cmbMarca.Text;
                servicoDados.Aparelho = txtModelo.Text;
                servicoDados.Cor = cmbCor.Text;
                servicoDados.MeiSerialNumber = txtMei_SerialNumber.Text;
                servicoDados.Senha = string.IsNullOrWhiteSpace(txtSenhaDispositivo.Text)
                    ? null
                    : txtSenhaDispositivo.Text;
                servicoDados.SenhaPatternAndroid = picSenhaPattern.Image != null
                    ? ConvertImage.ConvertImageToByte(picSenhaPattern.Image)
                    : null;
                servicoDados.Situacao = string.IsNullOrWhiteSpace(txtObservacoes.Text) ? null : txtObservacoes.Text;
                servicoDados.Status = 1;
                servicoDados.RelatoCliente =
                    string.IsNullOrWhiteSpace(txtRelatoCliente.Text) ? null : txtRelatoCliente.Text;
                servicoDados.CondicoesBalcao =
                    string.IsNullOrWhiteSpace(txtCondicoesBalcao.Text) ? null : txtCondicoesBalcao.Text;
                servicoDados.AvaliacaoServico = cmbStatusServico.Text;

                //Dados do Checklist
                checklistDados.FK_IdServico = servicoDados.ID;
                checklistDados.OrdemServico = servicoDados.OrdemServico;
                checklistDados.DataChecklist = servicoDados.DataServico;
                checklistDados.Tipo = Constantes.CHK_ENTRADA;
                checklistDados.BiometriaFaceID =
                    switchChecklistAusente.IsOn == true ? null : cmbChecklistBiometria.Text;
                checklistDados.Microfone = switchChecklistAusente.IsOn == true ? null : cmbChecklistMicrofone.Text;
                checklistDados.Tela = switchChecklistAusente.IsOn == true ? null : cmbChecklistTela.Text;
                checklistDados.Chip = switchChecklistAusente.IsOn == true ? null : cmbChecklistChip.Text;
                checklistDados.Botoes = switchChecklistAusente.IsOn == true ? null : cmbChecklistBotoes.Text;
                checklistDados.Sensor = switchChecklistAusente.IsOn == true ? null : cmbChecklistSensor.Text;
                checklistDados.Cameras = switchChecklistAusente.IsOn == true ? null : cmbChecklistCameras.Text;
                checklistDados.Auricular = switchChecklistAusente.IsOn == true ? null : cmbChecklistAuricular.Text;
                checklistDados.Wifi = switchChecklistAusente.IsOn == true ? null : cmbChecklistWifi.Text;
                checklistDados.AltoFalante = switchChecklistAusente.IsOn == true ? null : cmbChecklistAltoFaltante.Text;
                checklistDados.Bluetooth = switchChecklistAusente.IsOn == true ? null : cmbChecklistBluetooth.Text;
                checklistDados.Carregamento =
                    switchChecklistAusente.IsOn == true ? null : cmbChecklistCarregamento.Text;
                //Ternario aninhado basicamente para dizer "Se o switch ausente ta on, significa que o valor fica null, caso nao, ele verifica se o campo ta vazio e poem null"
                checklistDados.Observacoes = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(txtChecklistObservacoes.Text) ? null : txtChecklistObservacoes.Text;
                ;
                checklistDados.Ausente = switchChecklistAusente.IsOn;
                checklistDados.MotivoAusencia = string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text)
                    ? null
                    : txtChecklistMotivoAusencia.Text;

                //Dados das condicoes fisicas
                condicoesFisicasDados.FK_IdServico = servicoDados.ID;
                condicoesFisicasDados.OrdemServico = servicoDados.OrdemServico;
                condicoesFisicasDados.DataCondicoesFisicas = servicoDados.DataServico;
                condicoesFisicasDados.Tipo = Constantes.CHK_ENTRADA;
                condicoesFisicasDados.Pelicula = cmbPelicula.Text;
                condicoesFisicasDados.Tela = cmbTela.Text;
                condicoesFisicasDados.Tampa = cmbTampa.Text;
                condicoesFisicasDados.Aro = cmbAro.Text;
                condicoesFisicasDados.Botoes = cmbBotoes.Text;
                condicoesFisicasDados.LenteCamera = cmbLenteCamera.Text;

                form_DiaEntrega formPrevisaoEntrega = new form_DiaEntrega(this, corGeral, clienteDados, servicoDados,
                    checklistDados, condicoesFisicasDados, _tipo);
                formPrevisaoEntrega.ShowDialog();
            }
            catch (Exception e)
            {
                mErro.ErroAoAbrirTelaInsercaoOrdemServico(e);
            }
        }

        private void AtualizarOrdemServicoEntradaExistente()
        {
            try
            {
                standby_orgContext context = new standby_orgContext();
                tb_clientes clienteDados =
                    context.tb_clientes.FirstOrDefault(x => x.cl_id == Convert.ToInt32(lblIdCliente.Text));
                tb_servicos servicoDados =
                    context.tb_servicos.FirstOrDefault(x => x.sv_id == Convert.ToInt32(lblIdServico.Text));
                tb_checklist checklistDados =
                    context.tb_checklist.FirstOrDefault(x => x.ch_sv_idservico == servicoDados.sv_id);
                tb_condicoes_fisicas condicoesFisicasDados =
                    context.tb_condicoes_fisicas.FirstOrDefault(x => x.cf_sv_idservico == servicoDados.sv_id);

                #region If pra verificar o tipo do aparelho de acordo com o icone setado no form que chama esse aqui

                string tipoAparelho = string.Empty;
                if (tipoAparelhoGlobal == Aparelho.Celular)
                {
                    tipoAparelho = "Celular";
                }
                else if (tipoAparelhoGlobal == Aparelho.Computador)
                {
                    tipoAparelho = "Computador";
                }
                else if (tipoAparelhoGlobal == Aparelho.Notebook)
                {
                    tipoAparelho = "Notebook";
                }

                #endregion If pra verificar o tipo do aparelho de acordo com o icone setado no form que chama esse aqui

                servicoDados.sv_cl_idcliente = clienteDados.cl_id;
                servicoDados.sv_tipo_aparelho = tipoAparelho;
                servicoDados.sv_marca = cmbMarca.Text;
                servicoDados.sv_aparelho = txtModelo.Text;
                servicoDados.sv_cor = cmbCor.Text;
                servicoDados.sv_mei_serialnumber = txtMei_SerialNumber.Text;
                servicoDados.sv_senha = string.IsNullOrWhiteSpace(txtSenhaDispositivo.Text)
                    ? null
                    : txtSenhaDispositivo.Text;
                servicoDados.sv_senha_pattern = picSenhaPattern.Image != null
                    ? ConvertImage.ConvertImageToByte(picSenhaPattern.Image)
                    : null;
                servicoDados.sv_situacao = string.IsNullOrWhiteSpace(txtObservacoes.Text) ? null : txtObservacoes.Text;
                servicoDados.sv_status = 1;
                servicoDados.sv_relato_cliente =
                    string.IsNullOrWhiteSpace(txtRelatoCliente.Text) ? null : txtRelatoCliente.Text;
                servicoDados.sv_condicoes_balcao = string.IsNullOrWhiteSpace(txtCondicoesBalcao.Text)
                    ? null
                    : txtCondicoesBalcao.Text;
                servicoDados.sv_avaliacao_servico = cmbStatusServico.Text;

                //Dados do Checklist
                checklistDados.ch_tipo = Constantes.CHK_ENTRADA;
                checklistDados.ch_biometria_faceid = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistBiometria.Text) ? null : cmbChecklistBiometria.Text;
                checklistDados.ch_microfone = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistMicrofone.Text) ? null : cmbChecklistMicrofone.Text;
                checklistDados.ch_tela = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistTela.Text) ? null : cmbChecklistTela.Text;
                checklistDados.ch_chip = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistChip.Text) ? null : cmbChecklistChip.Text;
                checklistDados.ch_botoes = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistBotoes.Text) ? null : cmbChecklistBotoes.Text;
                checklistDados.ch_sensor = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistSensor.Text) ? null : cmbChecklistSensor.Text;
                checklistDados.ch_cameras = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistCameras.Text) ? null : cmbChecklistCameras.Text;
                checklistDados.ch_auricular = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistAuricular.Text) ? null : cmbChecklistAuricular.Text;
                checklistDados.ch_wifi = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistWifi.Text) ? null : cmbChecklistWifi.Text;
                checklistDados.ch_altofalante = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistAltoFaltante.Text) ? null : cmbChecklistAltoFaltante.Text;
                checklistDados.ch_bluetooth = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistBluetooth.Text) ? null : cmbChecklistBluetooth.Text;
                checklistDados.ch_carregamento = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(cmbChecklistCarregamento.Text) ? null : cmbChecklistCarregamento.Text;
                //Ternario aninhado basicamente para dizer "Se o switch ausente ta on, significa que o valor fica null, caso nao, ele verifica se o campo ta vazio e poem null"
                checklistDados.ch_observacoes = switchChecklistAusente.IsOn == true ? null :
                    string.IsNullOrWhiteSpace(txtChecklistObservacoes.Text) ? null : txtChecklistObservacoes.Text;
                ;
                checklistDados.ch_ausente = switchChecklistAusente.IsOn;
                checklistDados.ch_motivo_ausencia = string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text)
                    ? null
                    : txtChecklistMotivoAusencia.Text;

                //Dados das condicoes fisicas
                condicoesFisicasDados.cf_data = servicoDados.sv_data;
                condicoesFisicasDados.cf_pelicula =
                    string.IsNullOrWhiteSpace(cmbPelicula.Text) ? null : cmbPelicula.Text;
                condicoesFisicasDados.cf_tela = string.IsNullOrWhiteSpace(cmbTela.Text) ? null : cmbTela.Text;
                condicoesFisicasDados.cf_tampa = string.IsNullOrWhiteSpace(cmbTampa.Text) ? null : cmbTampa.Text;
                condicoesFisicasDados.cf_aro = string.IsNullOrWhiteSpace(cmbAro.Text) ? null : cmbAro.Text;
                condicoesFisicasDados.cf_botoes = string.IsNullOrWhiteSpace(cmbBotoes.Text) ? null : cmbBotoes.Text;
                condicoesFisicasDados.cf_lente_camera =
                    string.IsNullOrWhiteSpace(cmbLenteCamera.Text) ? null : cmbLenteCamera.Text;

                context.tb_servicos.Update(servicoDados);
                context.tb_clientes.Update(clienteDados);
                context.tb_checklist.Update(checklistDados);
                context.tb_condicoes_fisicas.Update(condicoesFisicasDados);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                mErro.ErroAoAtualizarOrdemServicoEntrada(e);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxBaseDataBound combobox = cmbCliente as ComboBoxBaseDataBound;
            if (combobox.SelectedIndex != -1)
            {
                DataRowView drv = combobox.Items[combobox.SelectedIndex] as DataRowView;
                //lblIdCliente.Text = listClientesComId.ElementAt(multiColumnComboBox1.SelectedIndex).ID.ToString();
                lblIdCliente.Text = drv.Row[0].ToString();
            }
        }

        private void picSenhaPattern_Click(object sender, EventArgs e)
        {
            if (isNovaOrdemServico == true)
            {
                form_PasswordPattern pp = new form_PasswordPattern(this, corGeral);
                pp.ShowDialog();
            }
            else
            {
                VerSenhaPattern();
            }
        }

        private void VerSenhaPattern()
        {
            using (form_PasswordPatternExibir passShow = new form_PasswordPatternExibir(corGeral))
            {
                passShow.pictureBox1.Image =
                    ConvertImage.ConvertByteArrayToImage(buscarDados.BuscarImagem(lblIdServico.Text));
                if (passShow.pictureBox1.Image == null)
                {
                    passShow.lblSemPadrao.Visible = true;
                    passShow.lblDesejaCadastrar.Visible = true;
                    passShow.btnSim.Visible = true;
                    passShow.btnNao.Visible = true;
                    passShow.lblIDServico.Text = lblIdServico.Text;
                }
                else
                {
                    passShow.lblSemPadrao.Visible = false;
                    passShow.lblDesejaCadastrar.Visible = false;
                    passShow.btnSim.Visible = false;
                    passShow.btnNao.Visible = false;
                    passShow.lblIDServico.Text = lblIdServico.Text;
                }

                passShow.ShowDialog();
            }
        }

        private void form_OrdemServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void form_OrdemServico_Load(object sender, EventArgs e)
        {
            BuscarSenhaPattern();
        }

        private void btnConcluirServico_Click(object sender, EventArgs e)
        {
            //if (XtraMessageBox.Show("Do you want to quit the application?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            //{
            //}
            ////Completando servico com entity framework
            if (MessageBox.Show(@"Deseja concluir esse serviço?", @"CONFIRMAÇÃO", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.No)
            {
                tb_servicos servico = context.tb_servicos.Find(Convert.ToInt32(lblIdServico.Text));
                servico.sv_status = 0;
                context.SaveChanges();

                msgSucess.ConcluirServicoSucesso();
            }
        }

        private void btnConcluirImprimir_Click(object sender, EventArgs e)
        {
            SalvarImprimirOrdemServico();
        }

        private void SalvarImprimirOrdemServico()
        {
            if (MessageBox.Show(@"Deseja imprimir a Ordem de Serviço - ENTRADA?", @"CONFIRMAÇÃO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.No)
            {
                try
                {
                    SalvarOrdemServico();
                    report_OrdemServicoEntrada report = new report_OrdemServicoEntrada();
                    report.Parameters["pIDServico"].Value = Convert.ToInt32(lblIdServico.Text);
                    //report.Parameters["clienteID"].Visible = false;
                    report.PrintingSystem.ShowPrintStatusDialog = false;
                    //documentViewer1.DocumentSource = report;
                    report.CreateDocument();
                    PrintToolBase tool = new PrintToolBase(report.PrintingSystem);
                    //tool.PrinterSettings.
                    tool.Print("Microsoft Print to PDF");
                    //using (var printTool = new DevExpress.XtraReports.UI.ReportPrintTool(report))
                    //{
                    //    //   printTool.Print(sPrinterDeliveryTkt);
                    //    printTool.Report.CreateDocument(false); // <- ADD THIS LINE
                    //    printTool.PrintingSystem.ExportToPdf(@"teste.pdf");
                    //}
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void switchChecklistAusente_Toggled(object sender, EventArgs e)
        {
            if (switchChecklistAusente.IsOn == true)
            {
                //MessageBox.Show("Ativado");
                foreach (Control control in group_Checklist.Controls)
                {
                    if (control is BunifuDropdown && control.Name.StartsWith("cmbChecklist"))
                    {
                        control.Enabled = false;
                        control.Text = string.Empty;
                    }
                    else if (control.Name == "txtChecklistObservacoes")
                    {
                        var richTextBox = (RichTextBox)control;
                        control.BackColor = Color.FromArgb(64, 64, 64);
                        control.Text = string.Empty;
                        richTextBox.ReadOnly = true;
                    }
                    else if (control.Name == "txtChecklistMotivoAusencia")
                    {
                        var richTextBox = (RichTextBox)control;
                        control.BackColor = Color.FromArgb(23, 23, 36);
                        richTextBox.ReadOnly = false;
                    }
                }
            }
            else
            {
                foreach (Control control in group_Checklist.Controls)
                {
                    if (control is BunifuDropdown && control.Name.StartsWith("cmbChecklist"))
                    {
                        control.Enabled = true;
                    }
                    else if (control.Name == "txtChecklistObservacoes")
                    {
                        var richTextBox = (RichTextBox)control;
                        control.BackColor = Color.FromArgb(23, 23, 36);
                        richTextBox.ReadOnly = false;
                    }
                    else if (control.Name == "txtChecklistMotivoAusencia")
                    {
                        var richTextBox = (RichTextBox)control;
                        control.BackColor = Color.FromArgb(64, 64, 64);
                        control.Text = string.Empty;
                        richTextBox.ReadOnly = true;
                    }
                }
            }
        }
    }
}