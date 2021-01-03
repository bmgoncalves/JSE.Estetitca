using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IFaqsRepository
    {
        void Cadastrar(Faqs faqs);
        void Atualizar(Faqs faqs);
        void Excluir(int id);
        Faqs ObterFaq(int id);
        IQueryable<Faqs> ObterTodosFaqsPaginados(int excludeRecords, int pageNumber, int pageSize);
        List<Faqs> ObterTodasFaqs();
    }
}
