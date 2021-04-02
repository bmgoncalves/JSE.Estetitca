using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace JSE.Web.Repositories
{
    public class GaleriaRepository : IGaleriaRepository
    {
        private readonly JSEContext _context;

        public GaleriaRepository(JSEContext context)
        {
            _context = context;
        }

        public void Atualizar(Galeria galeria)
        {
            _context.Galerias.Update(galeria);
            _context.SaveChanges();
        }

        public void Cadastrar(Galeria galeria)
        {
            _context.Galerias.Add(galeria);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var galeria = _context.Galerias.Find(id);
            _context.Galerias.Remove(galeria);
            _context.SaveChanges();
        }

        public Galeria ObterGaleria(int id)
        {
            return _context.Galerias.Find(id);
        }

        public List<Galeria> ObterTodosGalerias()
        {
            return _context.Galerias.ToList();
        }

        public IPagedList<Galeria> ObterTodosGaleriasPaginados(int? pagina, string pesquisa)
        {
            int numeroPagina = pagina ?? 1;
            var bancoGaleria = _context.Galerias.AsQueryable();
            List<Servico> listaServicos = _context.Servicos.ToList();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                foreach (var servicos in listaServicos)
                {
                    if (servicos.NomeServico.Contains(pesquisa.Trim()))
                    {
                        bancoGaleria = bancoGaleria.Where(g => g.ServicoId == servicos.ServicoId);
                    }
                }

                //bancoGaleria = bancoGaleria.Where(g => g.NomeCliente.Contains(pesquisa.Trim()));
            }

            return bancoGaleria.ToPagedList<Galeria>(numeroPagina, 5000);
        }




    }
}
