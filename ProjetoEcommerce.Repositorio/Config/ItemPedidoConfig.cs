using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEcommerce.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Config
{
    class ItemPedidoConfig : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            throw new NotImplementedException();
        }
    }
}
