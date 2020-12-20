using ProjetoEcommerce.Dominio.Contratos;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Repositorio.Contexto;

namespace ProjetoEcommerce.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProjetoContexto projetoContexto) : base(projetoContexto)
        {

        }
    }
}
