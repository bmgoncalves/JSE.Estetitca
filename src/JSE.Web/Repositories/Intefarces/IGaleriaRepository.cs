using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IGaleriaRepository
    {
                
        void Cadastrar(Galeria galeria);
        void Atualizar(Galeria galeria);
        void Excluir(int id);
        Galeria ObterGaleria(int id);
        IPagedList<Galeria> ObterTodosGaleriasPaginados(int? pagina, string pesquisa);
        List<Galeria> ObterTodosGalerias();
    }
}
