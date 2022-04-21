using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class ProdutoLoja
    {
        /// <summary>
        /// autonumerico chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia id da tabela produto
        /// </summary>
        public int Produto { get; set; }
        /// <summary>
        /// data de entrada do produto
        /// </summary>
        public DateTime Entrada { get; set; }
        /// <summary>
        /// validade do produto
        /// </summary>
        public DateTime Validade { get; set; }
        /// <summary>
        /// referencia id da tabela loja_prateleira
        /// </summary>
        public int Prateleira { get; set; }
        /// <summary>
        /// quantidade de itens do produto na prateleira
        /// </summary>
        public int Quantidade { get; set; }
        /// <summary>
        /// referencia id da tabela funcionario
        /// </summary>
        public int Funcionario { get; set; }
        /// <summary>
        /// marcar produto com validade verificada após entrada na prateleira
        /// </summary>
        public int? ConferenciaValidade { get; set; }
        /// <summary>
        /// marcar produto com balanço verificado após entrada na prateleira
        /// </summary>
        public int? ConferenciaBalanco { get; set; }
    }
}
