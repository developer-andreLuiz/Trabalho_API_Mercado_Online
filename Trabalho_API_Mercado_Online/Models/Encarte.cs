using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class Encarte
    {
        /// <summary>
        /// chave primaria do encarte
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome do encarte
        /// </summary>
        public string Nome { get; set; } = null!;
        /// <summary>
        /// data de criação do encarte
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// data de validade do encarte
        /// </summary>
        public DateTime Validade { get; set; }
        /// <summary>
        /// categoria do encarte 
        /// </summary>
        public int Tipo { get; set; }
        /// <summary>
        /// decide se é frente ou verso
        /// </summary>
        public int Frente { get; set; }
    }
}
