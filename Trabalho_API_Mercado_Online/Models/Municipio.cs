using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com todos os municipio 
    /// </summary>
    public partial class Municipio
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
        /// codigo do municipio
        /// </summary>
        public string CodigoMunicipio { get; set; } = null!;
        /// <summary>
        /// nome do municipio
        /// </summary>
        public string NomeMunicipio { get; set; } = null!;
    }
}
