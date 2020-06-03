using cloudscribe.Pagination.Models;
using JSE.Web.Extensions;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Lang;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
    [Route("{area:exists}/{controller=Servico}/{action=Index}")]
    [Route("{area:exists}/{controller=Servico}/{action=Index}/{id?}")]
    public class ServicoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IServicoRepository _servicoRepository;
        private readonly IServicoCategoriaRepository _servicoCategoriaRepository;

        public ServicoController(IWebHostEnvironment env, IServicoRepository servicoRepository, IServicoCategoriaRepository servicoCategoriaRepository)
        {
            _env = env;
            _servicoRepository = servicoRepository;
            _servicoCategoriaRepository = servicoCategoriaRepository;

        }

        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {

            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var servicos = _servicoRepository.ObterTodosServicosPaginados(excludeRecords, pageNumber, pageSize);

            var result = new PagedResult<Servico>
            {
                Data = servicos.AsNoTracking().ToList(),
                TotalItems = _servicoRepository.ObterTodosServicos().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.Categorias = _servicoCategoriaRepository.ObterTodasServicoCategorias();

            if (id == 0)
            {
                return View(new Servico());
            }
            return View(_servicoRepository.ObterServico(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([FromForm] List<IFormFile> files, Servico servico)
        {
            if (ModelState.IsValid)
            {
                Random rand = new Random();
                var uploadPath = Path.Combine(_env.WebRootPath, "images\\uploads\\servicos\\");
                var fileName = Util.GenerateCoupon(10, rand);
                bool atualizaImagem = false;

                ViewBag.Categorias = _servicoCategoriaRepository.ObterTodasServicoCategorias();
                try
                {

                    foreach (var file in files)
                    {
                        if (file != null && file.Length > 0)
                        {
                            fileName += Path.GetExtension(file.FileName);

                            using var s = new FileStream(Path.Combine(uploadPath, fileName),
                                                                        FileMode.Create);
                            file.CopyTo(s);
                            atualizaImagem = true;
                        }
                    }

                    if (atualizaImagem)
                    {
                        if (System.IO.File.Exists(servico.Imagem))
                        {
                            System.IO.File.Delete(servico.Imagem);
                        }

                        servico.Imagem = uploadPath + fileName;
                        servico.NomeArquivo = fileName;
                    }

                    if (servico.ServicoId == 0)
                    {
                        _servicoRepository.Cadastrar(servico);
                    }
                    else
                    {
                        _servicoRepository.Atualizar(servico);

                    }

                    TempData["MSG_S"] = Mensagem.MSG_S001;
                    return RedirectToAction(nameof(Index));
                }
                catch (DataException ex)
                {
                    TempData["MSG_E"] = ex.Message;
                    return View(servico);
                }
            }
            else
            {
                return View(servico);
            }

        }

        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            var servico = _servicoRepository.ObterServico(id);

            if (servico != null)
            {
                var imagem = servico.Imagem;
                _servicoRepository.Excluir(id);

                if (System.IO.File.Exists(imagem))
                {
                    System.IO.File.Delete(imagem);
                }

                TempData["MSG_S"] = Mensagem.MSG_S002;
                return RedirectToAction(nameof(Index));

            }
            return View("Index");
        }

        public IActionResult ListaCategorias()
        {
            var lista = _servicoCategoriaRepository.ObterTodasServicoCategoriasAtivas();
            return Json(lista);
        }

       
    }
}
