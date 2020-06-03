using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IContatoRepository
    {
        void AprovarReprovar(Contato contato);
        void Excluir(int id);
        Contato ObterContato(int id);
        IQueryable<Contato> ObterTodosContatosPaginados(int excludeRecords, int pageNumber, int pageSize);
        List<Contato> ObterTodosContatosPendentes();
        List<Contato> ObterTodosContatos();
    }
}
