using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pizzaria33.Models;

public partial class Pizzaria33Context : DbContext
{
    public Pizzaria33Context()
    {
    }

    public Pizzaria33Context(DbContextOptions<Pizzaria33Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Borda> Bordas { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=pizzaria33;user=root;password=****", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Borda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Preco)
                .HasPrecision(10, 2)
                .HasColumnName("preco");
            entity.Property(e => e.Tamanho)
                .HasMaxLength(10)
                .HasColumnName("tamanho");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdStatus, "id_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.EnderecoEntrega)
                .HasMaxLength(100)
                .HasColumnName("endereco_entrega");
            entity.Property(e => e.FormaPagamento)
                .HasMaxLength(20)
                .HasColumnName("forma_pagamento");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pedidos_ibfk_1");

            entity.HasMany(d => d.IdPizzas).WithMany(p => p.IdPedidos)
                .UsingEntity<Dictionary<string, object>>(
                    "PedidoPizza",
                    r => r.HasOne<Pizza>().WithMany()
                        .HasForeignKey("IdPizza")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Pedido_Pizza_ibfk_2"),
                    l => l.HasOne<Pedido>().WithMany()
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Pedido_Pizza_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdPedido", "IdPizza")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("Pedido_Pizza");
                        j.HasIndex(new[] { "IdPizza" }, "id_pizza");
                        j.IndexerProperty<int>("IdPedido").HasColumnName("id_pedido");
                        j.IndexerProperty<int>("IdPizza").HasColumnName("id_pizza");
                    });
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdBorda, "id_borda");

            entity.HasIndex(e => e.IdMassa, "id_massa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdBorda).HasColumnName("id_borda");
            entity.Property(e => e.IdMassa).HasColumnName("id_massa");

            entity.HasOne(d => d.IdBordaNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdBorda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pizzas_ibfk_2");

            entity.HasOne(d => d.IdMassaNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdMassa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pizzas_ibfk_1");

            entity.HasMany(d => d.IdSabors).WithMany(p => p.IdPizzas)
                .UsingEntity<Dictionary<string, object>>(
                    "PizzaSabor",
                    r => r.HasOne<Sabore>().WithMany()
                        .HasForeignKey("IdSabor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Pizza_Sabor_ibfk_2"),
                    l => l.HasOne<Pizza>().WithMany()
                        .HasForeignKey("IdPizza")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Pizza_Sabor_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdPizza", "IdSabor")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("Pizza_Sabor");
                        j.HasIndex(new[] { "IdSabor" }, "id_sabor");
                        j.IndexerProperty<int>("IdPizza").HasColumnName("id_pizza");
                        j.IndexerProperty<int>("IdSabor").HasColumnName("id_sabor");
                    });
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
