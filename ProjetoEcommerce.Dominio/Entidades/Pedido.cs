using ProjetoEcommerce.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Pedido : Entidade
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

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AddMensagem("Pedido deve conter pelo menos um item!");

            if (string.IsNullOrEmpty(CEP))
                AddMensagem("CEP deve estar preenchido!");

            if (string.IsNullOrEmpty(Estado))
                AddMensagem("Estado deve estar preenchido!");

            if (string.IsNullOrEmpty(Cidade))
                AddMensagem("Cidade deve estar preenchido!");

            if (string.IsNullOrEmpty(Endereco))
                AddMensagem("Endereco deve estar preenchido!");

            if (FormaPagtoId == 0)
                AddMensagem("Não foi informado a forma de pagamento!");
        }
    }
}
