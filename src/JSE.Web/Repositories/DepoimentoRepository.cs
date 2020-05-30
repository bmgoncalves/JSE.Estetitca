using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JSE.Web.Repositories
{
    public class DepoimentoRepository : IDepoimentoRepository
    {
        private readonly JSEContext _context;

        public DepoimentoRepository(JSEContext context)
        {
            _context = context;
        }

        public void AprovarDepoimento(Depoimento depoimento)
        {
            if (depoimento.Aprovado)
            {
                _context.Depoimentos.Update(depoimento);
                _context.SaveChanges();
            }
            else
            {
                Excluir(depoimento.Id);
            }
        }

        public void Excluir(int id)
        {
            var depoimento = _context.Depoimentos.Find(id);
            _context.Depoimentos.Remove(depoimento);
            _context.SaveChanges();
        }

        public bool Existe(int id)
        {
            return _context.Depoimentos.Where(d => d.Id == id).Any();
        }

        public Depoimento GetDepoimento(int id)
        {
            return _context.Depoimentos.Where(d => d.Id == id).FirstOrDefault();
        }

        public List<Depoimento> ListaDepoimentos()
        {
            throw new NotImplementedException();
        }

        public List<Depoimento> ListaDepoimentosPendentes()
        {
            return _context.Depoimentos.Where(d => d.Aprovado == false).ToList();
        }

        public IQueryable<Depoimento> GetDepoimentosPendente(int excludeRecords, int pageNumber, int pageSize)
        {
            var depoimentos = _context.Depoimentos.Where(d => d.Aprovado == false)
                                                  .OrderBy(d => d.DataCriacao)
                                                  .ThenBy(d => d.NomeCliente)
                                                  .Skip(excludeRecords)
                                                  .Take(pageSize);
            return depoimentos;
        }

        public void Cadastrar(Depoimento depoimento)
        {
            _context.Depoimentos.Add(depoimento);
            _context.SaveChanges();
        }
    }
}
