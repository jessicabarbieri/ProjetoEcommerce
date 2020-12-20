using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProjetoContexto projetoContexto) : base(projetoContexto)
        {
        }
    }
}
