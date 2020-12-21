using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Administrador { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
                AddMensagem("E-mail deve estar preenchido!");

            if (string.IsNullOrEmpty(Senha))
                AddMensagem("Senha deve estar preenchido!");

            if (string.IsNullOrEmpty(Nome))
                AddMensagem("Nome deve estar preenchido!");
        }
    }
}
