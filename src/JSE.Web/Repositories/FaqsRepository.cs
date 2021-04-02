using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{
    public class FaqsRepository : IFaqsRepository
    {
        private readonly JSEContext _context;

        public FaqsRepository(JSEContext context)
        {
            _context = context;
        }
        public void Atualizar(Faqs faqs)
        {
            _context.Faqs.Update(faqs);
            _context.SaveChanges();
        }

        public void Cadastrar(Faqs faqs)
        {
            _context.Faqs.Add(faqs);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            Faqs faq = ObterFaq(id);
            if (faq != null)
            {
                _context.Faqs.Remove(faq);
                _context.SaveChanges();
            }
        }

        public Faqs ObterFaq(int id)
        {
            return _context.Faqs.Find(id);
        }

        public List<Faqs> ObterTodasFaqs()
        {
            return _context.Faqs.ToList();
        }

        public IQueryable<Faqs> ObterTodosFaqsPaginados(int excludeRecords, int pageNumber, int pageSize)
        {
            var listaFaqs = _context.Faqs.Skip(excludeRecords).Take(pageSize);
            return listaFaqs;
        }
    }
}
