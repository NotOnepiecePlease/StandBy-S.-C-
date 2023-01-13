namespace PFC___StandBy_CSharp.Enums
{
    /// <summary>
    /// Tipos de aparelho
    /// Tipos de ordem de servico
    /// Tipos de checklist
    /// </summary>
    public class EnumStandby
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