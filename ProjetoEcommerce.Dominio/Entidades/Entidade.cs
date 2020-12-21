using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private protected List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AddMensagem(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        public bool Valido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
