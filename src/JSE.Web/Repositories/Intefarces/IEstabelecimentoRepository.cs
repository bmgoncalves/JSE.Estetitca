﻿using JSE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Repositories.Intefarces
{
    public interface IEstabelecimentoRepository
    {
        void Cadastrar(Estabelecimento estabelecimento);
        void Atualizar(Estabelecimento estabelecimento);
        void Excluir(int id);
        Estabelecimento ObterEstabelecimento();
        IQueryable<Estabelecimento> ObterTodosEstabelecimentoPaginados(int excludeRecords, int pageNumber, int pageSize);
        List<Estabelecimento> ObterTodasEstabelecimento();
    }
}
