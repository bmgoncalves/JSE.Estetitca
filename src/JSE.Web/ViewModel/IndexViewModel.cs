using JSE.Web.Models;
using System.Collections.Generic;

namespace JSE.Web.ViewModel
{
    public class IndexViewModel
    {
        public Estabelecimento Estabel { get; set; }
        public Contato Contato { get; set; }
        public IList<Depoimento> Depoimentos { get; set; }
        public IList<Servico> Servicos { get; set; }
        public IList<Galeria> Galerias { get; set; }
        public IList<ServicoCategoria> Categorias { get; set; }
        public IList<Faqs> Faqs { get; set; }
    }
}
