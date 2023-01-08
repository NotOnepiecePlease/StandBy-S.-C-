﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Models;
using static PFC___StandBy_CSharp.Enum.Enum;

// ReSharper disable InconsistentNaming

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_ServicoPrincipal : Form
    {
        //rowHandle e column servem pra mostrar o popup menu no grid servicos
        private int rowHandle;

        private GridColumn column;
        private BuscarDados buscarDados = new BuscarDados();
        public int[] corGeral = new[] { 0, 0, 0 };

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
        }

        // ReSharper disable once InconsistentNaming
        private async Task SetarCorColunaOS()
        {
            gridviewServicos.CustomColumnDisplayText += (sender, e) =>
            {
                if (e.Column.Name == "gridcol_Prazo")
                {
                    var indexLinhaAtual = gridviewServicos.GetRowHandle(e.ListSourceRowIndex);
                    var dadosDaLinhaAtual = gridviewServicos.GetRow(indexLinhaAtual);
                    var servico = dadosDaLinhaAtual as IRow;
                    DateTime dataCad = DateTime.MinValue;
                    DateTime dataPrev = DateTime.MinValue;
                    try
                    {
                        if (servico != null)
                        {
                            //if (servico[0].ToString() == "34002")
                            //{
                            //}
                            dataCad = Convert.ToDateTime(servico[1]);
                            dataPrev = Convert.ToDateTime(servico[6]);

                            if (dataPrev != DateTime.MinValue)
                            {
                                TimeSpan r = dataPrev.Subtract(dataCad);
                                e.DisplayText = $"{r.TotalDays}";
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
                        Console.WriteLine(exception);
                    }
                }
            };
        }

        private void LimparLinhasSelecionadasGrid(object sender, EventArgs e)
        {
            gridviewServicos.ClearSelection();
            gridviewServicos.LayoutChanged();
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            form_OrdemServicoEntrada ordemServico = new form_OrdemServicoEntrada(Aparelho.Celular, 0, true, corGeral);
            ordemServico.ShowDialog();
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
                    if (servico != null /*&& dataCad != DateTime.MinValue && dataPrev != DateTime.MinValue*/)
                    {
                        dataCad = Convert.ToDateTime(servico[1]);
                        dataPrev = Convert.ToDateTime(servico[6]);
                        TimeSpan r = dataPrev.Subtract(dataCad);

                        e.Appearance.BackColor = r.TotalDays > 20 ? Color.Green : Color.DeepSkyBlue;

                        //Linha que demorei dias pra encontrar, aqui voce seta a aparencia da celula como prioridade maxima, nenhum evento pode modificar
                        //veja o ranking aqui: https://docs.devexpress.com/WindowsForms/114444/Common-Features/Application-Appearance-and-Skin-Colors
                        e.Column.AppearanceCell.Options.HighPriority = true;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Chartreuse;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Erro Cor GRID: {exception}");
                }
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
            EditarUmServico();
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
            (ServicoEstrutura servico, CondicoesFisicasEstrutura condF, ChecklistEstrutura chkList) dadosServico = buscarDados.BuscarOS(idServico);

            if (string.IsNullOrWhiteSpace(dadosServico.servico.TipoAparelho))
            {
                MessageBox.Show("Necessario editar o aparelho e definir o seu tipo para ter acesso a O.S \n\nTipos existentes: Celular, Notebook ou Computador!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (servico != null && dadosServico != (null, null, null))
            {
                //existe uma possibilidade de dadosServico vir (comDados, null, null)
                if (dadosServico.servico.TipoAparelho == "Celular")
                {
                    AbrirOrdemServicoEntrada(Aparelho.Celular, dadosServico.servico, dadosServico.condF, dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Computador")
                {
                    AbrirOrdemServicoEntrada(Aparelho.Computador, dadosServico.servico, dadosServico.condF, dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Notebook")
                {
                    AbrirOrdemServicoEntrada(Aparelho.Notebook, dadosServico.servico, dadosServico.condF, dadosServico.chkList);
                }
            }
        }

        private void btnEditarOrdemServicoSaida_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Pegando os dados da linha que o usuario clicou
            var servico = BuscarDadosLinhaSelecionada();

            //Pegando todos os dados necessarios com base na ID
            int idServico = Convert.ToInt32(servico[0]);
            (ServicoEstrutura servico, CondicoesFisicasEstrutura condF, ChecklistEstrutura chkList) dadosServico = buscarDados.BuscarOS(idServico);

            if (string.IsNullOrWhiteSpace(dadosServico.servico.TipoAparelho))
            {
                MessageBox.Show("Necessario editar o aparelho e definir o seu tipo para ter acesso a O.S \n\nTipos existentes: Celular, Notebook ou Computador!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (servico != null && dadosServico != (null, null, null))
            {
                //existe uma possibilidade de dadosServico vir (comDados, null, null)
                if (dadosServico.servico.TipoAparelho == "Celular")
                {
                    AbrirOrdemServicoSaida(Aparelho.Celular, dadosServico.servico, dadosServico.condF, dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Computador")
                {
                    AbrirOrdemServicoSaida(Aparelho.Computador, dadosServico.servico, dadosServico.condF, dadosServico.chkList);
                }
                else if (dadosServico.servico.TipoAparelho == "Notebook")
                {
                    AbrirOrdemServicoSaida(Aparelho.Notebook, dadosServico.servico, dadosServico.condF, dadosServico.chkList);
                }
            }
        }

        private void AbrirOrdemServicoEntrada(Aparelho _tipoAparelho, ServicoEstrutura _servico, CondicoesFisicasEstrutura _condicoesFisicas, ChecklistEstrutura _checklist)
        {
            form_OrdemServicoEntrada formOrdemServico = new form_OrdemServicoEntrada(_tipoAparelho, _servico.FK_IdCliente, false, corGeral);
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
            formOrdemServico.txtCondicoesBalcao.Text = _servico.CondicoesBalcao;
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
                formOrdemServico.txtChecklistMotivoAusencia.Text = ""; ;
            }

            formOrdemServico.cmbCliente.Enabled = false;
            formOrdemServico.ShowDialog();
            gridviewServicos.RefreshData();
        }

        private void AbrirOrdemServicoSaida(Aparelho _tipoAparelho, ServicoEstrutura _servico, CondicoesFisicasEstrutura _condicoesFisicas, ChecklistEstrutura _checklist)
        {
            form_OrdemServicoSaida formOrdemServico = new form_OrdemServicoSaida(_tipoAparelho, _servico.FK_IdCliente, false, corGeral);
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
                formOrdemServico.txtChecklistMotivoAusencia.Text = ""; ;
            }

            formOrdemServico.cmbCliente.Enabled = false;
            formOrdemServico.ShowDialog();
            PopularGridview();
        }
    }
}