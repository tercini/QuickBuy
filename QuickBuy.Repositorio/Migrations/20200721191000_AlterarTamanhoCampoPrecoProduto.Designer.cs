﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Migrations
{
    [DbContext(typeof(QuickBuyContexto))]
    [Migration("20200721191000_AlterarTamanhoCampoPrecoProduto")]
    partial class AlterarTamanhoCampoPrecoProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PedidoId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItensPedidos");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DataPedido");

                    b.Property<DateTime>("DataPrevisaoEntrega");

                    b.Property<string>("EnderecoCompleto")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("FormaPagamentoId");

                    b.Property<string>("NumeroEndereco")
                        .IsRequired();

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NomeArquivo");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("QuickBuy.Dominio.ObjetoDeValor.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Forma de Pagamento Boleto",
                            Nome = "Boleto"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Forma de Pagamento Cartão de Crédito",
                            Nome = "Cartão de Crédito"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Forma de Pagamento Depósito",
                            Nome = "Depósito"
                        });
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.ItemPedido", b =>
                {
                    b.HasOne("QuickBuy.Dominio.Entidades.Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Pedido", b =>
                {
                    b.HasOne("QuickBuy.Dominio.ObjetoDeValor.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
