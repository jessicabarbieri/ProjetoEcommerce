using Microsoft.AspNetCore.Mvc;
using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Dominio.Entidades;
using System;

namespace ProjetoEcommerce.Web.Controllers
{
    [Route("api/[Controller]")]
    public class PedidoController : Controller
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        public PedidoController(IPedidoRepositorio pedidoRepositorio)
        {
            this._pedidoRepositorio = pedidoRepositorio;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
                _pedidoRepositorio.Adicionar(pedido);
                return Ok(pedido.Id);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
