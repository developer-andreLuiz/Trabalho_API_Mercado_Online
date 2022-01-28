using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com todos os estados 
    /// </summary>
    public partial class Estado
    {
        /// <summary>
        /// chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// codigo do estado
        /// </summary>
        public string CodigoEstado { get; set; } = null!;
        /// <summary>
        /// nome do estado
        /// </summary>
        public string NomeEstado { get; set; } = null!;
    }
}
