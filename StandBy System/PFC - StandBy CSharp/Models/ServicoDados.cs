using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Models
{
    public class ServicoDados
    {
        public int? ID { get; set; } = null;
        public int? OrdemServico { get; set; } = null;
        public DateTime? DataServico { get; set; } = null;
        public int? FK_IdCliente { get; set; } = null;
        public string TipoAparelho { get; set; } = null;
        public string Aparelho { get; set; } = null;
        public string Defeito { get; set; } = null;
        public string Servico { get; set; } = null;
        public string Senha { get; set; } = null;
        public string Situacao { get; set; } = null;
        public string Acessorios { get; set; } = null;
        public decimal? ValorServico { get; set; } = null;
        public decimal? ValorPeca { get; set; } = null;
        public decimal? Lucro { get; set; } = null;

        [Description("0 == Servico Concluido | 1 == Servico Andamento")]
        public int? Status { get; set; } = null;

        public int? Ativo { get; set; } = null;
        public DateTime? DataConclusao { get; set; } = null;
        public DateTime? PrevisaoEntrega { get; set; } = null;

        [Description("1 == Sim | 0 == Nao")]
        public int? ExistePrazo { get; set; } = null;

        public byte[] SenhaPatternAndroid { get; set; } = null;

        [Description("1 = verde | 2 = amarelo/laranja | 3 = vermelho | 4 = sem cor")]
        public int? CorTempo { get; set; } = null;

        public string TempoRestanteParaEntregar { get; set; } = null;
        public string RelatoCliente { get; set; } = null;
        public string Observacoes { get; set; } = null;
        public string AvaliacaoServico { get; set; } = null;
    }
}