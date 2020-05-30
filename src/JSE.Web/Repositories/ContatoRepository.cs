using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly JSEContext _context;

        public ContatoRepository(JSEContext context)
        {
            _context = context;
        }

        public void AprovarReprovar(Contato contato)
        {
            _context.Update(contato);
        }

        public void Excluir(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato != null)
            {
                _context.Contatos.Remove(contato);
                _context.SaveChanges();
            }
        }

        public Contato ObterContato(int id)
        {
            return _context.Contatos.Where(c => c.ContatoId == id).FirstOrDefault();
        }

        public IQueryable<Contato> ObterTodosContatosPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            return _context.Contatos.Skip(excludeRecords).Take(pageSize); 
        }

        public List<Contato> ObterTodosContatos()
        {
            return _context.Contatos.OrderBy(c => c.ContatoId)
                                    .ThenBy(c => c.Nome)
                                    .ThenBy(c => c.DataHora)
                                    .ToList();
        }

        public List<Contato> ObterTodosContatosPendentes()
        {
            return _context.Contatos.Where(c => c.Pendente == true)
                                    .OrderBy(c => c.ContatoId)
                                    .ThenBy(c => c.Nome)
                                    .ThenBy(c => c.DataHora)
                                    .ToList();
        }
    }
}
