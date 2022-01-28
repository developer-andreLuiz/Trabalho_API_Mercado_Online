using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com dados dos codigos de barra relacionando com o codigo do produto
    /// </summary>
    public partial class ProdutosCodigoBarra
    {
        /// <summary>
        /// chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia do codigo do produto
        /// </summary>
        public int CodigoProduto { get; set; }
        /// <summary>
        /// codigo de barra do produto
        /// </summary>
        public string CodigoBarra { get; set; } = null!;
    }
}
