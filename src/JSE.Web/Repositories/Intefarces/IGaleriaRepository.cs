using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IGaleriaRepository
    {
                
        void Cadastrar(Galeria galeria);
        void Atualizar(Galeria galeria);
        void Excluir(int id);
        Galeria ObterGaleria(int id);
        IQueryable<Galeria> ObterTodosGaleriasPaginados(int excludeRecords, int pageNumber, int pageSize);
        List<Galeria> ObterTodosGalerias();
    }
}
