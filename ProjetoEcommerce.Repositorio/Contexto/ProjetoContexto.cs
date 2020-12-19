using Microsoft.EntityFrameworkCore;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.ObjetodeValor;
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
    }
}
