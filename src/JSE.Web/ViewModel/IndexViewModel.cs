using JSE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.ViewModel
{
    public class IndexViewModel
    {
        public Estabelecimento  Estabel { get; set; }
        public Contato Contato { get; set; }
        public IList<Depoimento> Depoimentos { get; set; }
        public IList<Servico> Servicos { get; set; }
        public IList<Galeria> Galerias { get; set; }
        public IList<ServicoCategoria> Categorias { get; set; }
    }
}
