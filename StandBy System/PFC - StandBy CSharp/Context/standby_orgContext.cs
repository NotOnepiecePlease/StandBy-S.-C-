﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PFC___StandBy_CSharp.Models;

namespace PFC___StandBy_CSharp.Context
{
    public partial class standby_orgContext : DbContext
    {
        public standby_orgContext()
        {
        }

        public standby_orgContext(DbContextOptions<standby_orgContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tb_checklist> tb_checklist { get; set; }
        public virtual DbSet<tb_clientes> tb_clientes { get; set; }
        public virtual DbSet<tb_comp_items> tb_comp_items { get; set; }
        public virtual DbSet<tb_condicoes_fisicas> tb_condicoes_fisicas { get; set; }
        public virtual DbSet<tb_garantias> tb_garantias { get; set; }
        public virtual DbSet<tb_gastos> tb_gastos { get; set; }
        public virtual DbSet<tb_orcamento> tb_orcamento { get; set; }
        public virtual DbSet<tb_servicos> tb_servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=standby_org;Persist Security Info=True;User ID=sa;Password=123adr;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_checklist>(entity =>
            {
                entity.HasKey(e => e.ch_id)
                    .HasName("PK_TB_CHECKLIST");

                entity.Property(e => e.ch_altofalante).IsUnicode(false);

                entity.Property(e => e.ch_auricular).IsUnicode(false);

                entity.Property(e => e.ch_biometria_faceid).IsUnicode(false);

                entity.Property(e => e.ch_bluetooth).IsUnicode(false);

                entity.Property(e => e.ch_botoes).IsUnicode(false);

                entity.Property(e => e.ch_cameras).IsUnicode(false);

                entity.Property(e => e.ch_carregamento).IsUnicode(false);

                entity.Property(e => e.ch_chip).IsUnicode(false);

                entity.Property(e => e.ch_microfone).IsUnicode(false);

                entity.Property(e => e.ch_motivo_ausencia).IsUnicode(false);

                entity.Property(e => e.ch_observacoes).IsUnicode(false);

                entity.Property(e => e.ch_sensor).IsUnicode(false);

                entity.Property(e => e.ch_tela).IsUnicode(false);

                entity.Property(e => e.ch_tipo).IsUnicode(false);

                entity.Property(e => e.ch_wifi).IsUnicode(false);

                entity.HasOne(d => d.ch_sv_idservicoNavigation)
                    .WithMany(p => p.tb_checklist)
                    .HasForeignKey(d => d.ch_sv_idservico)
                    .HasConstraintName("tb_checklist_fk0");
            });

            modelBuilder.Entity<tb_clientes>(entity =>
            {
                entity.HasKey(e => e.cl_id)
                    .HasName("pk_tb_clientes");

                entity.Property(e => e.cl_bairro).IsUnicode(false);

                entity.Property(e => e.cl_cep).IsUnicode(false);

                entity.Property(e => e.cl_cidade).IsUnicode(false);

                entity.Property(e => e.cl_complemento).IsUnicode(false);

                entity.Property(e => e.cl_cpf)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SEM CPF')");

                entity.Property(e => e.cl_endereco).IsUnicode(false);

                entity.Property(e => e.cl_estado).IsUnicode(false);

                entity.Property(e => e.cl_nome).IsUnicode(false);

                entity.Property(e => e.cl_nome_recado).IsUnicode(false);

                entity.Property(e => e.cl_parentesco_recado).IsUnicode(false);

                entity.Property(e => e.cl_sexo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cl_telefone)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('------------')");

                entity.Property(e => e.cl_telefone_recado)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('------------')");
            });

            modelBuilder.Entity<tb_comp_items>(entity =>
            {
                entity.HasKey(e => e.item_id)
                    .HasName("PK_TB_COMP_ITEMS");

                entity.Property(e => e.item_grupo).IsUnicode(false);

                entity.Property(e => e.item_nome).IsUnicode(false);

                entity.Property(e => e.item_tela).IsUnicode(false);

                entity.Property(e => e.item_texto).IsUnicode(false);
            });

            modelBuilder.Entity<tb_condicoes_fisicas>(entity =>
            {
                entity.HasKey(e => e.cf_id)
                    .HasName("PK_TB_CONDICOES_FISICAS");

                entity.Property(e => e.cf_aro).IsUnicode(false);

                entity.Property(e => e.cf_botoes).IsUnicode(false);

                entity.Property(e => e.cf_lente_camera).IsUnicode(false);

                entity.Property(e => e.cf_pelicula).IsUnicode(false);

                entity.Property(e => e.cf_tampa).IsUnicode(false);

                entity.Property(e => e.cf_tela).IsUnicode(false);

                entity.HasOne(d => d.cf_sv_idservicoNavigation)
                    .WithMany(p => p.tb_condicoes_fisicas)
                    .HasForeignKey(d => d.cf_sv_idservico)
                    .HasConstraintName("tb_condicoes_fisicas_fk0");
            });

            modelBuilder.Entity<tb_garantias>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.gar_id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tb_gastos>(entity =>
            {
                entity.HasKey(e => e.gst_id)
                    .HasName("pk_tb_gastos");

                entity.Property(e => e.gst_ativo).HasDefaultValueSql("((1))");

                entity.Property(e => e.gst_produto).IsUnicode(false);

                entity.Property(e => e.gst_valor).HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<tb_orcamento>(entity =>
            {
                entity.HasKey(e => e.orc_id)
                    .HasName("pk_tb_orcamento");

                entity.Property(e => e.orc_aparelho).IsUnicode(false);

                entity.Property(e => e.orc_modelo).IsUnicode(false);

                entity.Property(e => e.orc_valor).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.total).HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<tb_servicos>(entity =>
            {
                entity.HasKey(e => e.sv_id)
                    .HasName("pk_tb_servicos");

                entity.HasIndex(e => e.sv_cl_idcliente)
                    .HasName("tb_servicos_fk0");

                entity.Property(e => e.sv_acessorios)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----------------')");

                entity.Property(e => e.sv_aparelho)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----------------')");

                entity.Property(e => e.sv_ativo).HasDefaultValueSql("((1))");

                entity.Property(e => e.sv_avaliacao_servico).IsUnicode(false);

                entity.Property(e => e.sv_condicoes_balcao).IsUnicode(false);

                entity.Property(e => e.sv_cor).IsUnicode(false);

                entity.Property(e => e.sv_defeito)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----------------')");

                entity.Property(e => e.sv_lucro).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.sv_marca).IsUnicode(false);

                entity.Property(e => e.sv_mei_serialnumber).IsUnicode(false);

                entity.Property(e => e.sv_relato_cliente).IsUnicode(false);

                entity.Property(e => e.sv_senha)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----------------')");

                entity.Property(e => e.sv_servico)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----------------')");

                entity.Property(e => e.sv_situacao)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-----------------')");

                entity.Property(e => e.sv_solucao).IsUnicode(false);

                entity.Property(e => e.sv_status).HasDefaultValueSql("((1))");

                entity.Property(e => e.sv_tempo_para_entregar).IsUnicode(false);

                entity.Property(e => e.sv_tipo_aparelho).IsUnicode(false);

                entity.Property(e => e.sv_valorpeca).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.sv_valorservico).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.sv_cl_idclienteNavigation)
                    .WithMany(p => p.tb_servicos)
                    .HasForeignKey(d => d.sv_cl_idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_servicos_fk0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}