using DevExpress.XtraEditors;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Forms._1___Ordems_Servico;
using PFC___StandBy_CSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using NLog;
using static PFC___StandBy_CSharp.Enums.EnumStandby;
using PFC___StandBy_CSharp.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PFC___StandBy_CSharp.Forms.UserControl
{
    public partial class ucTelaPrincipal : DevExpress.XtraEditors.XtraUserControl
    {
        private int rowHandle;
        private GridColumn column;
        private DeletarDados deletarDados = new DeletarDados();
        private BuscarDados buscarDados = new BuscarDados();
        public int[] corGeral = new[] { 255, 0, 103 };
        private NLog.Logger logger = LogManager.GetCurrentClassLogger();
        public ucTelaPrincipal()
        {
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

        private async Task SetarCorColunaOS()
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

        private void btnCelular_Click(object sender, EventArgs e)
        {
            AbrirOSEntradaForm(Aparelho.Celular);
        }

        private void gridctrlServicos_DoubleClick(object sender, EventArgs e)
        {
            EditarServicoV2();
            PopularGridview();
        }

        private IRow BuscarDadosLinhaSelecionada()
        {
            var indexLinhaAtual = gridviewServicos.FocusedRowHandle;
            var dadosDaLinhaAtual = gridviewServicos.GetRow(indexLinhaAtual);
            var servico = dadosDaLinhaAtual as IRow;

            return servico;
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

        private void gridviewServicos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
    }
}
