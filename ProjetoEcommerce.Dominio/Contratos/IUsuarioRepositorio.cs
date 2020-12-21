using ProjetoEcommerce.Dominio.Entidades;

namespace ProjetoEcommerce.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
