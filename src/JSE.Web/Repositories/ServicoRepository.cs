using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly JSEContext _context;
        public ServicoRepository(JSEContext context)
        {
            _context = context;
        }
        public void Atualizar(Servico servico)
        {
            _context.Servicos.Update(servico);
            _context.SaveChanges();
        }

        public void Cadastrar(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var servico = _context.Servicos.Find(id);
            _context.Remove(servico);
            _context.SaveChanges();
        }

        public string ObterNomeServico(int id)
        {
            return _context.Servicos.Where(s => s.ServicoId == id).Select(s => s.NomeServico).Single();
        }

        public Servico ObterServico(int id)
        {
            return _context.Servicos.Find(id);
        }

        public List<Servico> ObterServicosPorNome(string nome)
        {
            return _context.Servicos.Where(s => s.NomeServico.Contains(nome)).ToList();
        }

        public List<Servico> ObterTodosServicos()
        {
            return _context.Servicos.ToList();
        }

        public IQueryable<Servico> ObterTodosServicosPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            var servicos = _context.Servicos.Skip(excludeRecords).Take(pageSize);

            return servicos;
        }
    }
}
