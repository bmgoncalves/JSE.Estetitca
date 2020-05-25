using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{
    public class ServicoCategoriaRepository : IServicoCategoriaRepository
    {
        private readonly JSEContext _context;

        public ServicoCategoriaRepository(JSEContext context)
        {
            _context = context;
        }

        public void Atualizar(ServicoCategoria servicoCategoria)
        {
            _context.ServicoCategorias.Update(servicoCategoria);
            _context.SaveChanges();
        }

        public void Cadastrar(ServicoCategoria servicoCategoria)
        {
            _context.ServicoCategorias.Add(servicoCategoria);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var categoria = _context.ServicoCategorias.Find(id);
            _context.ServicoCategorias.Remove(categoria);
            _context.SaveChanges();
        }

        public ServicoCategoria ObterServicoCategoria(int id)
        {
            return _context.ServicoCategorias.Where(sc => sc.CategoriaId == id).FirstOrDefault();
        }

        public List<ServicoCategoria> ObterServicoCategoriasPorNome(string nome)
        {
            return _context.ServicoCategorias.Where(sc => sc.Categoria.Contains(nome)).ToList();
        }

        public List<ServicoCategoria> ObterTodasServicoCategorias()
        {
            return _context.ServicoCategorias.ToList();
        }

        public List<ServicoCategoria> ObterTodasServicoCategoriasAtivas()
        {
            return _context.ServicoCategorias.Where(sc => sc.Ativo == true)
                                             .OrderBy(c => c.Categoria)
                                             .ThenBy(c => c.CategoriaId)
                                             .ToList();
        }

        public IQueryable<ServicoCategoria> ObterTodosServicoCategoriasPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            var servicoCategoria = _context.ServicoCategorias.Skip(excludeRecords).Take(pageSize);

            return servicoCategoria;
        }
    }
}
