using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Forms._1___Ordems_Servico;
using PFC___StandBy_CSharp.Forms.Pagamento_e_Compras;
using PFC___StandBy_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using PFC___StandBy_CSharp.Utils;
using static PFC___StandBy_CSharp.Enums.EnumStandby;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using RichTextBox = System.Windows.Forms.RichTextBox;
using System.Threading.Tasks;
using NLog;

// ReSharper disable InconsistentNaming

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_ServicoPrincipal : Form
    //public partial class form_ServicoPrincipal : Form
    {
        //rowHandle e column servem pra mostrar o popup menu no grid servicos
        private int rowHandle;
        private GridColumn column;
        private DeletarDados deletarDados = new DeletarDados();
        private BuscarDados buscarDados = new BuscarDados();
        public int[] corGeral = new[] { 255, 0, 103 };
        private NLog.Logger logger = LogManager.GetCurrentClassLogger();

        public form_ServicoPrincipal()
        {
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("pt-BR");
            InitializeComponent();
            PopularGridview();
        }

        public async void PopularGridview()
        {
            await dataSourceGridServicos.FillAsync();
            await SetarCorColunaOS();
            int rowHandle = 0;

            //gridviewServicos.BeginUpdate();
            gridviewServicos.SelectRow(rowHandle);
            gridviewServicos.FocusedRowHandle = rowHandle;
            gridviewServicos.MoveFirst();

            //MessageBox.Show("Test");
            //gridviewServicos.EndUpdate();
        }

        private void LimparLinhasSelecionadasGrid(object sender, EventArgs e)
        {
            //gridviewServicos.ClearSelection();
            //gridviewServicos.LayoutChanged();
            //int rowHandle = 0;
            //gridviewServicos.SelectRow(rowHandle);
            //gridviewServicos.FocusedRowHandle = rowHandle;
            //gridviewServicos.MoveFirst();
        }

        //Seta o valor do prazo na celula
        private Task SetarCorColunaOS()
        {
            gridviewServicos.CustomColumnDisplayText += (sender, e) =>
            {
                if (e.Column.Name == "gridcol_Prazo")
                {
                    var indexLinhaAtual = gridviewServicos.GetRowHandle(e.ListSourceRowIndex);
                    var teste = gridviewServicos.GetRowCellValue(e.ListSourceRowIndex, gridcol_Prazo);
                    var dadosDaLinhaAtual = gridviewServicos.GetRow(indexLinhaAtual);
                    var servico = dadosDaLinhaAtual as IRow;
                    DateTime dataCad;
                    DateTime dataPrev;
                    try
                    {
                        if (servico != null)
                        {
                            if (servico[4].ToString() == "1922")
                            {
                            }

                            //sv_previsao_entrega
                            if (servico[6] != null && servico[1] != null)
                            {
                                dataCad = Convert.ToDateTime(servico[1]);
                                dataPrev = Convert.ToDateTime(servico[6]);

                                //TimeSpan r = dataPrev.Subtract(dataCad);
                                TimeSpan r = dataPrev.Subtract(DateTime.Now);
                                if (r.Days == 0 && r.Hours < 0)
                                {
                                    e.DisplayText = $"Venceu tem: {Math.Abs(r.Hours)} HORA(S)";
                                }
                                else if (r.Days < 0)
                                {
                                    e.DisplayText = $"Venceu tem: {Math.Abs(r.Days)} DIA(S)";
                                }
                                else if (r.Days == 0 && r.Hours <= 23 && r.Seconds <= 59)
                                {
                                    //HOJE - 15:00
                                    var dataParaEntregar = DateTime.Now.AddHours(r.Hours);
                                    var dataHoje = DateTime.Now;

                                    if (dataParaEntregar.Date != dataHoje.Date)
                                    {
                                        e.DisplayText = $"AMANHÃ - {dataPrev:HH:mm}";
                                    }
                                    else
                                    {
                                        e.DisplayText = $"HOJE - {dataPrev:HH:mm}";

                                        //e.Column.AppearanceCell.BackColor = Color.DarkOrange;
                                    }
                                }
                                else if (r.Days == 1 && (r.Hours + DateTime.Now.Hour) >= 23)
                                {
                                    //AMANHÃ - 12:00
                                    var dia = $"{dataPrev:dddd}";
                                    var diaSemSufixo = dia.Split('-');
                                    e.DisplayText = $"{diaSemSufixo[0].ToUpper()} - {dataPrev:HH:mm}";

                                    //e.DisplayText = $"AMANHÃ - {DateTime.Now.AddHours(r.Days).AddHours(r.Hours):hh:mm}";
                                }
                                else if (r.Days == 1)
                                {
                                    e.DisplayText = $"AMANHÃ - {dataPrev:HH:mm}";
                                }
                                else if (r.Days == 2)
                                {
                                    //QUARTA - 12:00
                                    //e.DisplayText = $"{DateTime.Now.AddHours(r.Days).AddHours(r.Hours):dddd} - {DateTime.Now.AddHours(r.Days).AddHours(r.Hours):hh:mm}";
                                    var dia = $"{dataPrev:dddd}";
                                    var diaSemSufixo = dia.Split('-');
                                    e.DisplayText = $"{diaSemSufixo[0].ToUpper()} - {dataPrev:HH:mm}";
                                }
                                else if (r.Days >= 3 && r.Days < 15)
                                {
                                    //SÁBADO - 12:00
                                    var dia = $"{dataPrev:dddd}";
                                    var diaSemSufixo = dia.Split('-');
                                    e.DisplayText = $"{diaSemSufixo[0].ToUpper()} - {dataPrev:HH:mm}";
                                }
                                else if (r.Days >= 15)
                                {
                                    var dia = $"{dataPrev:dddd}";
                                    var diaSemSufixo = dia.Split('-');
                                    e.DisplayText = $"{diaSemSufixo[0].ToUpper()} {dataPrev:dd/MM - HH:mm}";
                                }
                            }

                            //Linha que demorei dias pra encontrar, aqui voce seta a aparencia da celula como prioridade maxima, nenhum evento pode modificar
                            //veja o ranking aqui: https://docs.devexpress.com/WindowsForms/114444/Common-Features/Application-Appearance-and-Skin-Colors
                            gridviewServicos.Columns[1].AppearanceCell.Options.HighPriority = true;
                        }
                        else
                        {
                            e.DisplayText = $"--------";
                        }
                    }
                    catch (Exception exception)
                    {
                        logger.Error(exception, "Erro ao setar valor da coluna prazo");
                    }
                }
            };
            return Task.CompletedTask;
        }

        //Seta cor da celula com base no prazo
        private void gridviewServicos_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "sv_ordem_serv")
            {
                var indexLinhaAtual = e.RowHandle;
                var dadosDaLinhaAtual = gridviewServicos.GetRow(indexLinhaAtual);
                var servico = dadosDaLinhaAtual as IRow;
                DateTime dataCad = DateTime.MinValue;
                DateTime dataPrev = DateTime.MinValue;
                try
                {
                    if (servico != null)
                    {
                        if (servico[4].ToString() == "1922")
                        {
                        }

                        //sv_previsao_entrega
                        if (servico[6] != null && servico[1] != null)
                        {
                            string hexColorAmarelo = "#F7DF3E";
                            dataCad = Convert.ToDateTime(servico[1]);
                            dataPrev = Convert.ToDateTime(servico[6]);

                            //TimeSpan r = dataPrev.Subtract(dataCad);
                            TimeSpan r = dataPrev.Subtract(DateTime.Now);

                            if (r.Days < 0 && r.Hours < 0)
                            {
                                e.Appearance.BackColor = Color.DarkRed;
                            }
                            else if (r.Days == 0 && r.Hours <= 0 && r.Seconds <= 59)
                            {
                                //HOJE - 15:00 ou AMANHÄ - 19:15
                                //Contanto que seja menos que 24 hrs vai cair aqui, mas pode vir com AMANHA ou HOJE.
                                var dataParaEntregar = DateTime.Now.AddHours(r.Hours);
                                var dataHoje = DateTime.Now;

                                if (dataParaEntregar.Date != dataHoje.Date)
                                {
                                    e.Appearance.BackColor = Color.DarkRed;
                                }
                                else
                                {
                                    e.Appearance.BackColor = Color.DarkRed;
                                }
                            }

                            //else if (r.Days == 0 && (r.Hours + DateTime.Now.Hour) <= 12)
                            else if (r.Days == 0 && (r.Hours) <= 12)
                            {
                                //AMANHÃ - 12:00
                                Color cor = ColorTranslator.FromHtml(hexColorAmarelo);
                                e.Appearance.BackColor = cor;
                            }

                            //else if (r.Days >= 1 && r.Days < 15)
                            else if (r.Days >= 0 && r.Hours >= 12)
                            {
                                //Color cor = ColorTranslator.FromHtml(hexColorAmarelo);
                                //e.Appearance.BackColor = cor;
                                e.Appearance.BackColor = Color.Green;
                            }
                            else if (r.Days >= 1 && r.Days < 15)
                            {
                                e.Appearance.BackColor = Color.Green;
                            }
                            else if (r.Days >= 15)
                            {
                                e.Appearance.BackColor = Color.Gray;
                            }
                        }

                        //Linha que demorei dias pra encontrar, aqui voce seta a aparencia da celula como prioridade maxima, nenhum evento pode modificar
                        //veja o ranking aqui: https://docs.devexpress.com/WindowsForms/114444/Common-Features/Application-Appearance-and-Skin-Colors
                        gridviewServicos.Columns[1].AppearanceCell.Options.HighPriority = true;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Purple;
                    }
                }
                catch (Exception exception)
                {
                    logger.Error(exception, "Erro ao setar cor da coluna OS");
                    MessageBox.Show($"Erro Cor GRID: {exception}");
                }
            }
        }

        private void form_ServicoPrincipal_Shown(object sender, EventArgs e)
        {
            gridviewServicos.ShowFindPanel();
        }

        private void gridviewServicos_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //Faz o component de popup ser associado ao gridview
            //assim quando clico botao direito no grid, ele aparece
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRowCell)
            {
                view.FocusedRowHandle = rowHandle = hitInfo.RowHandle;
                column = hitInfo.Column;
                popupServicos.ShowPopup(barManager1, view.GridControl.PointToScreen(e.Point));
            }
        }

        private IRow BuscarDadosLinhaSelecionada()
        {
            var indexLinhaAtual = gridviewServicos.FocusedRowHandle;
            var dadosDaLinhaAtual = gridviewServicos.GetRow(indexLinhaAtual);
            var servico = dadosDaLinhaAtual as IRow;

            return servico;
        }

        private void btnEditarServico_ItemClick(object sender, ItemClickEventArgs e)
        {
            //for (int i = 0; i < 500; i++)
            //{
            //    EditarServicoV2();
            //    PopularGridview();
            //    Thread.Sleep(300);
            //}

            EditarServicoV2();
            PopularGridview();
        }

        private void EditarServicoV2()
        {
            try
            {
                var dadosLinhaSelecionada = BuscarDadosLinhaSelecionada();
                int idServico = Convert.ToInt32(dadosLinhaSelecionada[0]);

                List<tb_compras> pecasDoServico = buscarDados.BuscarPecasDoServico(idServico);

                (tb_servicos servico, tb_checklist checklist, tb_condicoes_fisicas condicoesFisicas) dadosServico =
                    buscarDados.BuscarOSPelaID(idServico);


                if (dadosServico.checklist == null || dadosServico.condicoesFisicas == null)
                {
                    using (form_OrdemServicoEditar formEditarServico =
                           new form_OrdemServicoEditar(dadosServico.servico.sv_cl_idcliente, true))
                    {
                        PreencherFormApenasDadosServico(formEditarServico, dadosServico, pecasDoServico);
                        formEditarServico.ShowDialog();
                    }
                }
                else
                {
                    using (form_OrdemServicoEditar formEditarServico =
                           new form_OrdemServicoEditar(dadosServico.servico.sv_cl_idcliente, false))
                    {
                        PreencherFormDadosCompletos(formEditarServico, dadosServico, pecasDoServico);
                        formEditarServico.ShowDialog();
                    }
                }

                pecasDoServico.Clear();
                dadosServico.servico = null;
                dadosServico.checklist = null;
                dadosServico.condicoesFisicas = null;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
        }

        private void PreencherFormDadosCompletos(form_OrdemServicoEditar _formEditarServico,
                                                 (tb_servicos servico, tb_checklist checklist, tb_condicoes_fisicas
                                                     condicoesFisicas) _dadosServico,
                                                 List<tb_compras> _pecas)
        {
            //Groupbox informacoes aparelho
            if (_dadosServico.checklist.ch_tipo == Constantes.CHK_ENTRADA &&
                _dadosServico.condicoesFisicas.cf_tipo == Constantes.CHK_ENTRADA)
            {
                _formEditarServico.lblTipoOrdemServico.Text = Constantes.CHK_ENTRADA;
                _formEditarServico.lblTipoOrdemServico.ForeColor = Color.DarkOrange;
            }
            else if (_dadosServico.checklist.ch_tipo == Constantes.CHK_SAIDA &&
                     _dadosServico.condicoesFisicas.cf_tipo == Constantes.CHK_SAIDA)
            {
                _formEditarServico.lblTipoOrdemServico.Text = Constantes.CHK_SAIDA;
                _formEditarServico.lblTipoOrdemServico.ForeColor = Color.LimeGreen;
            }
            else
            {
                _formEditarServico.lblTipoOrdemServico.Text = "ANTIGO";
                _formEditarServico.lblTipoOrdemServico.ForeColor = Color.PaleGoldenrod;
            }

            if (_dadosServico.servico.sv_tipo_aparelho != Enum.GetName(typeof(Aparelho), Aparelho.Celular))
            {
                _ = _formEditarServico.picSenhaPattern.Enabled == false;
            }
            else
            {
                _formEditarServico.picSenhaPattern.Image =
                    ConvertImage.ConvertByteArrayToImage(
                        buscarDados.BuscarImagem(_dadosServico.servico.sv_id.ToString()));
            }

            _formEditarServico.lblOrdemServico.Text = "OS " + _dadosServico.servico.sv_ordem_serv;
            _formEditarServico.lblIdServico.Text = _dadosServico.servico.sv_id.ToString();
            _formEditarServico.lblIdCliente.Text = _dadosServico.servico.sv_cl_idcliente.ToString();
            _formEditarServico.lblDataOrdemServico.Text = _dadosServico.servico.sv_data.ToString();
            _formEditarServico.lblIdCondicoesFisicas.Text = _dadosServico.condicoesFisicas.cf_id.ToString();
            _formEditarServico.lblIdChecklist.Text = _dadosServico.checklist.ch_id.ToString();
            _formEditarServico.dtpDataServico.DateTime = _dadosServico.servico.sv_data;
            _formEditarServico.cmbMarca.Text = _dadosServico.servico.sv_marca;
            _formEditarServico.txtModelo.Text = _dadosServico.servico.sv_aparelho;
            _formEditarServico.cmbCor.Text = _dadosServico.servico.sv_cor;
            _formEditarServico.txtMei_SerialNumber.Text = _dadosServico.servico.sv_mei_serialnumber;
            _formEditarServico.txtSenhaDispositivo.Text = _dadosServico.servico.sv_senha;
            _formEditarServico.cmbTipoAparelho.Text = _dadosServico.servico.sv_tipo_aparelho;

            //Setando o icone do tipo do aparelho la no canto superior direito
            string tipoAparelho = _dadosServico.servico.sv_tipo_aparelho;
            _formEditarServico.btnTipoAparelho.ImageOptions.SvgImage =
                _formEditarServico.svgCollection[tipoAparelho ?? "SemTipo"];

            //Groupbox Cond fisicas
            _formEditarServico.cmbPelicula.Text = _dadosServico.condicoesFisicas.cf_pelicula;
            _formEditarServico.cmbTela.Text = _dadosServico.condicoesFisicas.cf_tela;
            _formEditarServico.cmbTampa.Text = _dadosServico.condicoesFisicas.cf_tampa;
            _formEditarServico.cmbAro.Text = _dadosServico.condicoesFisicas.cf_aro;
            _formEditarServico.cmbBotoes.Text = _dadosServico.condicoesFisicas.cf_botoes;
            _formEditarServico.cmbLenteCamera.Text = _dadosServico.condicoesFisicas.cf_lente_camera;

            //Groupbox dados da parte de baixo
            _formEditarServico.txtObservacoes.Text = _dadosServico.servico.sv_situacao;
            _formEditarServico.txtRelatoCliente.Text = _dadosServico.servico.sv_relato_cliente;
            _formEditarServico.txtCondicoesBalcao.Text = _dadosServico.servico.sv_condicoes_balcao;
            _formEditarServico.txtSolucao.Text = _dadosServico.servico.sv_servico;
            _formEditarServico.txtDefeito.Text = _dadosServico.servico.sv_defeito;
            _formEditarServico.txtAcessorios.Text = _dadosServico.servico.sv_acessorios;

            //Groupbox dos valores
            decimal valorTotalPecas = 0;
            foreach (var peca in _pecas)
            {
                valorTotalPecas += peca.cp_valor_peca;
            }

            _formEditarServico.txtPecaValor.Text = $"{valorTotalPecas:C}";

            //formEditarServico.txtPecaValor.Text = $"{dadosServico.servico.sv_valorpeca:C}";
            _formEditarServico.txtServicoValor.Text = $"{_dadosServico.servico.sv_valorservico:C}";

            decimal lucro = (decimal)(_dadosServico.servico.sv_valorservico - valorTotalPecas);
            _formEditarServico.txtLucroValor.Text = $"{lucro:C}";

            //formEditarServico.txtLucroValor.Text = $"{dadosServico.servico.sv_lucro:C}";

            //Groupbox previsao
            _formEditarServico.dtpPrevisaoEntrega.EditValue = _dadosServico.servico.sv_previsao_entrega;

            //Status
            _formEditarServico.cmbStatusServico.Text = _dadosServico.servico.sv_avaliacao_servico;
        }

        private void PreencherFormApenasDadosServico(form_OrdemServicoEditar _formEditarServico,
                                                     (tb_servicos servico, tb_checklist checklist, tb_condicoes_fisicas
                                                         condicoesFisicas) _dadosServico,
                                                     List<tb_compras> _pecas)
        {
            //Groupbox informacoes aparelho

            _formEditarServico.lblTipoOrdemServico.Text = "SEM CHECKLIST";
            _formEditarServico.lblTipoOrdemServico.ForeColor = Color.Bisque;
            _formEditarServico.lblTipoOrdemServico.Location = new Point(21, -3);


            _formEditarServico.lblOrdemServico.Text = "OS " + _dadosServico.servico.sv_ordem_serv;
            _formEditarServico.lblIdServico.Text = _dadosServico.servico.sv_id.ToString();
            _formEditarServico.lblIdCliente.Text = _dadosServico.servico.sv_cl_idcliente.ToString();
            _formEditarServico.lblDataOrdemServico.Text = _dadosServico.servico.sv_data.ToString();

            //formEditarServico.lblIdCondicoesFisicas.Text = dadosServico.condicoesFisicas.cf_id.ToString();
            //formEditarServico.lblIdChecklist.Text = dadosServico.checklist.ch_id.ToString();
            _formEditarServico.dtpDataServico.DateTime = _dadosServico.servico.sv_data;
            _formEditarServico.cmbMarca.Text = _dadosServico.servico.sv_marca;
            _formEditarServico.txtModelo.Text = _dadosServico.servico.sv_aparelho;
            _formEditarServico.cmbCor.Text = _dadosServico.servico.sv_cor;
            _formEditarServico.txtMei_SerialNumber.Text = _dadosServico.servico.sv_mei_serialnumber;
            _formEditarServico.txtSenhaDispositivo.Text = _dadosServico.servico.sv_senha;

            //_formEditarServico.picSenhaPattern.Image = ConvertImage.ConvertByteArrayToImage(_dadosServico.servico.sv_senha_pattern);
            _formEditarServico.cmbTipoAparelho.Text = _dadosServico.servico.sv_tipo_aparelho;

            if (_dadosServico.servico.sv_tipo_aparelho != Enum.GetName(typeof(Aparelho), Aparelho.Celular))
            {
                _ = _formEditarServico.picSenhaPattern.Enabled == false;
            }
            else
            {
                _formEditarServico.picSenhaPattern.Image =
                    ConvertImage.ConvertByteArrayToImage(_dadosServico.servico.sv_senha_pattern);
            }

            //Setando o icone do tipo do aparelho la no canto superior direito
            string tipoAparelho = _dadosServico.servico.sv_tipo_aparelho;
            _formEditarServico.btnTipoAparelho.ImageOptions.SvgImage =
                _formEditarServico.svgCollection[tipoAparelho ?? "SemTipo"];

            //Groupbox Cond fisicas
            _formEditarServico.cmbPelicula.Text = "";
            _formEditarServico.cmbTela.Text = "";
            _formEditarServico.cmbTampa.Text = "";
            _formEditarServico.cmbAro.Text = "";
            _formEditarServico.cmbBotoes.Text = "";
            _formEditarServico.cmbLenteCamera.Text = "";

            //Botoes de checklist
            _formEditarServico.btnCheckListENTRADA.Text = "[CHECKLIST AUSENTE] Inserir Checklist - ENTRADA";
            _formEditarServico.btnChecklistSAIDA.Text = "[CHECKLIST AUSENTE] Inserir Checklist - SAIDA";

            //Groupbox dados da parte de baixo
            _formEditarServico.txtObservacoes.Text = _dadosServico.servico.sv_situacao;
            _formEditarServico.txtRelatoCliente.Text = _dadosServico.servico.sv_relato_cliente;
            _formEditarServico.txtCondicoesBalcao.Text = _dadosServico.servico.sv_condicoes_balcao;
            _formEditarServico.txtSolucao.Text = _dadosServico.servico.sv_servico;
            _formEditarServico.txtDefeito.Text = _dadosServico.servico.sv_defeito;
            _formEditarServico.txtAcessorios.Text = _dadosServico.servico.sv_acessorios;

            //Groupbox dos valores
            decimal valorTotalPecas = 0;
            foreach (var peca in _pecas)
            {
                valorTotalPecas += peca.cp_valor_peca;
            }

            _formEditarServico.txtPecaValor.Text = $"{valorTotalPecas:C}";
            _formEditarServico.txtServicoValor.Text = $"{_dadosServico.servico.sv_valorservico:C}";

            //_formEditarServico.txtPecaValor.Text = $"{_dadosServico.servico.sv_valorpeca:C}";
            //_formEditarServico.txtLucroValor.Text = $"{_dadosServico.servico.sv_lucro:C}";
            decimal lucro = (decimal)(_dadosServico.servico.sv_valorservico - valorTotalPecas);
            _formEditarServico.txtLucroValor.Text = $"{lucro:C}";

            //Groupbox previsao
            _formEditarServico.dtpPrevisaoEntrega.EditValue = _dadosServico.servico.sv_previsao_entrega;

            //Status
            _formEditarServico.cmbStatusServico.Text = _dadosServico.servico.sv_avaliacao_servico ?? "N/A";
        }

        public void EditarUmServico()
        {
            var dadosLinhaSelecionada = BuscarDadosLinhaSelecionada();
            int idServico = Convert.ToInt32(dadosLinhaSelecionada[0]);
            string nomeCliente = dadosLinhaSelecionada[2].ToString();
            var servico = buscarDados.BuscarOS_ApenasServico(idServico);

            string _TELCliente = buscarDados.BuscarTelefoneCliente(servico.FK_IdCliente);
            string _TEL_RECCliente = buscarDados.BuscarTelefoneRecadoCliente(servico.FK_IdCliente);
            float lucro = float.Parse(servico.Lucro.ToString());
            form_OrdensServ_Edit editarServicos = new form_OrdensServ_Edit(corGeral);
            try
            {
                string _CPFCliente = buscarDados.BuscarCPFCliente(servico.FK_IdCliente);
                editarServicos.txtCPFCliente.Text = _CPFCliente;
                editarServicos.txtAcessoriosEdit.Text = servico.Acessorios;
            }
            catch (Exception)
            {
            }

            editarServicos.lblIDservico.Text = servico.ID.ToString();
            editarServicos.lblIDcliente.Text = servico.FK_IdCliente.ToString();
            editarServicos.dtpDataEdit.Value = servico.DataServico;
            editarServicos.lblClienteNome.Text = nomeCliente;
            editarServicos.txtClienteNome.Text = nomeCliente;

            editarServicos.txtTelefoneCliente.Text = _TELCliente;
            editarServicos.txtTelefoneRecado.Text = _TEL_RECCliente;
            editarServicos.txtAparelhoEdit.Text = servico.Aparelho;
            editarServicos.txtDefeitoEdit.Text = servico.Defeito;
            editarServicos.txtSenhaEdit.Text = servico.Senha;
            editarServicos.txtSituacaoEdit.Text = servico.Situacao;

            editarServicos.txtServicoValorEdit.Text = servico.ValorServico.ToString();
            editarServicos.txtPecaValorEdit.Text = servico.ValorPeca.ToString();
            editarServicos.txtLucroValorEdit.Text = servico.Lucro.ToString();
            editarServicos.txtServicoEdit.Text = servico.Servico;
            if (servico.PrevisaoEntrega == null)
            {
                editarServicos.dtpDataEditPrevisao.FormatCustom = " ";
                editarServicos.dtpDataEditPrevisao.Format = DateTimePickerFormat.Custom;
                editarServicos.chkSemData.Checked = true;
            }
            else
            {
                editarServicos.dtpDataEditPrevisao.Value = (DateTime)servico.PrevisaoEntrega;
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

        private void btnEditarOrdemServicoEntrada_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Pegando os dados da linha que o usuario clicou
            var servico = BuscarDadosLinhaSelecionada();

            //Pegando todos os dados necessarios com base na ID
            int idServico = Convert.ToInt32(servico[0]);
            (ServicoEstrutura servico, CondicoesFisicasEstrutura condF, ChecklistEstrutura chkList) dadosServico =
                buscarDados.BuscarOS(idServico, "ENTRADA");

            if (string.IsNullOrWhiteSpace(dadosServico.servico.TipoAparelho))
            {
                MessageBox.Show(
                    "Necessario editar o aparelho e definir o seu tipo para ter acesso a O.S \n\nTipos existentes: Celular, Notebook ou Computador!"
                    ,
                    "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (servico != null && dadosServico != (null, null, null))
            {
                //existe uma possibilidade de dadosServico vir (comDados, null, null)
                if (dadosServico.servico.TipoAparelho == "Celular")
                {
                    AbrirOrdemServicoEntrada(Aparelho.Celular, dadosServico.servico, dadosServico.condF,
                        dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Computador")
                {
                    AbrirOrdemServicoEntrada(Aparelho.Computador, dadosServico.servico, dadosServico.condF,
                        dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Notebook")
                {
                    AbrirOrdemServicoEntrada(Aparelho.Notebook, dadosServico.servico, dadosServico.condF,
                        dadosServico.chkList);
                }
            }
        }

        private void btnEditarOrdemServicoSaida_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Pegando os dados da linha que o usuario clicou
            var servico = BuscarDadosLinhaSelecionada();

            //Pegando todos os dados necessarios com base na ID
            int idServico = Convert.ToInt32(servico[0]);
            (ServicoEstrutura servico, CondicoesFisicasEstrutura condF, ChecklistEstrutura chkList) dadosServico =
                buscarDados.BuscarOS(idServico, "SAIDA");

            if (string.IsNullOrWhiteSpace(dadosServico.servico.TipoAparelho))
            {
                MessageBox.Show(
                    "Necessario editar o aparelho e definir o seu tipo para ter acesso a O.S \n\nTipos existentes: Celular, Notebook ou Computador!"
                    ,
                    "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (servico != null && dadosServico != (null, null, null))
            {
                //existe uma possibilidade de dadosServico vir (comDados, null, null)
                if (dadosServico.servico.TipoAparelho == "Celular")
                {
                    AbrirOrdemServicoSaida(Aparelho.Celular, dadosServico.servico, dadosServico.condF,
                        dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Computador")
                {
                    AbrirOrdemServicoSaida(Aparelho.Computador, dadosServico.servico, dadosServico.condF,
                        dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Notebook")
                {
                    AbrirOrdemServicoSaida(Aparelho.Notebook, dadosServico.servico, dadosServico.condF,
                        dadosServico.chkList);
                }
            }
        }

        private void AbrirOrdemServicoEntrada(Aparelho _tipoAparelho, ServicoEstrutura _servico,
                                              CondicoesFisicasEstrutura _condicoesFisicas
                                              , ChecklistEstrutura _checklist)
        {
            form_OrdemServicoEntrada formOrdemServico =
                new form_OrdemServicoEntrada(_tipoAparelho, _servico.FK_IdCliente, false, corGeral);
            formOrdemServico.lblOrdemServico.Text = $@"OS {_servico.OrdemServico:0000}";
            formOrdemServico.lblDataOrdemServico.Text = $@"{_servico.DataServico:G}";
            formOrdemServico.lblIdCliente.Text = _servico.FK_IdCliente.ToString();
            formOrdemServico.lblIdServico.Text = _servico.ID.ToString();
            formOrdemServico.dtpDataServico.Value = _servico.DataServico;
            formOrdemServico.cmbMarca.Text = _servico.Marca;
            formOrdemServico.txtModelo.Text = _servico.Aparelho;
            formOrdemServico.cmbCor.Text = _servico.Cor;
            formOrdemServico.txtMei_SerialNumber.Text = _servico.MeiSerialNumber;
            formOrdemServico.txtSenhaDispositivo.Text = _servico.Senha;

            //Tenho q adaptar a query pra pegar a senha de padrao
            //formOrdemServico.picSenhaPattern.Image = _servico.SenhaPatternAndroid;
            formOrdemServico.txtObservacoes.Text = _servico.Situacao;
            formOrdemServico.txtRelatoCliente.Text = _servico.RelatoCliente;

            //formOrdemServico.txtCondicoesBalcao.Text = _servico.CondicoesBalcao;  //teste
            formOrdemServico.cmbStatusServico.Text = _servico.AvaliacaoServico;

            if (_condicoesFisicas != null)
            {
                //Condicioes Fisicas
                formOrdemServico.cmbPelicula.Text = _condicoesFisicas.Pelicula;
                formOrdemServico.cmbTela.Text = _condicoesFisicas.Tela;
                formOrdemServico.cmbTampa.Text = _condicoesFisicas.Tampa;
                formOrdemServico.cmbAro.Text = _condicoesFisicas.Aro;
                formOrdemServico.cmbBotoes.Text = _condicoesFisicas.Botoes;
                formOrdemServico.cmbLenteCamera.Text = _condicoesFisicas.LenteCamera;
                formOrdemServico.lblIdCondicoesFisicas.Text = _condicoesFisicas.ID.ToString();
            }
            else
            {
                formOrdemServico.lblIdCondicoesFisicas.Text = "";
                formOrdemServico.cmbPelicula.Text = "";
                formOrdemServico.cmbTela.Text = "";
                formOrdemServico.cmbTampa.Text = "";
                formOrdemServico.cmbAro.Text = "";
                formOrdemServico.cmbBotoes.Text = "";
                formOrdemServico.cmbLenteCamera.Text = "";
            }

            if (_checklist != null)
            {
                //Checklist
                formOrdemServico.lblIdChecklist.Text = _checklist.ID.ToString();
                formOrdemServico.cmbChecklistBiometria.Text = _checklist.BiometriaFaceID;
                formOrdemServico.cmbChecklistMicrofone.Text = _checklist.Microfone;
                formOrdemServico.cmbChecklistTela.Text = _checklist.Tela;
                formOrdemServico.cmbChecklistChip.Text = _checklist.Chip;
                formOrdemServico.cmbChecklistBotoes.Text = _checklist.Botoes;
                formOrdemServico.cmbChecklistSensor.Text = _checklist.Sensor;
                formOrdemServico.cmbChecklistCameras.Text = _checklist.Cameras;
                formOrdemServico.cmbChecklistAuricular.Text = _checklist.Auricular;
                formOrdemServico.cmbChecklistWifi.Text = _checklist.Wifi;
                formOrdemServico.cmbChecklistAltoFaltante.Text = _checklist.AltoFalante;
                formOrdemServico.cmbChecklistBluetooth.Text = _checklist.Bluetooth;
                formOrdemServico.cmbChecklistCarregamento.Text = _checklist.Carregamento;
                formOrdemServico.txtChecklistObservacoes.Text = _checklist.Observacoes;
                formOrdemServico.switchChecklistAusente.IsOn = _checklist.Ausente;
                formOrdemServico.txtChecklistMotivoAusencia.Text = _checklist.MotivoAusencia;
            }
            else
            {
                //Checklist
                formOrdemServico.lblIdChecklist.Text = "";
                formOrdemServico.cmbChecklistBiometria.Text = "";
                formOrdemServico.cmbChecklistMicrofone.Text = "";
                formOrdemServico.cmbChecklistTela.Text = "";
                formOrdemServico.cmbChecklistChip.Text = "";
                formOrdemServico.cmbChecklistBotoes.Text = "";
                formOrdemServico.cmbChecklistSensor.Text = "";
                formOrdemServico.cmbChecklistCameras.Text = "";
                formOrdemServico.cmbChecklistAuricular.Text = "";
                formOrdemServico.cmbChecklistWifi.Text = "";
                formOrdemServico.cmbChecklistAltoFaltante.Text = "";
                formOrdemServico.cmbChecklistBluetooth.Text = "";
                formOrdemServico.cmbChecklistCarregamento.Text = "";
                formOrdemServico.txtChecklistObservacoes.Text = "";
                formOrdemServico.switchChecklistAusente.IsOn = false;
                formOrdemServico.txtChecklistMotivoAusencia.Text = "";
                ;
            }

            formOrdemServico.ShowDialog();
            gridviewServicos.RefreshData();
        }

        private void AbrirOrdemServicoSaida(Aparelho _tipoAparelho, ServicoEstrutura _servico,
                                            CondicoesFisicasEstrutura _condicoesFisicas, ChecklistEstrutura _checklist)
        {
            form_OrdemServicoSaida formOrdemServico = new form_OrdemServicoSaida();

            //form_OrdemServicoSaida formOrdemServico = new form_OrdemServicoSaida(_tipoAparelho, _servico.FK_IdCliente, false, corGeral);
            formOrdemServico.lblOrdemServico.Text = $@"OS {_servico.OrdemServico:0000}";
            formOrdemServico.lblDataOrdemServico.Text = $@"{_servico.DataServico:G}";
            formOrdemServico.lblIdCliente.Text = _servico.FK_IdCliente.ToString();
            formOrdemServico.lblIdServico.Text = _servico.ID.ToString();
            formOrdemServico.dtpDataServico.Value = _servico.DataServico;
            formOrdemServico.cmbMarca.Text = _servico.Marca;
            formOrdemServico.txtModelo.Text = _servico.Aparelho;
            formOrdemServico.cmbCor.Text = _servico.Cor;
            formOrdemServico.txtMei_SerialNumber.Text = _servico.MeiSerialNumber;
            formOrdemServico.txtSenhaDispositivo.Text = _servico.Senha;

            //Tenho q adaptar a query pra pegar a senha de padrao
            //formOrdemServico.picSenhaPattern.Image = _servico.SenhaPatternAndroid;
            formOrdemServico.txtObservacoes.Text = _servico.Situacao;
            formOrdemServico.txtSolucao.Text = _servico.Solucao;
            formOrdemServico.cmbStatusServico.Text = _servico.AvaliacaoServico;
            formOrdemServico.cmbStatusServico.Enabled = false;


            if (_tipoAparelho == Aparelho.Computador || _tipoAparelho == Aparelho.Notebook)
            {
                foreach (var control in formOrdemServico.group_CondicoesFisicas.Controls)
                {
                    if (control is BunifuDropdown)
                    {
                        var teste = (BunifuDropdown)control;
                        teste.Enabled = false;
                    }
                }

                foreach (var control in formOrdemServico.group_Checklist.Controls)
                {
                    if (control is BunifuDropdown)
                    {
                        var teste = (BunifuDropdown)control;
                        teste.Enabled = false;
                    }
                    else if (control is RichTextBox)
                    {
                        var teste = (RichTextBox)control;
                        teste.Enabled = false;
                    }

                    formOrdemServico.switchChecklistAusente.Enabled = false;
                    formOrdemServico.cmbMarca.Enabled = false;
                    formOrdemServico.txtModelo.Enabled = false;
                    formOrdemServico.cmbCor.Enabled = false;
                    formOrdemServico.txtMei_SerialNumber.Enabled = false;
                }
            }

            if (_tipoAparelho == Aparelho.Celular)
            {
                if (_condicoesFisicas != null)
                {
                    //Condicioes Fisicas
                    formOrdemServico.cmbPelicula.Text = _condicoesFisicas.Pelicula;
                    formOrdemServico.cmbTela.Text = _condicoesFisicas.Tela;
                    formOrdemServico.cmbTampa.Text = _condicoesFisicas.Tampa;
                    formOrdemServico.cmbAro.Text = _condicoesFisicas.Aro;
                    formOrdemServico.cmbBotoes.Text = _condicoesFisicas.Botoes;
                    formOrdemServico.cmbLenteCamera.Text = _condicoesFisicas.LenteCamera;
                    formOrdemServico.lblIdCondicoesFisicas.Text = _condicoesFisicas.ID.ToString();
                }
                else
                {
                    formOrdemServico.lblIdCondicoesFisicas.Text = "";
                    formOrdemServico.cmbPelicula.Text = "";
                    formOrdemServico.cmbTela.Text = "";
                    formOrdemServico.cmbTampa.Text = "";
                    formOrdemServico.cmbAro.Text = "";
                    formOrdemServico.cmbBotoes.Text = "";
                    formOrdemServico.cmbLenteCamera.Text = "";
                }


                if (_checklist != null)
                {
                    //Checklist
                    formOrdemServico.lblIdChecklist.Text = _checklist.ID.ToString();
                    formOrdemServico.cmbChecklistBiometria.Text = _checklist.BiometriaFaceID;
                    formOrdemServico.cmbChecklistMicrofone.Text = _checklist.Microfone;
                    formOrdemServico.cmbChecklistTela.Text = _checklist.Tela;
                    formOrdemServico.cmbChecklistChip.Text = _checklist.Chip;
                    formOrdemServico.cmbChecklistBotoes.Text = _checklist.Botoes;
                    formOrdemServico.cmbChecklistSensor.Text = _checklist.Sensor;
                    formOrdemServico.cmbChecklistCameras.Text = _checklist.Cameras;
                    formOrdemServico.cmbChecklistAuricular.Text = _checklist.Auricular;
                    formOrdemServico.cmbChecklistWifi.Text = _checklist.Wifi;
                    formOrdemServico.cmbChecklistAltoFaltante.Text = _checklist.AltoFalante;
                    formOrdemServico.cmbChecklistBluetooth.Text = _checklist.Bluetooth;
                    formOrdemServico.cmbChecklistCarregamento.Text = _checklist.Carregamento;
                    formOrdemServico.txtChecklistObservacoes.Text = _checklist.Observacoes;
                    formOrdemServico.switchChecklistAusente.IsOn = _checklist.Ausente;

                    if (_checklist.Ausente == true)
                    {
                        formOrdemServico.txtChecklistMotivoAusencia.BackColor = Color.FromArgb(64, 64, 64);
                        formOrdemServico.txtChecklistMotivoAusencia.Text = string.Empty;
                        formOrdemServico.txtChecklistMotivoAusencia.ReadOnly = true;
                    }
                    else
                    {
                        formOrdemServico.txtChecklistMotivoAusencia.BackColor = Color.FromArgb(23, 23, 36);
                        formOrdemServico.txtChecklistMotivoAusencia.ReadOnly = false;
                        formOrdemServico.txtChecklistMotivoAusencia.Text = _checklist.MotivoAusencia;
                    }
                }
                else
                {
                    //Checklist
                    formOrdemServico.lblIdChecklist.Text = "";
                    formOrdemServico.cmbChecklistBiometria.Text = "";
                    formOrdemServico.cmbChecklistMicrofone.Text = "";
                    formOrdemServico.cmbChecklistTela.Text = "";
                    formOrdemServico.cmbChecklistChip.Text = "";
                    formOrdemServico.cmbChecklistBotoes.Text = "";
                    formOrdemServico.cmbChecklistSensor.Text = "";
                    formOrdemServico.cmbChecklistCameras.Text = "";
                    formOrdemServico.cmbChecklistAuricular.Text = "";
                    formOrdemServico.cmbChecklistWifi.Text = "";
                    formOrdemServico.cmbChecklistAltoFaltante.Text = "";
                    formOrdemServico.cmbChecklistBluetooth.Text = "";
                    formOrdemServico.cmbChecklistCarregamento.Text = "";
                    formOrdemServico.txtChecklistObservacoes.Text = "";
                    formOrdemServico.switchChecklistAusente.IsOn = false;
                    formOrdemServico.txtChecklistMotivoAusencia.Text = "";
                    ;
                }
            }


            formOrdemServico.cmbCliente.Enabled = false;
            formOrdemServico.ShowDialog();
            PopularGridview();
        }

        private void btnRemoverServico_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show(
                    "Deseja mesmo remover esse serviço? todas informações dele serão removidas tambem como checklist, ordem de servico e garantias!"
                    ,
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Pegando os dados da linha que o usuario clicou
                var servico = BuscarDadosLinhaSelecionada();

                //Pegando todos os dados necessarios com base na ID
                int idServico = Convert.ToInt32(servico[0]);
                deletarDados.DeletarServico(idServico);
                PopularGridview();
            }
        }

        private void btnEditarListaPeçasCompradas_ItemClick(object sender, ItemClickEventArgs e)
        {
            var servico = BuscarDadosLinhaSelecionada();

            int idServico = Convert.ToInt32(servico[0]);
            int ordemServico = Convert.ToInt32(servico[4]);

            form_Compras formCompra = new form_Compras(ordemServico, idServico);
            formCompra.lblIdServico.Text = idServico.ToString();
            formCompra.cmbOrdemServico.Enabled = false;
            formCompra.ShowDialog();
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            AbrirOSEntradaForm(Aparelho.Celular);
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            //Nao esta em uso
            AbrirOSEntradaForm(Aparelho.Notebook);
        }

        private void btnComputador_Click(object sender, EventArgs e)
        {
            //Nao esta em uso
            AbrirOSEntradaForm(Aparelho.Computador);
        }

        private void AbrirOSEntradaForm(Aparelho _tipoAparelho)
        {
            form_OrdemServicoEntrada ordemServico =
                new form_OrdemServicoEntrada(_tipoAparelho, 0, true, new[] { 255, 0, 103 });
            ordemServico.switchChecklistAusente.IsOn = false;
            ordemServico.txtChecklistMotivoAusencia.BackColor = Color.FromArgb(64, 64, 64);
            ordemServico.txtChecklistMotivoAusencia.ReadOnly = true;
            ordemServico.ShowDialog();
            PopularGridview();
        }

        private void gridctrlServicos_DoubleClick(object sender, EventArgs e)
        {
            EditarServicoV2();
            PopularGridview();
        }
    }
}