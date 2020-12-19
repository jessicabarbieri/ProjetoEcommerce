using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEcommerce.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Config
{
    public class FormaPagamentoConfig : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            throw new NotImplementedException();
        }
    }
}
