﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC___StandBy_CSharp.Models
{
    public partial class tb_log
    {
        [Key]
        public int log_id { get; set; }
        public int log_ultima_ordem_servico { get; set; }
    }
}