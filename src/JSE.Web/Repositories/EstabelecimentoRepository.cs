using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{

    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {
        private readonly JSEContext _context;

        public EstabelecimentoRepository(JSEContext context)
        {
            _context = context;
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

        public List<Estabelecimento> ObterTodosEstabelecimentos()
        {
            return _context.Estabelecimentos.ToList();
        }

        public IQueryable<Estabelecimento> ObterTodosEstabelecimentoPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            return _context.Estabelecimentos.Skip(excludeRecords).Take(pageSize);
        }

        public Estabelecimento ObterEstabelecimentoAtivo()
        {
            return _context.Estabelecimentos.Where(e => e.Ativo == true).FirstOrDefault();
        }

        public Estabelecimento ObterEstabelecimento(int id)
        {
            return _context.Estabelecimentos.Where(e => e.Id == id).FirstOrDefault();
        }

        public Estabelecimento ObterEstabelecimento()
        {
            return _context.Estabelecimentos.First();

        }
    }
}
