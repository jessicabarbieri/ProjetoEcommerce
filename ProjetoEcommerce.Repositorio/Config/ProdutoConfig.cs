using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEcommerce.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Config
{
    class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            //Buider utiliza o padrão Fluent
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
            .Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(400);

            builder
                .Property(p => p.Preco)
                .IsRequired()
        }
    }
}
