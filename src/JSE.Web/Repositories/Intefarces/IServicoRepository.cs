using JSE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IServicoRepository
    {
        void Cadastrar(Servico servico);
        void Atualizar(Servico servico);
        void Excluir(int id);
        Servico ObterServico(int id);
        IEnumerable<Servico> ObterTodasServicos();
        //IPagedList<Servico> ObterTodasServicos(int? pagina);
        List<Servico> ObterServicosPorNome(string nome);
    }
}
