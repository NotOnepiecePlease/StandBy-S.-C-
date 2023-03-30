using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Models;

namespace PFC___StandBy_CSharp.Utils
{
    public static class Constantes
    {
        #region Tipos de checklist
        public const string CHK_ENTRADA = "ENTRADA";
        public const string CHK_SAIDA = "SAIDA";
        #endregion Tipos de checklist

        #region Carregamento das opções de todos os combobox
        private static readonly standby_orgContext context = new standby_orgContext();
        public const string ORDEM_SERVICO_ENTRADA = "ORDEM_SERVICO";
        public const string CHECKLIST_ITEM = "CHECKLIST_ITEM";
        public const string CONDICOES_FISICAS_ITEM = "CONDICOES_FISICAS_ITEM";
        public const string INFOS_APARELHO_ITEM = "INFOS_APARELHO_ITEM";
        public static List<tb_comp_items> opcoes;

        public static void
            IniciarOpcoesChecklistEntrada() //Inicializo no inicio e uso no restante das telas pra ganhar performance
        {
            try
            {
                opcoes = context.tb_comp_items.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO INICIALIZAR: " + e.Message);
            }
        }
        #endregion Carregamento das opções de todos os combobox

        #region Status dos servicos
        //APROVADO
        //AVALIAÇÃO
        //CONCLUÍDO
        //public const string STATUS_AGUARDANDO = "AGUARDANDO";
        public const string STATUS_APROVADO = "APROVADO";
        public const string STATUS_AVALIACAO = "AVALIAÇÃO";
        public const string STATUS_CONCLUIDO = "CONCLUÍDO";
        #endregion
    }
}