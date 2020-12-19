using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);
        }
    }
}

