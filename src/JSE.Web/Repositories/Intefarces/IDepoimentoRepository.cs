﻿using JSE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IDepoimentoRepository
    {
        List<Depoimento> ListaDepoimentos();
        List<Depoimento> ListaDepoimentosPendentes();
        Depoimento GetDepoimento(int id);
        IQueryable<Depoimento> GetDepoimentosPendente(int excludeRecords, int pageNumber, int pageSize);

        void AprovarDepoimento(Depoimento depoimento);
        void Excluir(int id);
        bool Existe(int id);
    }
}