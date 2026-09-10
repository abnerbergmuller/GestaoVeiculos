using System;
using System.Collections.Generic;
using GestaoVeiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoVeiculos.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LogTransacao> LogTransacoes { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }
    public virtual DbSet<LogErro> LogsErro { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=gestao_veiculos;Username=postgres;Password=postgres")
            .UseSnakeCaseNamingConvention();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LogTransacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("log_transacao_pkey");

            entity.ToTable("log_transacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataHora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.TipoOperacao)
                .HasMaxLength(10)
                .HasColumnName("tipo_operacao");
            entity.Property(e => e.VeiculoId).HasColumnName("veiculo_id");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marca_pkey");

            entity.ToTable("marca");

            entity.HasIndex(e => e.Nome, "uq_marca_nome").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("veiculo_pkey");

            entity.ToTable("veiculo");

            entity.HasIndex(e => e.Placa, "uq_veiculo_placa").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.MarcaId).HasColumnName("marca_id");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .HasColumnName("modelo");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");

            entity.HasOne(d => d.Marca).WithMany()
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_veiculo_marca");
        });


        OnModelCreatingPartial(modelBuilder);
        modelBuilder.Entity<Veiculo>()
            .HasDiscriminator<string>("tipo_veiculo")
            .HasValue<Carro>("Carro")
            .HasValue<Moto>("Moto");
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
