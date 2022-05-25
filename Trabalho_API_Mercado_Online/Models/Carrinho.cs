using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com os dados do carrinho dos clientes
    /// </summary>
    public partial class Carrinho
    {
        /// <summary>
        /// chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia ao id do usuario
        /// </summary>
        public int Usuario { get; set; }
        /// <summary>
        /// referencia ao id do produto
        /// </summary>
        public int Produto { get; set; }
        /// <summary>
        /// quantidade de itens do mesmo produto no carrinho
        /// </summary>
        public int Quantidade { get; set; }
    }
}
