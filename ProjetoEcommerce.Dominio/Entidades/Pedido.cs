using ProjetoEcommerce.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagtoId { get; set; }
        public FormaPagamento FormaPagto { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}
