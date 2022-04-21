using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class LojaPrateleira
    {
        /// <summary>
        /// autonumerico chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// codigo para prateleira dentro da estante exemplo prateleira 10 da estante 2
        /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// id referente a estante na loja para venda online
        /// </summary>
        public int EstanteLoja { get; set; }
        /// <summary>
        /// livre  para armazenar mais itens
        /// </summary>
        public int Livre { get; set; }
    }
}
