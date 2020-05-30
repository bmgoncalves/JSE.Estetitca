using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Lang;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
    [Route("{area:exists}/{controller=ServicoCategoria}/{action=Index}")]
    [Route("{area:exists}/{controller=ServicoCategoria}/{action=Index}/{id?}")]
    public class ServicoCategoriaController : Controller
    {
        private readonly IServicoCategoriaRepository _servicoCategoriaRepository;

        public ServicoCategoriaController(IServicoCategoriaRepository servicoCategoriaRepository)
        {
            _servicoCategoriaRepository = servicoCategoriaRepository;
        }

        // GET: Admin/ServicoCategoria
        [Route("~/Admin/ServicoCategoria/Index")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            IQueryable<ServicoCategoria> categorias = _servicoCategoriaRepository.ObterTodosServicoCategoriasPaginados(excludeRecords,pageNumber,pageSize);

            var result = new PagedResult<ServicoCategoria>
            {
                Data = categorias.AsNoTracking().ToList(),
                TotalItems = _servicoCategoriaRepository.ObterTodasServicoCategorias().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            {
                return View(new ServicoCategoria());
            }
            return View(_servicoCategoriaRepository.ObterServicoCategoria(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([FromForm] ServicoCategoria servicoCategoria)
        {
            if (ModelState.IsValid)
            {
                if (servicoCategoria.CategoriaId == 0)
                {
                    _servicoCategoriaRepository.Cadastrar(servicoCategoria);
                }
                else
                {
                    _servicoCategoriaRepository.Atualizar(servicoCategoria);
                }

                TempData["MSG_S"] = Mensagem.MSG_S001;
                return RedirectToAction(nameof(Index));
            }
            return View(servicoCategoria);
        }


        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            var categoria = _servicoCategoriaRepository.ObterServicoCategoria(id);
            //Criar regra para não permitir exclusão com serviço vinculado
            if (categoria != null)
            {
                _servicoCategoriaRepository.Excluir(id);
                TempData["MSG_S"] = Mensagem.MSG_S002;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));

        }



    }
}
