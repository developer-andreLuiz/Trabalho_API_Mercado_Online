using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com os dados dos produtos relacionando com as categorias
    /// </summary>
    public partial class ProdutosCategorium
    {
        /// <summary>
        /// autonumerico chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia ao codigo do produto
        /// </summary>
        public int CodigoProduto { get; set; }
        /// <summary>
        /// referecia a categoria nivel 1
        /// </summary>
        public int CategoriaNivel1 { get; set; }
        /// <summary>
        /// referecia a categoria nivel 2
        /// </summary>
        public int CategoriaNivel2 { get; set; }
        /// <summary>
        /// referecia a categoria nivel 3
        /// </summary>
        public int CategoriaNivel3 { get; set; }
        /// <summary>
        /// referecia a categoria nivel 4
        /// </summary>
        public int CategoriaNivel4 { get; set; }
        public int Ordem { get; set; }
    }
}
