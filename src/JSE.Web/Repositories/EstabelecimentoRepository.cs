using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Repositories
{
    
    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {
        private readonly JSEContext _context;

        public EstabelecimentoRepository(JSEContext context)
        {
            _context =context;
        }
        public void Atualizar(Estabelecimento estabelecimento)
        {
            _context.Estabelecimentos.Update(estabelecimento);
            _context.SaveChanges();
        }

        public void Cadastrar(Estabelecimento estabelecimento)
        {
            _context.Estabelecimentos.Add(estabelecimento);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var estabel = _context.Estabelecimentos.Find(id);
            if (estabel != null)
            {
                _context.Estabelecimentos.Remove(estabel);
                _context.SaveChanges();
            }
        }

        public Estabelecimento ObterEstabelecimento()
        {
            return  _context.Estabelecimentos.Where(e => e.Ativo == true).FirstOrDefault();

        }


        public List<Estabelecimento> ObterTodasEstabelecimento()
        {
            return _context.Estabelecimentos.ToList();
        }

        public IQueryable<Estabelecimento> ObterTodosEstabelecimentoPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            return _context.Estabelecimentos.Skip(excludeRecords).Take(pageSize);
        }
    }
}
