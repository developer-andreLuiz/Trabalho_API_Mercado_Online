using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com todos os bairros
    /// </summary>
    public partial class Bairro
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
        /// codigo do bairro
        /// </summary>
        public string CodigoBairro { get; set; } = null!;
        /// <summary>
        /// nome do bairro
        /// </summary>
        public string NomeBairro { get; set; } = null!;
    }
}
