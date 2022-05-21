using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com dados dos codigos de barra relacionando com o codigo do produto
    /// </summary>
    public partial class ProdutoCodigoBarra
    {
        /// <summary>
        /// chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia ao id de produto
        /// </summary>
        public int Produto { get; set; }
        /// <summary>
        /// codigo de barra do produto
        /// </summary>
        public string CodigoBarra { get; set; } = null!;

        public virtual Produto ProdutoNavigation { get; set; } = null!;
    }
}
