﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
