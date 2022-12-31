using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Enum
{
    /// <summary>
    /// 0 = Celular
    /// 1 = Notebook
    /// 2 = Computador
    /// </summary>
    public class Enum
    {
        public enum Aparelho
        {
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
    }
}