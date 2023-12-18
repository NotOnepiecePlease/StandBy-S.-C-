using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.Utils;
using System.Collections.Generic;
using System.Linq;
using Bunifu.UI.WinForms;
using DevExpress.Utils.Extensions;
using PFC___StandBy_CSharp.Forms;
using PFC___StandBy_CSharp.Forms._1___Ordems_Servico;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_6___Usada_por_Varias_Telas
{
    internal class PreencherComboboxServicos
    {
        #region ORdem de servico - ENTRADA

        public void PreencherInfoAparelho(form_OrdemServicoEntrada _form)
        {
            PreencherCombobox("Marca", _form.cmbMarca, Constantes.opcoes, Constantes.INFOS_APARELHO_ITEM);
            PreencherCombobox("Cor", _form.cmbCor, Constantes.opcoes, Constantes.INFOS_APARELHO_ITEM);
        }

        public void PreencherInfoChecklist(form_OrdemServicoEntrada _form)
        {
            PreencherCombobox("Altofalante", _form.cmbChecklistAltoFaltante, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Auricular", _form.cmbChecklistAuricular, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Biometria", _form.cmbChecklistBiometria, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Bluetooth", _form.cmbChecklistBluetooth, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Botoes", _form.cmbChecklistBotoes, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Cameras", _form.cmbChecklistCameras, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Carregamento", _form.cmbChecklistCarregamento, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Chip", _form.cmbChecklistChip, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Microfone", _form.cmbChecklistMicrofone, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Sensor", _form.cmbChecklistSensor, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Tela", _form.cmbChecklistTela, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Wifi", _form.cmbChecklistWifi, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
        }

        public void PreencherInfoCondFisicas(form_OrdemServicoEntrada _form)
        {
            PreencherCombobox("Pelicula", _form.cmbPelicula, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Tela", _form.cmbTela, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Tampa", _form.cmbTampa, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Aro", _form.cmbAro, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Botoes", _form.cmbBotoes, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("LenteCamera", _form.cmbLenteCamera, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
        }

        #endregion ORdem de servico - ENTRADA

        #region Ordem de servico - SAIDA

        public void PreencherInfoAparelho(form_OrdemServicoSaida _form)
        {
            PreencherCombobox("Marca", _form.cmbMarca, Constantes.opcoes, Constantes.INFOS_APARELHO_ITEM);
            PreencherCombobox("Cor", _form.cmbCor, Constantes.opcoes, Constantes.INFOS_APARELHO_ITEM);
        }

        public void PreencherInfoChecklist(form_OrdemServicoSaida _form)
        {
            PreencherCombobox("Altofalante", _form.cmbChecklistAltoFaltante, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Auricular", _form.cmbChecklistAuricular, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Biometria", _form.cmbChecklistBiometria, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Bluetooth", _form.cmbChecklistBluetooth, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Botoes", _form.cmbChecklistBotoes, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Cameras", _form.cmbChecklistCameras, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Carregamento", _form.cmbChecklistCarregamento, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Chip", _form.cmbChecklistChip, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Microfone", _form.cmbChecklistMicrofone, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Sensor", _form.cmbChecklistSensor, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Tela", _form.cmbChecklistTela, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
            PreencherCombobox("Wifi", _form.cmbChecklistWifi, Constantes.opcoes, Constantes.CHECKLIST_ITEM);
        }

        public void PreencherInfoCondFisicas(form_OrdemServicoSaida _form)
        {
            PreencherCombobox("Pelicula", _form.cmbPelicula, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Tela", _form.cmbTela, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Tampa", _form.cmbTampa, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Aro", _form.cmbAro, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Botoes", _form.cmbBotoes, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("LenteCamera", _form.cmbLenteCamera, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
        }

        #endregion Ordem de servico - SAIDA

        #region Ordem de servico - EDICAO

        public void PreencherInfoAparelho(form_OrdemServicoEditar _form)
        {
            PreencherCombobox("Marca", _form.cmbMarca, Constantes.opcoes, Constantes.INFOS_APARELHO_ITEM);
            PreencherCombobox("Cor", _form.cmbCor, Constantes.opcoes, Constantes.INFOS_APARELHO_ITEM);
        }

        public void PreencherInfoCondFisicas(form_OrdemServicoEditar _form)
        {
            PreencherCombobox("Pelicula", _form.cmbPelicula, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Tela", _form.cmbTela, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Tampa", _form.cmbTampa, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Aro", _form.cmbAro, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("Botoes", _form.cmbBotoes, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
            PreencherCombobox("LenteCamera", _form.cmbLenteCamera, Constantes.opcoes, Constantes.CONDICOES_FISICAS_ITEM);
        }

        #endregion Ordem de servico - EDICAO

        private void PreencherCombobox(string _itemNome, BunifuDropdown _comboBox, List<tb_comp_items> _dados, string _itemGrupo)
        {
            _dados.Where(y => y.item_tela == Constantes.ORDEM_SERVICO_ENTRADA
                              && y.item_grupo == _itemGrupo
                              && y.item_nome == _itemNome)
                .ForEach(x => _comboBox.Items.Add(x.item_texto));
        }
    }
}