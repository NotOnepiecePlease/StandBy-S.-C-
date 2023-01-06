using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Models
{
    public class ServicoEstrutura
    {
        public int? ID { get; set; } = null;
        public int OrdemServico { get; set; }
        public DateTime DataServico { get; set; }
        public int FK_IdCliente { get; set; }

        /// <summary>
        /// Celular, note, computador etc...
        /// </summary>
        public string TipoAparelho { get; set; } = null;

        public string Marca { get; set; } = null;
        public string Aparelho { get; set; } = null;
        public string Cor { get; set; } = null;
        public string MeiSerialNumber { get; set; } = null;
        public string Defeito { get; set; } = null;
        public string Servico { get; set; } = null;
        public string Senha { get; set; } = null;
        public string Situacao { get; set; } = null;
        public string Acessorios { get; set; } = null;
        public decimal ValorServico { get; set; } = 0;
        public decimal ValorPeca { get; set; } = 0;
        public decimal Lucro { get; set; } = 0;

        /// <summary>
        /// 0 == Servico Concluido | 1 == Servico Andamento
        /// </summary>
        [Description("0 == Servico Concluido | 1 == Servico Andamento")]
        public int? Status { get; set; } = null;

        public int? Ativo { get; set; } = null;
        public DateTime? DataConclusao { get; set; } = null;
        public DateTime? PrevisaoEntrega { get; set; } = null;

        /// <summary>
        /// 1 == Sim | 0 == Nao
        /// </summary>
        [Description("1 == Sim | 0 == Nao")]
        public int? ExistePrazo { get; set; } = null;

        public byte[] SenhaPatternAndroid { get; set; } = null;

        /// <summary>
        /// 1 = verde | 2 = amarelo/laranja | 3 = vermelho | 4 = sem cor
        /// </summary>
        [Description("1 = verde | 2 = amarelo/laranja | 3 = vermelho | 4 = sem cor")]
        public int? CorTempo { get; set; } = null;

        public string TempoRestanteParaEntregar { get; set; } = null;
        public string RelatoCliente { get; set; } = null;
        public string CondicoesBalcao { get; set; } = null;
        public string Solucao { get; set; } = null;

        /// <summary>
        /// Avaliacao, completo ou Aprovado
        /// </summary>
        public string AvaliacaoServico { get; set; } = null;
    }
}