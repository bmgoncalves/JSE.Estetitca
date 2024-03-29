﻿using JSE.Web.Data;
using JSE.Web.Extensions;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using JSE.Web.ViewModel;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace JSE.Web.Controllers
{
    [Route("{controller=Home}/{action=Index}")]
    [Route("{controller=Home}/{action=Index}/{id?}")]
    //TODO - Upload foto depoimentos 
    public class HomeController : Controller
    {

        private readonly IEstabelecimentoRepository _estabelecimentoRepository;
        private readonly IServicoCategoriaRepository _servicoCategoriaRepository;
        private readonly IDepoimentoRepository _depoimentoRepository;
        private readonly IContatoRepository _contatoRepository;
        private readonly IServicoRepository _servicoRepository;
        private readonly IGaleriaRepository _galeriaRepository;
        private readonly IFaqsRepository _faqsRepository;
        private readonly JSEContext _context;

        private readonly IWebHostEnvironment _env;


        public HomeController(IWebHostEnvironment env, IEstabelecimentoRepository estabelecimentoRepository, JSEContext context,
                              IDepoimentoRepository depoimentoRepository, IServicoCategoriaRepository servicoCategoriaRepository, IFaqsRepository faqsRepository,
                               IServicoRepository servicoRepository, IContatoRepository contatoRepository, IGaleriaRepository galeriaRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
            _servicoCategoriaRepository = servicoCategoriaRepository;
            _depoimentoRepository = depoimentoRepository;
            _contatoRepository = contatoRepository;
            _servicoRepository = servicoRepository;
            _galeriaRepository = galeriaRepository;
            _faqsRepository = faqsRepository;
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            IndexViewModel idx = new IndexViewModel()
            {
                Estabel = _context.Estabelecimentos.Where(e => e.Ativo == true).FirstOrDefault(),
                Servicos = _context.Servicos.Where(s => s.ExibeIndex == true)
                                            .OrderBy(s => s.NomeServico)
                                            .Take(6)
                                            .ToList(),
                Depoimentos = _context.Depoimentos.Where(d => d.Aprovado == true)
                                                  .OrderBy(d => d.DataCriacao)
                                                  .ThenBy(d => d.NomeCliente)
                                                  .Take(20)
                                                  .ToList(),
                Galerias = _context.Galerias.Where(g => g.Exibir == true)
                                            .OrderBy(g => g.GaleriaId)
                                            .ThenBy(g => g.ServicoId)
                                            .Take(8)
                                            .ToList(),
                Categorias = _context.ServicoCategorias.OrderBy(c => c.CategoriaId).ToList(),

                Faqs = _faqsRepository.ObterTodasFaqs()
            };

            //Buscar o nome do serviço 
            foreach (var g in idx.Galerias)
            {
                var servico = _servicoRepository.ObterServico(g.ServicoId);
                g.NomeServico = servico.NomeServico;
                g.NomeCategoria = _servicoCategoriaRepository.ObterNomeCategoria(servico.CategoriaId);
            }

            //idx.Estabel.FotosEspaco = FotosEstabel();

            return View(idx);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Path = exceptionHandlerPathFeature.Path,
                ErrorMessage = exceptionHandlerPathFeature.Error.Message
            });
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contato(Contato contato)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _contatoRepository.Cadastrar(contato);
                    return Ok("OK");
                }
                catch (Exception)
                {
                    return BadRequest("Falha ao tentar enviar Contato, tente novamente mais tarde!");
                }
            }
            return BadRequest("Verifique os campos preenchidos e tente novamente.");
        }

        public IActionResult Estabelecimento(int id)
        {
            var estabelecimento = _estabelecimentoRepository.ObterEstabelecimento(id);
            return View(estabelecimento);
        }

        //[HttpGet]
        //[Route("~/Home/Depoimento")]
        //public IActionResult Depoimento()
        //{

        //    return PartialView();
        //}

        //public IActionResult Depoimento([FromForm]Depoimento depoimento, IEnumerable<IFormFile> files)
        public IActionResult Depoimento([FromForm] Depoimento d)
        {

            if (ModelState.IsValid)
            {
                Random rand = new Random();
                var fileName = Util.GenerateCoupon(10, rand);
                var uploads = Path.Combine(_env.WebRootPath, "images\\uploads\\depoimentos\\");
                try
                {

                    if (d.ArquivoUpload != null)
                    {
                        if (d.ArquivoUpload != null && d.ArquivoUpload.Length > 0)
                        {
                            fileName += Path.GetExtension(d.ArquivoUpload.FileName);
                            using var s = new FileStream(Path.Combine(uploads, fileName), FileMode.Create);
                            d.ArquivoUpload.CopyTo(s);
                            d.Imagem = uploads + fileName;
                            d.NomeArquivo = fileName;
                        }
                    }

                    //if (d.ArquivoUpload != null && d.ArquivoUpload.Count > 0)
                    //{
                    //    foreach (var file in d.ArquivoUpload)
                    //    {
                    //        if (file != null && file.Length > 0)
                    //        {
                    //            fileName += Path.GetExtension(file.FileName);

                    //            using var s = new FileStream(Path.Combine(uploads, fileName), FileMode.Create);
                    //            file.CopyTo(s);
                    //            d.Imagem = uploads + fileName;
                    //            d.NomeArquivo = fileName;
                    //        }
                    //    }
                    //}

                    _depoimentoRepository.Cadastrar(d);
                    return Ok("OK");
                }
                catch (Exception)
                {
                    return BadRequest("Erro ao tentar enviar depoimento, favor tentar novamente mais tarde.");
                }

            }
            return BadRequest("Erro ao tentar enviar depoimento, favor tentar novamente mais tarde.");

        }

        //public IActionResult Depoimento(Depoimento depoimento, IEnumerable<IFormFile> files)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        Random rand = new Random();
        //        var fileName = Util.GenerateCoupon(10, rand);
        //        var uploads = Path.Combine(_env.WebRootPath, "images\\uploads\\depoimentos\\");
        //        try
        //        {

        //            foreach (var file in files)
        //            {
        //                if (file != null && file.Length > 0)
        //                {
        //                    fileName += Path.GetExtension(file.FileName);

        //                    using var s = new FileStream(Path.Combine(uploads, fileName), FileMode.Create);
        //                    file.CopyTo(s);
        //                    depoimento.Imagem = uploads + fileName;
        //                    depoimento.NomeArquivo = fileName;
        //                }
        //            }

        //            _depoimentoRepository.Cadastrar(depoimento);
        //            return Redirect("~/Home/#experience");
        //        }
        //        catch (Exception)
        //        {
        //            return Redirect("~/Home/#experience");
        //        }

        //    }
        //    else
        //    {
        //        return Redirect("~/Home/#experience");

        //    }
        //}

        public IActionResult Servicos()
        {
            var servicos = _servicoRepository.ObterTodosServicos();
            return View(servicos);
        }

        public IActionResult Galerias()
        {

            var query = from g in _galeriaRepository.ObterTodosGalerias().OrderBy(g => g.GaleriaId).ThenBy(s => s.ServicoId).ToList() // outer sequence
                        join s in _context.Servicos //inner sequence 
                        on g.ServicoId equals s.ServicoId // key selector 
                        select new
                        {
                            g.GaleriaId,
                            g.ServicoId,
                            s.NomeServico,
                            g.NomeCategoria,
                            g.NomeCliente,
                            g.Imagem,
                            g.NomeArquivo,
                            g.DataCadastro,
                            g.Exibir,
                        };

            IList<Galeria> lista = new List<Galeria>();

            foreach (var item in query)
            {
                var g = new Galeria()
                {
                    ServicoId = item.ServicoId,
                    GaleriaId = item.GaleriaId,
                    NomeCliente = item.NomeCliente,
                    NomeServico = item.NomeServico,
                    NomeCategoria = item.NomeCategoria,
                    NomeArquivo = item.NomeArquivo,
                    Imagem = item.Imagem,
                    DataCadastro = item.DataCadastro,
                    Exibir = item.Exibir
                };

                lista.Add(g);

            }
            return View(lista);
        }

        public IList<string> FotosEstabel()
        {
            var pasta = Path.Combine(_env.WebRootPath, "images\\uploads\\Estabelecimento\\");
            var link = "/images/uploads/Estabelecimento/";

            List<string> fotos = new List<string>();
            //Marca o diretório a ser listado
            DirectoryInfo diretorio = new DirectoryInfo(pasta);
            //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
            FileInfo[] Arquivos = diretorio.GetFiles("*.*");

            //Começamos a listar os arquivos
            foreach (FileInfo fileinfo in Arquivos)
            {
                fotos.Add(link + fileinfo.Name);
            }

            return fotos;
        }

    }
}
