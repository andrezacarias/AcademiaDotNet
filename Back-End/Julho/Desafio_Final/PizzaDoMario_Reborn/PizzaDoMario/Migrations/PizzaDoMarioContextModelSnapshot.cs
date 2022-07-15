﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaDoMario.Data;

#nullable disable

namespace PizzaDoMario.Migrations
{
    [DbContext(typeof(PizzaDoMarioContext))]
    partial class PizzaDoMarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PizzaDoMario.Models.CadastroCliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("CadastroCliente", (string)null);
                });

            modelBuilder.Entity("PizzaDoMario.Models.CadastroProduto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"), 1L, 1);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("preco")
                        .HasColumnType("real");

                    b.HasKey("IdProduto");

                    b.ToTable("CadastroProduto", (string)null);
                });

            modelBuilder.Entity("PizzaDoMario.Models.Venda", b =>
                {
                    b.Property<int>("IdVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenda"), 1L, 1);

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataCompra")
                        .HasColumnType("datetime2");

                    b.Property<float>("valorTotal")
                        .HasColumnType("real");

                    b.HasKey("IdVenda");

                    b.ToTable("Venda", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
