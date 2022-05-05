﻿// <auto-generated />
using System;
using GHR.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GHR.Persistence.Migrations
{
    [DbContext(typeof(GHRContext))]
    [Migration("20220504195403_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GHR.Domain.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCargo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("GHR.Domain.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeDepartamento")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("GHR.Domain.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAdmissao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FuncionarioAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("LoginId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LoginId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("TEXT");

                    b.Property<float>("Salario")
                        .HasColumnType("REAL");

                    b.Property<int>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupervisorId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("LoginId1");

                    b.HasIndex("SupervisorId1");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("GHR.Domain.FuncionarioMeta", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FimAcordado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FimRealizado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("InicioAcordado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("InicioRealizado")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MetaCumprida")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FuncionarioId", "MetaId");

                    b.HasIndex("MetaId");

                    b.ToTable("FuncionariosMetas");
                });

            modelBuilder.Entity("GHR.Domain.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("GHR.Domain.Meta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FimPlanejado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FimRealizado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("InicioPlanejado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("InicioRealizado")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MetaAprovada")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MetaCumprida")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeMeta")
                        .HasColumnType("TEXT");

                    b.Property<int>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupervisorId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorId1");

                    b.ToTable("Metas");
                });

            modelBuilder.Entity("GHR.Domain.Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MetaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Supervisores");
                });

            modelBuilder.Entity("GHR.Domain.Funcionario", b =>
                {
                    b.HasOne("GHR.Domain.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId1");

                    b.HasOne("GHR.Domain.Supervisor", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId1");

                    b.Navigation("Cargo");

                    b.Navigation("Departamento");

                    b.Navigation("Login");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("GHR.Domain.FuncionarioMeta", b =>
                {
                    b.HasOne("GHR.Domain.Funcionario", "Funcionario")
                        .WithMany("FuncionariosMetas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.Meta", "Meta")
                        .WithMany("FuncionariosMetas")
                        .HasForeignKey("MetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Meta");
                });

            modelBuilder.Entity("GHR.Domain.Meta", b =>
                {
                    b.HasOne("GHR.Domain.Supervisor", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId1");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("GHR.Domain.Funcionario", b =>
                {
                    b.Navigation("FuncionariosMetas");
                });

            modelBuilder.Entity("GHR.Domain.Meta", b =>
                {
                    b.Navigation("FuncionariosMetas");
                });
#pragma warning restore 612, 618
        }
    }
}