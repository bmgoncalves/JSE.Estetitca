using JSE.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IDepoimentoRepository
    {
        void Cadastrar(Depoimento depoimento);
        void AprovarDepoimento(Depoimento depoimento);
        void Excluir(int id);
        bool Existe(int id);
        List<Depoimento> ListaDepoimentos();
        List<Depoimento> ListaDepoimentosPendentes();
        Depoimento GetDepoimento(int id);
        IQueryable<Depoimento> GetDepoimentosPendente(int excludeRecords, int pageNumber, int pageSize);

        
    }
}
