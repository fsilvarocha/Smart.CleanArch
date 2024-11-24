﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smart.CleanArch.Infra.Data;

#nullable disable

namespace Smart.CleanArch.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241124192800_newMigration")]
    partial class newMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Smart.CleanArch.Domain.Entities.Endereco.Enderecos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAtualizado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 11, 24, 16, 28, 0, 40, DateTimeKind.Local).AddTicks(5937));

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 11, 24, 16, 28, 0, 36, DateTimeKind.Local).AddTicks(3746));

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("Smart.CleanArch.Domain.Entities.Pessoa.Pessoas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAtualizado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 11, 24, 16, 28, 0, 44, DateTimeKind.Local).AddTicks(72));

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 11, 24, 16, 28, 0, 43, DateTimeKind.Local).AddTicks(9721));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pessoas", (string)null);
                });

            modelBuilder.Entity("Smart.CleanArch.Domain.Entities.Produto.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAtualizado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 11, 24, 16, 28, 0, 46, DateTimeKind.Local).AddTicks(4387));

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 11, 24, 16, 28, 0, 46, DateTimeKind.Local).AddTicks(3929));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("Smart.CleanArch.Domain.Entities.Endereco.Enderecos", b =>
                {
                    b.HasOne("Smart.CleanArch.Domain.Entities.Pessoa.Pessoas", "Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("Smart.CleanArch.Domain.Entities.Pessoa.Pessoas", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}