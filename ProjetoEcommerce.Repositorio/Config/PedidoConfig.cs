using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEcommerce.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Config
{
    class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            throw new NotImplementedException();
        }
    }
}
