using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{
    public class GaleriaRepository : IGaleriaRepository
    {
        private readonly JSEContext _context;

        public GaleriaRepository(JSEContext context)
        {
            _context = context;
        }

        public void Atualizar(Galeria galeria)
        {
            _context.Galerias.Update(galeria);
            _context.SaveChanges();
        }

        public void Cadastrar(Galeria galeria)
        {
            _context.Galerias.Add(galeria);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var galeria = _context.Galerias.Find(id);
            _context.Galerias.Remove(galeria);
            _context.SaveChanges();
        }

        public Galeria ObterGaleria(int id)
        {
            return _context.Galerias.Find(id);
        }

        public List<Galeria> ObterTodosGalerias()
        {
            return _context.Galerias.ToList();
        }

        public IQueryable<Galeria> ObterTodosGaleriasPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            var galeria = _context.Galerias.Skip(excludeRecords).Take(pageSize);
            return galeria;
        }
    }
}
