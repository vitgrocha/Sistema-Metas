﻿// <auto-generated />
using System;
using GHR.Persistence.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GHR.Persistence.Migrations
{
    [DbContext(typeof(GHRContext))]
    [Migration("20220523095426_Initial-CT")]
    partial class InitialCT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("GHR.Domain.DataBase.Cargos.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Funcao")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCargo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Visao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.ContaFuncao", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFuncao")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Departamentos.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MetaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeDepartamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiglaDepartamento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.DadoPessoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("CarteiraTrabalho")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataExpedicaoCarteiraTrabalho")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataExpedicaoIdentidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgaoExpedicaoIdentidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("TituloEleitor")
                        .HasColumnType("TEXT");

                    b.Property<string>("UfIdentidade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DadosPessoais");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .HasColumnType("TEXT");

                    b.Property<string>("CaixaPostal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CargoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContasId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DadosPessoaisId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataAdmissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataDemissao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DiretorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FuncionarioAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GerenteAdministrativoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GerenteOperacionalId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Salario")
                        .HasColumnType("REAL");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("ContasId");

                    b.HasIndex("DadosPessoaisId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.FuncionarioMeta", b =>
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

            modelBuilder.Entity("GHR.Domain.DataBase.Metas.Meta", b =>
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

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Metas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Cargos.Cargo", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Departamentos.Departamento", "Departamentos")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.ContaFuncao", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Funcao", "Funcoes")
                        .WithMany("ContasFuncoes")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", "Contas")
                        .WithMany("ContasFuncoes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contas");

                    b.Navigation("Funcoes");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Funcionario", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Cargos.Cargo", "Cargos")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", "Contas")
                        .WithMany()
                        .HasForeignKey("ContasId");

                    b.HasOne("GHR.Domain.DataBase.Funcionarios.DadoPessoal", "DadosPessoais")
                        .WithMany()
                        .HasForeignKey("DadosPessoaisId");

                    b.HasOne("GHR.Domain.DataBase.Departamentos.Departamento", "Departamentos")
                        .WithMany()
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("GHR.Domain.DataBase.Funcionarios.Endereco", "Enderecos")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Cargos");

                    b.Navigation("Contas");

                    b.Navigation("DadosPessoais");

                    b.Navigation("Departamentos");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.FuncionarioMeta", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Funcionarios.Funcionario", "Funcionario")
                        .WithMany("FuncionariosMetas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GHR.Domain.DataBase.Metas.Meta", "Meta")
                        .WithMany("FuncionariosMetas")
                        .HasForeignKey("MetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Meta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("GHR.Domain.DataBase.Contas.Conta", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Conta", b =>
                {
                    b.Navigation("ContasFuncoes");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Contas.Funcao", b =>
                {
                    b.Navigation("ContasFuncoes");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Funcionarios.Funcionario", b =>
                {
                    b.Navigation("FuncionariosMetas");
                });

            modelBuilder.Entity("GHR.Domain.DataBase.Metas.Meta", b =>
                {
                    b.Navigation("FuncionariosMetas");
                });
#pragma warning restore 612, 618
        }
    }
}
