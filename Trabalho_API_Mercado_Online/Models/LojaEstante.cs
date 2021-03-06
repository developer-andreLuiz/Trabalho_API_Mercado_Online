using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class LojaEstante
    {
        /// <summary>
        /// chave primaria da tabela loja_estante
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// se os produtos não sao de higiene pessoal e perfumaria
        /// </summary>
        public int ProdutoVariado { get; set; }
    }
}
