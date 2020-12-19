using Microsoft.EntityFrameworkCore;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.ObjetodeValor;
using ProjetoEcommerce.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Contexto
{
    public class ProjetoContexto: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public ProjetoContexto(DbContextOptions options) : base(options)
        {

        }

        // Construtor de modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfig());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfig());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de Pagamento Boleto"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartao de Crédito",
                    Descricao = "Forma de Pagamento Cartão de Crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Forma de Pagamento Depósito"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
