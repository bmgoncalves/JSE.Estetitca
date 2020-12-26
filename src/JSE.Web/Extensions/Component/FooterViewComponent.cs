using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JSE.Web.Extensions.Component
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IEstabelecimentoRepository _repo;

        public FooterViewComponent(IEstabelecimentoRepository repository)
        {
            _repo = repository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var estab = _repo.ObterEstabelecimento();
            return View(estab);
        }
    }
}
