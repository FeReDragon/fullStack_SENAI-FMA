﻿// <auto-generated />
using System;
using BercarioAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BerçarioAPI.Migrations
{
    [DbContext(typeof(BercarioContext))]
    partial class BercarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BercarioAPI.Models.Bebe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Nasc")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ID_Parto")
                        .HasColumnType("int");

                    b.Property<int>("ID_mae")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso_nasc")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ID");

                    b.HasIndex("ID_Parto");

                    b.HasIndex("ID_mae");

                    b.ToTable("Bebes");
                });

            modelBuilder.Entity("BercarioAPI.Models.Mae", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Nasc")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Maes");
                });

            modelBuilder.Entity("BercarioAPI.Models.Medico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("ID");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("BercarioAPI.Models.Parto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Parto")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Horario_Parto")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ID_Medico")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Medico");

                    b.ToTable("Partos");
                });

            modelBuilder.Entity("BercarioAPI.Models.Bebe", b =>
                {
                    b.HasOne("BercarioAPI.Models.Parto", "Parto")
                        .WithMany("Bebes")
                        .HasForeignKey("ID_Parto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BercarioAPI.Models.Mae", "Mae")
                        .WithMany("Bebes")
                        .HasForeignKey("ID_mae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mae");

                    b.Navigation("Parto");
                });

            modelBuilder.Entity("BercarioAPI.Models.Parto", b =>
                {
                    b.HasOne("BercarioAPI.Models.Medico", "Medico")
                        .WithMany("Partos")
                        .HasForeignKey("ID_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("BercarioAPI.Models.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("BercarioAPI.Models.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("BercarioAPI.Models.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}
