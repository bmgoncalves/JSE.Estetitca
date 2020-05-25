using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Linq;
using X.PagedList;

namespace JSE.Web.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly JSEContext _context;

        public UsuarioRepository(JSEContext context)
        {
            _context = context;
        }

        public void AtivarDesativar(int id)
        {
            var usuario = ObterUsuario(id);
            usuario.Situacao = (usuario.Situacao == true) ? false : true;
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var usuario = ObterUsuario(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();
        }

        public IPagedList<Usuario> ObterTodosUsuarios(int? pagina, string pesquisa)
        {
            int numeroPagina = pagina ?? 1;

            var bancoUsuario = _context.Usuarios.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                bancoUsuario = bancoUsuario.Where(c => c.Nome.Contains(pesquisa.Trim()) || c.Email.Contains(pesquisa.Trim()));
            }

            return bancoUsuario.ToPagedList<Usuario>(numeroPagina, 10);
        }

        public Usuario ObterUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }
    }
}
