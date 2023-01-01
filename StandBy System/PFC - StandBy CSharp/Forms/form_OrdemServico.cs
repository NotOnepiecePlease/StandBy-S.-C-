using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DevExpress.CodeParser;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.PreencherComponentes;
using Syncfusion.DataSource.Extensions;
using Syncfusion.Windows.Forms.Tools;
using PFC___StandBy_CSharp.Utils;
using static PFC___StandBy_CSharp.Enum.Enum;
using ConvertImage = PFC___StandBy_CSharp.Utils.ConvertImage;
using DevExpress.XtraEditors;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.Impressao;
using DevExpress.XtraPrinting;

namespace PFC___StandBy_CSharp.Forms
{
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
    public partial class form_OrdemServico : Form
    {
        private standby_orgContext standbyDB = new standby_orgContext();
        private BuscarDados buscarDados = new BuscarDados();
        private VerificarExistencia verifExistencia = new VerificarExistencia();
        private List<ClienteEstrutura> listClientesComId = new List<ClienteEstrutura>();
        private MensagensSucesso msgSucess = new MensagensSucesso();
        private readonly PreencherComboBoxCliente preencherCombobox = new PreencherComboBoxCliente();
        private int ultimoClienteAdicionadoID = 0;
        private int ordemServicoID = 0;
        private DataTable dt;
        private Aparelho tipoAparelhoGlobal;
        private int[] corGeral = new[] { 0, 0, 0 };

        public form_OrdemServico(Aparelho _tipoAparelhoGlobal, int _idClientePreSetado, bool _isNovaOrdemServico, int[] _corGeral)
        {
            InitializeComponent();
            var a = lblIdServico.Text;
            corGeral = _corGeral;
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
            }
            //ZerarTodosCampos();
            InicializarDatas();
            tipoAparelhoGlobal = _tipoAparelhoGlobal;
            cmbStatusServico.SelectedItem = "AVALIAÇÃO";
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
            picSenhaPattern.Image = ConvertImage.ConvertByteArrayToImage(buscarDados.BuscarImagem(lblIdServico.Text));
        }

        private void InicializarDatas()
        {
            lblDataOrdemServico.Text = $"{DateTime.Now:G}";
            dtpDataServico.Value = DateTime.Now;
        }

        public void CarregarComboxClientes()
        {
            cmbCliente.SelectedIndexChanged -= cmbCliente_SelectedIndexChanged;
            this.cmbCliente.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbCliente.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;

            listClientesComId = preencherCombobox.Preencher();

            dt = new DataTable("Table1");
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Cpf");
            dt.Columns.Add("⠀⠀⠀Telefone⠀⠀");
            //dt.Columns.Add("Recado");
            //dt.Columns.Add("Nascimento");
            //dt.Columns.Add("⠀⠀⠀⠀⠀⠀⠀⠀Endereço⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            //dt.Columns.Add("⠀⠀⠀Bairro⠀⠀⠀");
            //dt.Columns.Add("Estado");
            dt.Columns[0].ColumnMapping = MappingType.Hidden;

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            listClientesComId
                .OrderBy(x => x.Nome)
                .ToList()
                .ForEach(cliente =>
                {
                    //Pegando a id do ultimo cliente adicionado (ou o que tem MAIOR ID q da na mesma)
                    ultimoClienteAdicionadoID = cliente.ID > ultimoClienteAdicionadoID ? cliente.ID : ultimoClienteAdicionadoID;

                    dt.Rows.Add(new string[]
                    {
                        $"{cliente.ID}",
                        $"{cliente.Nome}",
                        $"{cliente.Cpf}",
                        $"{cliente.Telefone}",
                       // $"{cliente.TelefoneRecado}",
                        //$"{cliente.DataNascimento}",
                        //$"{cliente.Endereco}",
                        //$"{cliente.Bairro}",
                        //$"{cliente.Estado}"
                    });
                });

            DataView view = new DataView(dt);

            this.cmbCliente.DataSource = view;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.ValueMember = "ID";

            //SetarComboboxComUltimoClienteAdicionado(dt);
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
            int ultimaOrdemServicoAdicionada = buscarDados.BuscarUltimaIdOrdemServico();

            if (ultimaOrdemServicoAdicionada != -1)
            {
                int novaOrdemServico = ultimaOrdemServicoAdicionada + 1;
                lblOrdemServico.Text = $@"OS {novaOrdemServico:0000}";
                ordemServicoID = novaOrdemServico;
            }
        }

        private void txtStatusServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudarCorComboboxStatus();
        }

        private void MudarCorComboboxStatus()
        {
            if (cmbStatusServico.Text == @"APROVADO")
            {
                cmbStatusServico.BackColor = Color.DodgerBlue;
                cmbStatusServico.BackgroundColor = Color.DodgerBlue;
            }
            else if (cmbStatusServico.Text == @"AVALIAÇÃO")
            {
                cmbStatusServico.BackColor = Color.DarkOrange;
                cmbStatusServico.BackgroundColor = Color.DarkOrange;
            }
            else if (cmbStatusServico.Text == @"CONCLUÍDO")
            {
                cmbStatusServico.BackColor = Color.Chartreuse;
                cmbStatusServico.BackgroundColor = Color.Chartreuse;
            }
        }

        private void btnSalvarOrdemServico_Click(object sender, EventArgs e)
        {
            //ZerarTodosCampos();

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
            else
            {
                bool isExisteOrdemServico = verifExistencia.VerificarExistenciaOrdemServico(Convert.ToInt32(lblOrdemServico.Text.TrimStart('O', 'S', ' ')));
                if (isExisteOrdemServico == true)
                {
                    bool isExisteCondFisicasChecklist = verifExistencia.VerificarExistenciaCondFisicasChecklist(Convert.ToInt32(lblIdServico.Text));
                    if (isExisteCondFisicasChecklist == true)
                    {
                        InserirOrdemServico(OrdemServico.AtualizarTudo);
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
            }
        }

        private void InserirOrdemServico(OrdemServico _tipo)
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
            servicoDados.OrdemServico = ordemServicoID;
            servicoDados.DataServico = DateTime.Now;
            servicoDados.FK_IdCliente = clienteDados.ID;
            servicoDados.TipoAparelho = tipoAparelho;
            servicoDados.Marca = cmbMarca.Text;
            servicoDados.Aparelho = txtModelo.Text;
            servicoDados.Cor = cmbCor.Text;
            servicoDados.MeiSerialNumber = txtMei_SerialNumber.Text;
            servicoDados.Senha = string.IsNullOrWhiteSpace(txtSenhaDispositivo.Text) ? null : txtSenhaDispositivo.Text;
            servicoDados.Situacao = string.IsNullOrWhiteSpace(txtCondicoesBalcao.Text) ? null : txtCondicoesBalcao.Text;
            servicoDados.Status = 1;
            servicoDados.RelatoCliente = string.IsNullOrWhiteSpace(txtRelatoCliente.Text) ? null : txtRelatoCliente.Text;
            servicoDados.Observacoes = string.IsNullOrWhiteSpace(txtObservacoes.Text) ? null : txtObservacoes.Text;
            servicoDados.AvaliacaoServico = cmbStatusServico.Text;

            //Dados do Checklist
            checklistDados.OrdemServico = servicoDados.OrdemServico;
            checklistDados.DataChecklist = servicoDados.DataServico;
            checklistDados.BiometriaFaceID = cmbChecklistBiometria.Text;
            checklistDados.Microfone = cmbChecklistMicrofone.Text;
            checklistDados.Tela = switchChecklistAusente.IsOn == true ? null : cmbChecklistTela.Text;
            checklistDados.Chip = switchChecklistAusente.IsOn == true ? null : cmbChecklistChip.Text;
            checklistDados.Botoes = switchChecklistAusente.IsOn == true ? null : cmbChecklistBotoes.Text;
            checklistDados.Sensor = switchChecklistAusente.IsOn == true ? null : cmbChecklistSensor.Text;
            checklistDados.Cameras = switchChecklistAusente.IsOn == true ? null : cmbChecklistCameras.Text;
            checklistDados.Auricular = switchChecklistAusente.IsOn == true ? null : cmbChecklistAuricular.Text;
            checklistDados.Wifi = switchChecklistAusente.IsOn == true ? null : cmbChecklistWifi.Text;
            checklistDados.AltoFalante = switchChecklistAusente.IsOn == true ? null : cmbChecklistAltoFaltante.Text;
            checklistDados.Bluetooth = switchChecklistAusente.IsOn == true ? null : cmbChecklistBluetooth.Text;
            checklistDados.Carregamento = switchChecklistAusente.IsOn == true ? null : cmbChecklistCarregamento.Text;
            //Ternario aninhado basicamente para dizer "Se o switch ausente ta on, significa que o valor fica null, caso nao, ele verifica se o campo ta vazio e poem null"
            checklistDados.Observacoes = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(txtChecklistObservacoes.Text) ? null : txtChecklistObservacoes.Text; ;
            checklistDados.Ausente = switchChecklistAusente.IsOn;
            checklistDados.MotivoAusencia = string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text) ? null : txtChecklistMotivoAusencia.Text;

            //Dados das condicoes fisicas
            condicoesFisicasDados.OrdemServico = servicoDados.OrdemServico;
            condicoesFisicasDados.DataCondicoesFisicas = servicoDados.DataServico;
            condicoesFisicasDados.Pelicula = cmbPelicula.Text;
            condicoesFisicasDados.Tela = cmbTela.Text;
            condicoesFisicasDados.Tampa = cmbTampa.Text;
            condicoesFisicasDados.Aro = cmbAro.Text;
            condicoesFisicasDados.Botoes = cmbBotoes.Text;
            condicoesFisicasDados.LenteCamera = cmbLenteCamera.Text;

            form_DiaEntrega formPrevisaoEntrega = new form_DiaEntrega(this, corGeral, clienteDados, servicoDados, checklistDados, condicoesFisicasDados, _tipo);
            formPrevisaoEntrega.ShowDialog();
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
            VerSenhaPattern();
        }

        private void VerSenhaPattern()
        {
            using (form_PasswordPatternExibir passShow = new form_PasswordPatternExibir(corGeral))
            {
                passShow.pictureBox1.Image = ConvertImage.ConvertByteArrayToImage(buscarDados.BuscarImagem(lblIdServico.Text));
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
            if (MessageBox.Show(@"Deseja concluir esse serviço?", @"CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.No)
            {
                tb_servicos servico = standbyDB.tb_servicos.Find(Convert.ToInt32(lblIdServico.Text));
                servico.sv_status = 0;
                standbyDB.SaveChanges();

                msgSucess.ConcluirServicoSucesso();
            }
        }

        private void btnConcluirImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                report_OrdemServico report = new report_OrdemServico();
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
}