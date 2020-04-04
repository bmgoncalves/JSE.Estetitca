﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        [MaxLength(20)]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }


        public decimal ValorCusto { get; set; }
        public decimal Valor { get; set; }
        public int FornecedorId { get; set; }

    }
}
