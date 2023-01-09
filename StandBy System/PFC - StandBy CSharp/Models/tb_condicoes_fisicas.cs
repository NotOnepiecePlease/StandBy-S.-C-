﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC___StandBy_CSharp.Models
{
    public partial class tb_condicoes_fisicas
    {
        [Key]
        public int cf_id { get; set; }
        public int cf_ordem_serv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime cf_data { get; set; }
        public int cf_sv_idservico { get; set; }
        [StringLength(50)]
        public string cf_pelicula { get; set; }
        [StringLength(50)]
        public string cf_tela { get; set; }
        [StringLength(50)]
        public string cf_tampa { get; set; }
        [StringLength(50)]
        public string cf_aro { get; set; }
        [StringLength(50)]
        public string cf_botoes { get; set; }
        [StringLength(50)]
        public string cf_lente_camera { get; set; }

        [ForeignKey(nameof(cf_sv_idservico))]
        [InverseProperty(nameof(tb_servicos.tb_condicoes_fisicas))]
        public virtual tb_servicos cf_sv_idservicoNavigation { get; set; }
    }
}