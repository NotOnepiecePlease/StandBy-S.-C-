using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using DevExpress.Utils.Extensions;
using PFC___StandBy_CSharp.Context;
using static PFC___StandBy_CSharp.Enum.Enum;

namespace PFC___StandBy_CSharp.Forms._1___Ordems_Servico
{
    public partial class form_InserirEditarChecklist : Form
    {
        private Checklist tipoChecklist;
        private tb_checklist checklistDoServico;
        private bool isNovoChecklist = false;

        public form_InserirEditarChecklist(Checklist _tipoChecklist, bool _isNovoChecklist)
        {
            InitializeComponent();
            tipoChecklist = _tipoChecklist;
            isNovoChecklist = _isNovoChecklist;
            InicializarOpcoesCombobox();
        }

        private void form_InserirEditarChecklist_Shown(object sender, EventArgs e)
        {
            if (isNovoChecklist == false)
            {
                CarregarChecklist();
            }
        }

        private void CarregarChecklist()
        {
            try
            {
                standby_orgContext context = new standby_orgContext();

                string tipoChecklistString = System.Enum.GetName(typeof(Checklist), (int)tipoChecklist);
                checklistDoServico = context.tb_checklist.FirstOrDefault(x => x.ch_sv_idservico == Convert.ToInt32(lblIdServico.Text) && x.ch_tipo == tipoChecklistString);
                cmbChecklistBiometria.Text = checklistDoServico.ch_biometria_faceid ?? string.Empty;
                cmbChecklistMicrofone.Text = checklistDoServico.ch_microfone ?? string.Empty;
                cmbChecklistTela.Text = checklistDoServico.ch_tela ?? string.Empty;
                cmbChecklistChip.Text = checklistDoServico.ch_chip ?? string.Empty;
                cmbChecklistBotoes.Text = checklistDoServico.ch_botoes ?? string.Empty;
                cmbChecklistSensor.Text = checklistDoServico.ch_sensor ?? string.Empty;
                cmbChecklistCameras.Text = checklistDoServico.ch_cameras ?? string.Empty;
                cmbChecklistAuricular.Text = checklistDoServico.ch_auricular ?? string.Empty;
                cmbChecklistWifi.Text = checklistDoServico.ch_wifi ?? string.Empty;
                cmbChecklistAltoFaltante.Text = checklistDoServico.ch_altofalante ?? string.Empty;
                cmbChecklistBluetooth.Text = checklistDoServico.ch_bluetooth ?? string.Empty;
                cmbChecklistCarregamento.Text = checklistDoServico.ch_carregamento ?? string.Empty;
                txtChecklistObservacoes.Text = checklistDoServico.ch_observacoes ?? string.Empty;
                switchChecklistAusente.IsOn = checklistDoServico.ch_ausente;
                txtChecklistMotivoAusencia.Text = checklistDoServico.ch_motivo_ausencia ?? string.Empty;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao carregar checklist \n{e}");
            }
        }

        private void form_InserirEditarChecklist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InicializarOpcoesCombobox()
        {
            PreencherCombobox("Altofalante", cmbChecklistAltoFaltante, Constantes.opcoes);
            PreencherCombobox("Auricular", cmbChecklistAuricular, Constantes.opcoes);
            PreencherCombobox("Biometria", cmbChecklistBiometria, Constantes.opcoes);
            PreencherCombobox("Bluetooth", cmbChecklistBluetooth, Constantes.opcoes);
            PreencherCombobox("Botoes", cmbChecklistBotoes, Constantes.opcoes);
            PreencherCombobox("Cameras", cmbChecklistCameras, Constantes.opcoes);
            PreencherCombobox("Carregamento", cmbChecklistCarregamento, Constantes.opcoes);
            PreencherCombobox("Chip", cmbChecklistChip, Constantes.opcoes);
            PreencherCombobox("Microfone", cmbChecklistMicrofone, Constantes.opcoes);
            PreencherCombobox("Sensor", cmbChecklistSensor, Constantes.opcoes);
            PreencherCombobox("Tela", cmbChecklistTela, Constantes.opcoes);
            PreencherCombobox("Wifi", cmbChecklistWifi, Constantes.opcoes);
        }

        private void PreencherCombobox(string _itemNome, BunifuDropdown _comboBox, List<tb_comp_items> _dados)
        {
            _dados.Where(y => y.item_tela == Constantes.ORDEM_SERVICO_ENTRADA
                              && y.item_grupo == Constantes.CHECKLIST_ITEM
                              && y.item_nome == _itemNome)
                .ForEach(x => _comboBox.Items.Add(x.item_texto));
        }

        private void btnSalvarChecklist_Click(object sender, EventArgs e)
        {
            if (isNovoChecklist == true)
            {
                //Fazer insert
                standby_orgContext context = new standby_orgContext();

                tb_checklist checklist = new tb_checklist();
                string tipoChecklistString = System.Enum.GetName(typeof(Checklist), (int)tipoChecklist);
                checklist.ch_ordem_serv = Convert.ToInt32(lblOrdemServico.Text);
                checklist.ch_data = Convert.ToDateTime(lblDataCad.Text);
                checklist.ch_sv_idservico = Convert.ToInt32(lblIdServico.Text);
                checklist.ch_tipo = tipoChecklistString;
                checklist.ch_biometria_faceid = string.IsNullOrWhiteSpace(cmbChecklistBiometria.Text) ? null : cmbChecklistBiometria.Text;
                checklist.ch_microfone = string.IsNullOrWhiteSpace(cmbChecklistMicrofone.Text) ? null : cmbChecklistMicrofone.Text;
                checklist.ch_tela = string.IsNullOrWhiteSpace(cmbChecklistTela.Text) ? null : cmbChecklistTela.Text;
                checklist.ch_chip = string.IsNullOrWhiteSpace(cmbChecklistChip.Text) ? null : cmbChecklistChip.Text;
                checklist.ch_botoes = string.IsNullOrWhiteSpace(cmbChecklistBotoes.Text) ? null : cmbChecklistBotoes.Text;
                checklist.ch_sensor = string.IsNullOrWhiteSpace(cmbChecklistSensor.Text) ? null : cmbChecklistSensor.Text;
                checklist.ch_cameras = string.IsNullOrWhiteSpace(cmbChecklistCameras.Text) ? null : cmbChecklistCameras.Text;
                checklist.ch_auricular = string.IsNullOrWhiteSpace(cmbChecklistAuricular.Text) ? null : cmbChecklistAuricular.Text;
                checklist.ch_wifi = string.IsNullOrWhiteSpace(cmbChecklistWifi.Text) ? null : cmbChecklistWifi.Text;
                checklist.ch_altofalante = string.IsNullOrWhiteSpace(cmbChecklistAltoFaltante.Text) ? null : cmbChecklistAltoFaltante.Text;
                checklist.ch_bluetooth = string.IsNullOrWhiteSpace(cmbChecklistBluetooth.Text) ? null : cmbChecklistBluetooth.Text;
                checklist.ch_carregamento = string.IsNullOrWhiteSpace(cmbChecklistCarregamento.Text) ? null : cmbChecklistCarregamento.Text; ;
                checklist.ch_observacoes = string.IsNullOrWhiteSpace(txtChecklistObservacoes.Text) ? null : txtChecklistObservacoes.Text;
                checklist.ch_ausente = switchChecklistAusente.IsOn;
                checklist.ch_motivo_ausencia = string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text) ? null : txtChecklistMotivoAusencia.Text;

                context.tb_checklist.Add(checklist);
                context.SaveChanges();
                MessageBox.Show($@"OS:{lblOrdemServico.Text} - Checklist inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Pegar id do servico e alterar o checklist
                standby_orgContext context = new standby_orgContext();

                string tipoChecklistString = System.Enum.GetName(typeof(Checklist), (int)tipoChecklist);
                tb_checklist checklist = context.tb_checklist.FirstOrDefault(x => x.ch_sv_idservico == Convert.ToInt32(lblIdServico.Text) && x.ch_tipo == tipoChecklistString);
                checklist.ch_ordem_serv = Convert.ToInt32(lblOrdemServico.Text);
                checklist.ch_data = Convert.ToDateTime(lblDataCad.Text);
                checklist.ch_sv_idservico = Convert.ToInt32(lblIdServico.Text);
                checklist.ch_tipo = tipoChecklistString;
                checklist.ch_biometria_faceid = string.IsNullOrWhiteSpace(cmbChecklistBiometria.Text) ? null : cmbChecklistBiometria.Text;
                checklist.ch_microfone = string.IsNullOrWhiteSpace(cmbChecklistMicrofone.Text) ? null : cmbChecklistMicrofone.Text;
                checklist.ch_tela = string.IsNullOrWhiteSpace(cmbChecklistTela.Text) ? null : cmbChecklistTela.Text;
                checklist.ch_chip = string.IsNullOrWhiteSpace(cmbChecklistChip.Text) ? null : cmbChecklistChip.Text;
                checklist.ch_botoes = string.IsNullOrWhiteSpace(cmbChecklistBotoes.Text) ? null : cmbChecklistBotoes.Text;
                checklist.ch_sensor = string.IsNullOrWhiteSpace(cmbChecklistSensor.Text) ? null : cmbChecklistSensor.Text;
                checklist.ch_cameras = string.IsNullOrWhiteSpace(cmbChecklistCameras.Text) ? null : cmbChecklistCameras.Text;
                checklist.ch_auricular = string.IsNullOrWhiteSpace(cmbChecklistAuricular.Text) ? null : cmbChecklistAuricular.Text;
                checklist.ch_wifi = string.IsNullOrWhiteSpace(cmbChecklistWifi.Text) ? null : cmbChecklistWifi.Text;
                checklist.ch_altofalante = string.IsNullOrWhiteSpace(cmbChecklistAltoFaltante.Text) ? null : cmbChecklistAltoFaltante.Text;
                checklist.ch_bluetooth = string.IsNullOrWhiteSpace(cmbChecklistBluetooth.Text) ? null : cmbChecklistBluetooth.Text;
                checklist.ch_carregamento = string.IsNullOrWhiteSpace(cmbChecklistCarregamento.Text) ? null : cmbChecklistCarregamento.Text; ;
                checklist.ch_observacoes = string.IsNullOrWhiteSpace(txtChecklistObservacoes.Text) ? null : txtChecklistObservacoes.Text;
                checklist.ch_ausente = switchChecklistAusente.IsOn;
                checklist.ch_motivo_ausencia = string.IsNullOrWhiteSpace(txtChecklistMotivoAusencia.Text) ? null : txtChecklistMotivoAusencia.Text;

                context.SaveChanges();
                MessageBox.Show($@"OS:{lblOrdemServico.Text} - Checklist alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void switchChecklistAusente_Toggled(object sender, EventArgs e)
        {
            if (switchChecklistAusente.IsOn == true)
            {
                //MessageBox.Show("Ativado");
                foreach (Control control in this.Controls)
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
                foreach (Control control in this.Controls)
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
    }
}