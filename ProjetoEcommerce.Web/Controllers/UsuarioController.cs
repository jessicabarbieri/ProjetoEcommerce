using Microsoft.AspNetCore.Mvc;
using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Dominio.Entidades;
using System;

namespace ProjetoEcommerce.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioRetorno = _usuarioRepositorio.Obter(usuario.Email, usuario.Senha);

                if (usuarioRetorno != null)
                    return Ok(usuarioRetorno);

                return BadRequest("Usuário ou senha inválido");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = _usuarioRepositorio.Obter(usuario.Email);

                usuario.Administrador = false;

                if (usuarioCadastrado != null)
                    return BadRequest("Usuario já cadastrado no sistema");

                usuarioCadastrado.Validate();

                if (!usuarioCadastrado.Valido)
                    return BadRequest(usuarioCadastrado.ObterMensagensValidacao());

                _usuarioRepositorio.Adicionar(usuario);

                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}