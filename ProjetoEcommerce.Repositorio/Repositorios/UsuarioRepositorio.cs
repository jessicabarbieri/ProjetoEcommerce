using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProjetoContexto projetoContexto) : base(projetoContexto)
        {
        }
        public Usuario Obter(string email, string senha)
        {
            return ProjetoContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return ProjetoContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
