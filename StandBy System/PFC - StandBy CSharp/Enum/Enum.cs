using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Enum
{
    /// <summary>
    /// Tipos de aparelho
    /// Tipos de ordem de servico
    /// Tipos de checklist
    /// </summary>
    public class Enum
    {
        public enum Aparelho
        {
            VAZIO,
            Celular,
            Notebook,
            Computador
        }

        public enum OrdemServico
        {
            AtualizarTudo,
            ExisteApenasServico,
            NovaInsercao
        }

        public enum Checklist
        {
            ENTRADA,
            SAIDA
        }
    }
}