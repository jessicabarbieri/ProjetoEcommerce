using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
                AddMensagem("E-mail deve estar preenchido!");

            if (string.IsNullOrEmpty(Descricao))
                AddMensagem("Senha deve estar preenchido!");

        }
    }
}
