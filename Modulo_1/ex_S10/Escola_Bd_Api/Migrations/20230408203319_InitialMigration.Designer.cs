﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Escola_Bd_Api.Migrations
{
    [DbContext(typeof(EscolaDbContext))]
    [Migration("20230408203319_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Escola_Bd_Api.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId1")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("float");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuestionId1");

                    b.HasIndex("StudentId");

                    b.HasIndex("StudentId1");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.HasIndex("TeacherId1");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Enunciation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<int>("QuizId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.HasIndex("QuizId1");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateClose")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOpen")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId1")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("DisciplineId1");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.StudentDiscipline", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("StudentDisciplines");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Student", b =>
                {
                    b.HasBaseType("Escola_Bd_Api.Models.User");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("RA")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Teacher", b =>
                {
                    b.HasBaseType("Escola_Bd_Api.Models.User");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Answer", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Discipline", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Question", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.Quiz", null)
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Quiz", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.Discipline", null)
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.StudentDiscipline", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.Discipline", "Discipline")
                        .WithMany("StudentDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_Bd_Api.Models.Student", "Student")
                        .WithMany("StudentDisciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Student", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Escola_Bd_Api.Models.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Teacher", b =>
                {
                    b.HasOne("Escola_Bd_Api.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Escola_Bd_Api.Models.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Discipline", b =>
                {
                    b.Navigation("StudentDisciplines");
                });

            modelBuilder.Entity("Escola_Bd_Api.Models.Student", b =>
                {
                    b.Navigation("StudentDisciplines");
                });
#pragma warning restore 612, 618
        }
    }
}
