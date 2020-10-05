using JSE.Web.Areas.Admin.ViewModel;
using JSE.Web.Extensions;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Lang;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using X.PagedList;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao]
    [Route("{area:exists}/{controller=Galeria}/{action=Index}")]
    [Route("{area:exists}/{controller=Galeria}/{action=Index}/{id?}")]

    //TODO - Corrigir tamanho das fotos exibidas e procurar um layout melhor para exibir 
    //TODO - Exibir miniatura da imagem na tela inicial / Corrigir exibição da imagem ao escolher antes de cadastrar
    public class GaleriaController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IGaleriaRepository _galeriaRepository;
        private readonly IServicoRepository _servicoRepository;

        public GaleriaController(IGaleriaRepository galeriaRepository, IServicoRepository servicoRepository, IWebHostEnvironment env)
        {
            _servicoRepository = servicoRepository;
            _galeriaRepository = galeriaRepository;
            _env = env;
        }

        [Route("~/Admin/Galeria")]
        public IActionResult Index(int? pagina, string pesquisa)
        {
            var galerias = _galeriaRepository.ObterTodosGaleriasPaginados(pagina, pesquisa);

            IList<GaleriaViewModel> listaGaleriaViewModel = new List<GaleriaViewModel>();

            foreach (var item in galerias)
            {
                GaleriaViewModel galViewModel = new GaleriaViewModel
                {
                    GaleriaId = item.GaleriaId,
                    ServicoId = item.ServicoId,
                    NomeCliente = item.NomeCliente,
                    DataCadastro = item.DataCadastro,
                    NomeArquivo = item.NomeArquivo,
                    Exibir = item.Exibir,
                    NomeServico = _servicoRepository.ObterNomeServico(item.ServicoId)
                };
                listaGaleriaViewModel.Add(galViewModel);
            }

            IPagedList<GaleriaViewModel> listaPaginada = listaGaleriaViewModel.ToPagedList(pagina ?? 1, 15);

            return View(listaPaginada);


        }
        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.Servicos = _servicoRepository.ObterTodosServicos();
            if (id == 0)
            {
                return View(new Galeria());
            }            
            return View(_galeriaRepository.ObterGaleria(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit([FromForm] List<IFormFile> files, Galeria galeria)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Servicos = _servicoRepository.ObterTodosServicos();
                Random rand = new Random();
                var uploadPath = Path.Combine(_env.WebRootPath, "images\\uploads\\galeria\\");
                var fileName = Util.GenerateCoupon(10, rand);
                bool atualizaImagem = false;

                try
                {
                    foreach (var file in files)
                    {
                        if (file != null && file.Length > 0)
                        {
                            fileName += Path.GetExtension(file.FileName);
                            using var s = new FileStream(Path.Combine(uploadPath, fileName), FileMode.Create);
                            file.CopyTo(s);
                            atualizaImagem = true;
                        }
                    }

                    if (atualizaImagem)
                    {
                        if (System.IO.File.Exists(galeria.Imagem))
                        {
                            System.IO.File.Delete(galeria.Imagem);
                        }

                        galeria.Imagem = uploadPath + fileName;
                        galeria.NomeArquivo = fileName;
                    }

                    if (galeria.GaleriaId == 0)
                    {
                        _galeriaRepository.Cadastrar(galeria);
                    }
                    else
                    {
                        _galeriaRepository.Atualizar(galeria);
                    }
                    TempData["MSG_S"] = Mensagem.MSG_S001;
                    return RedirectToAction(nameof(Index));
                }
                catch (DataException ex)
                {
                    TempData["MSG_E"] = ex.Message;
                    return View(galeria);
                }
            }
            else
            {
                return View(galeria);
            }

        }

        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            var galeria = _galeriaRepository.ObterGaleria(id);
            if (galeria != null)
            {
                var imagem = galeria.Imagem;
                _galeriaRepository.Excluir(id);
                TempData["MSG_S"] = Mensagem.MSG_S002;

                if (System.IO.File.Exists(imagem))
                {
                    System.IO.File.Delete(imagem);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public List<Servico> ListaServicos()
        {
            try
            {
                var lista = _servicoRepository.ObterTodosServicos();
                return lista;

            }
            catch (System.Exception)
            {
                return null;
            }
        }

    }
}
