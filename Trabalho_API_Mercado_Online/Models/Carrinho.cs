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
        /// referencia do codigo do cliente
        /// </summary>
        public int CodigoCliente { get; set; }
        /// <summary>
        /// referencia do codigo do produto
        /// </summary>
        public int CodigoProduto { get; set; }
        /// <summary>
        /// quantidade de itens do mesmo produto no carrinho
        /// </summary>
        public int Quantidade { get; set; }
    }
}
