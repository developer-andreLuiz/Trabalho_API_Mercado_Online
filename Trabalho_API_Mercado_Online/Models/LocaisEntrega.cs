using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com objetivo de informar as localidades com entrega disponivel
    /// </summary>
    public partial class LocaisEntrega
    {
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
    }
}
