using ProjetoEcommerce.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Dominio.ObjetodeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool Boleto
        {
            get { return Id == (int)TipoFormaPagtoEnum.Boleto; }
        }
        public bool CartaoCredito
        {
            get { return Id == (int)TipoFormaPagtoEnum.CartaoCredito; }
        }
        public bool Deposito
        {
            get { return Id == (int)TipoFormaPagtoEnum.Deposito; }
        }
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagtoEnum.NaoDefinido; }
        }
    }
}
