﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC___StandBy_CSharp.Models
{
    public partial class tb_gastos
    {
        [Key]
        public int gst_id { get; set; }
        [Column(TypeName = "date")]
        public DateTime gst_data { get; set; }
        [Required]
        [StringLength(100)]
        public string gst_produto { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal gst_valor { get; set; }
        public int gst_temporario { get; set; }
        public int gst_ativo { get; set; }
    }
}