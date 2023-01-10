using DevExpress.XtraPrinting;
using PFC___StandBy_CSharp.Impressao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.Utils;
using static PFC___StandBy_CSharp.Enum.Enum;
using PFC___StandBy_CSharp.PreencherComponentes.Tela_6___Usada_por_Varias_Telas;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_OrdemServicoSaida : Form
    {
        private MensagensSucesso ms = new MensagensSucesso();

        public form_OrdemServicoSaida(Aparelho _tipoAparelhoGlobal, int _idClientePreSetado, bool _isNovaOrdemServico, int[] _corGeral)
        {
            InitializeComponent();
            InicializarOpcoesCombobox();
        }

        private void InicializarOpcoesCombobox()
        {
            PreencherComboboxServicos p = new PreencherComboboxServicos();
            //checklist
            p.PreencherInfoChecklist(this);
            //info aparelho
            p.PreencherInfoAparelho(this);
            //cond fisicas
            p.PreencherInfoCondFisicas(this);
        }

        private void btnConcluirImprimir_Click(object sender, EventArgs e)
        {
            SalvarOrdemServicoSaida();
            ImprimirOrdemServicoSaida();
        }

        private void btnConcluirServico_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvarOrdemServico_Click(object sender, EventArgs e)
        {
            SalvarOrdemServicoSaida();
            //ImprimirOrdemServicoSaida();
        }

        private void SalvarOrdemServicoSaida()
        {
            int idServico = Convert.ToInt32(lblIdServico.Text);
            standby_orgContext standbyContext = new standby_orgContext();
            var servico = standbyContext.tb_servicos.Find(idServico);
            servico.sv_marca = string.IsNullOrWhiteSpace(cmbMarca.Text) ? null : cmbMarca.Text;
            servico.sv_aparelho = txtModelo.Text;
            servico.sv_cor = string.IsNullOrWhiteSpace(cmbCor.Text) ? null : cmbCor.Text;
            servico.sv_mei_serialnumber = string.IsNullOrWhiteSpace(txtMei_SerialNumber.Text) ? null : txtMei_SerialNumber.Text;
            servico.sv_senha = txtSenhaDispositivo.Text;
            servico.sv_senha_pattern = picSenhaPattern.Image != null ? ConvertImage.ConvertImageToByte(picSenhaPattern.Image) : null;
            servico.sv_status = 0; //Concluido
            servico.sv_situacao = string.IsNullOrWhiteSpace(txtObservacoes.Text) ? null : txtObservacoes.Text;
            servico.sv_servico = string.IsNullOrWhiteSpace(txtSolucao.Text) ? null : txtSolucao.Text;
            servico.sv_data_conclusao = DateTime.Now;

            var condFisicas = standbyContext.tb_condicoes_fisicas.FirstOrDefault(x => x.cf_sv_idservico == idServico && x.cf_tipo == Constantes.CHK_SAIDA);

            if (condFisicas == null)
            {
                condFisicas = new tb_condicoes_fisicas()
                {
                    cf_ordem_serv = Convert.ToInt32(lblOrdemServico.Text.TrimStart('O', 'S').Trim()),
                    cf_data = servico.sv_data,
                    cf_sv_idservico = idServico,
                    cf_tipo = Constantes.CHK_SAIDA
                };
            }

            condFisicas.cf_pelicula = string.IsNullOrWhiteSpace(cmbPelicula.Text) ? null : cmbPelicula.Text;
            condFisicas.cf_tela = string.IsNullOrWhiteSpace(cmbTela.Text) ? null : cmbTela.Text;
            condFisicas.cf_tampa = string.IsNullOrWhiteSpace(cmbTampa.Text) ? null : cmbTampa.Text;
            condFisicas.cf_aro = string.IsNullOrWhiteSpace(cmbAro.Text) ? null : cmbAro.Text;
            condFisicas.cf_botoes = string.IsNullOrWhiteSpace(cmbBotoes.Text) ? null : cmbBotoes.Text;
            condFisicas.cf_lente_camera = string.IsNullOrWhiteSpace(cmbLenteCamera.Text) ? null : cmbLenteCamera.Text;

            var checklist = standbyContext.tb_checklist.FirstOrDefault(x => x.ch_sv_idservico == idServico && x.ch_tipo == Constantes.CHK_SAIDA);

            if (checklist == null)
            {
                checklist = new tb_checklist
                {
                    ch_ordem_serv = Convert.ToInt32(lblOrdemServico.Text.TrimStart('O', 'S').Trim()),
                    ch_data = servico.sv_data,
                    ch_sv_idservico = idServico,
                    ch_tipo = Constantes.CHK_SAIDA
                };
            }

            checklist.ch_biometria_faceid = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistBiometria.Text) ? null : cmbChecklistBiometria.Text;
            checklist.ch_microfone = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistMicrofone.Text) ? null : cmbChecklistMicrofone.Text;
            checklist.ch_tela = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistTela.Text) ? null : cmbChecklistTela.Text;
            checklist.ch_chip = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistChip.Text) ? null : cmbChecklistChip.Text;
            checklist.ch_botoes = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistBotoes.Text) ? null : cmbChecklistBotoes.Text;
            checklist.ch_sensor = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistSensor.Text) ? null : cmbChecklistSensor.Text;
            checklist.ch_cameras = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistCameras.Text) ? null : cmbChecklistCameras.Text;
            checklist.ch_auricular = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistAuricular.Text) ? null : cmbChecklistAuricular.Text;
            checklist.ch_wifi = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistWifi.Text) ? null : cmbChecklistWifi.Text;
            checklist.ch_altofalante = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistAltoFaltante.Text) ? null : cmbChecklistAltoFaltante.Text;
            checklist.ch_bluetooth = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistBluetooth.Text) ? null : cmbChecklistBluetooth.Text;
            checklist.ch_carregamento = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(cmbChecklistCarregamento.Text) ? null : cmbChecklistCarregamento.Text;
            checklist.ch_observacoes = switchChecklistAusente.IsOn == true ? null : string.IsNullOrWhiteSpace(txtChecklistObservacoes.Text) ? null : txtChecklistObservacoes.Text;

            //Ternario aninhado basicamente para dizer "Se o switch ausente ta on, significa que o valor fica null, caso nao, ele verifica se o campo ta vazio e poem null"
            checklist.ch_ausente = switchChecklistAusente.IsOn;
            checklist.ch_motivo_ausencia = string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text) ? null : txtChecklistMotivoAusencia.Text;

            standbyContext.tb_checklist.Update(checklist);
            standbyContext.tb_servicos.Update(servico);
            standbyContext.tb_condicoes_fisicas.Update(condFisicas);
            standbyContext.SaveChanges();
            ms.ConcluirServicoSucesso();
            this.Close();
        }

        private void TratarValoresNullosChecklist()
        {
        }

        private void ImprimirOrdemServicoSaida()
        {
            if (MessageBox.Show(@"Deseja imprimir a Ordem de Serviço - SAIDA?", @"CONFIRMAÇÃO", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.No)
            {
                try
                {
                    report_OrdemServicoSaida report = new report_OrdemServicoSaida();
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
                    }
                    else if (control.Name == "txtChecklistObservacoes")
                    {
                        var richTextBox = (RichTextBox)control;
                        control.BackColor = Color.FromArgb(64, 64, 64);
                        richTextBox.ReadOnly = true;
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
                }
            }
        }

        private void cmbStatusServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxStatus.MudarCor(cmbStatusServico);
        }

        private void form_OrdemServicoSaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}