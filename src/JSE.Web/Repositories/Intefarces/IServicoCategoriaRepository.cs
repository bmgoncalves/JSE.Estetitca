using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IServicoCategoriaRepository
    {
        void Cadastrar(ServicoCategoria servicoCategoria);
        void Atualizar(ServicoCategoria servicoCategoria);
        void Excluir(int id);
        ServicoCategoria ObterServicoCategoria(int id);
        IQueryable<ServicoCategoria> ObterTodosServicoCategoriasPaginados(int excludeRecords, int pageNumber, int pageSize);
        List<ServicoCategoria> ObterTodasServicoCategorias();
        List<ServicoCategoria> ObterTodasServicoCategoriasAtivas();
        List<ServicoCategoria> ObterServicoCategoriasPorNome(string nome);
        string ObterNomeCategoria(int id);
    }
}
