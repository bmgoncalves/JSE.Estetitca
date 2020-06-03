using JSE.Web.Models;
using X.PagedList;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);

        void Cadastrar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Excluir(int id);
        void AtivarDesativar(int id);
        Usuario ObterUsuario(int id);
        Usuario ObterUsuarioPorEmail(string email);
        IPagedList<Usuario> ObterTodosUsuarios(int? pagina, string pesquisa);
    }
}
