using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEcommerce.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(ProjetoContexto projetoContexto) : base(projetoContexto)
        {
        }
    }
}
