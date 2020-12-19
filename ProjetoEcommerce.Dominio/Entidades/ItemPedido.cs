using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
                AddMensagem("Não foi identificado o ID do produto!");

            if (Quantidade == 0)
                AddMensagem("Quantidade não foi informada!");
        }
    }
}
