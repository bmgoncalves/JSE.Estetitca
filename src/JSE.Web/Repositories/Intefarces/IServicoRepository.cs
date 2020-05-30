using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IServicoRepository
    {
        void Cadastrar(Servico servico);
        void Atualizar(Servico servico);
        void Excluir(int id);
        Servico ObterServico(int id);
        IQueryable<Servico> ObterTodosServicosPaginados(int excludeRecords, int pageNumber, int pageSize);
        List<Servico> ObterTodosServicos();
        List<Servico> ObterServicosPorNome(string nome);
        string ObterNomeServico(int id);
    }
}
