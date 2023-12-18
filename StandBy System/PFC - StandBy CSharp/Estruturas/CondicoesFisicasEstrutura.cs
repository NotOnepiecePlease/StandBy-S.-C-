using System;

namespace PFC___StandBy_CSharp.Models
{
    public class CondicoesFisicasEstrutura
    {
        public int? ID { get; set; } = null;
        public int? OrdemServico { get; set; } = null;
        public DateTime? DataCondicoesFisicas { get; set; } = null;
        public int? FK_IdServico { get; set; } = null;
        public string Tipo { get; set; } = null;
        public string Pelicula { get; set; } = null;
        public string Tela { get; set; } = null;
        public string Tampa { get; set; } = null;
        public string Aro { get; set; } = null;
        public string Botoes { get; set; } = null;
        public string LenteCamera { get; set; } = null;
    }
}