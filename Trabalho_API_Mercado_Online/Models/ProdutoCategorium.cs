using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com os dados dos produtos relacionando com as categorias
    /// </summary>
    public partial class ProdutoCategorium
    {
        /// <summary>
        /// chave primaria da tabela produto_categoria
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia ao id do produto
        /// </summary>
        public int Produto { get; set; }
        /// <summary>
        /// referecia ao id de categoria nivel 1
        /// </summary>
        public int CategoriaNivel1 { get; set; }
        /// <summary>
        /// referecia ao id de categoria nivel 2
        /// </summary>
        public int CategoriaNivel2 { get; set; }
        /// <summary>
        /// referecia ao id de categoria nivel 3
        /// </summary>
        public int CategoriaNivel3 { get; set; }
        /// <summary>
        /// referecia ao id de categoria nivel 4
        /// </summary>
        public int CategoriaNivel4 { get; set; }
        /// <summary>
        /// ordem de exibição
        /// </summary>
        public int Ordem { get; set; }
    }
}
