﻿using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class LojaPrateleira
    {
        public LojaPrateleira()
        {
            ProdutoLojas = new HashSet<ProdutoLoja>();
        }

        /// <summary>
        /// autonumerico chave primaria da tabela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referente ao id de loja_estante
        /// </summary>
        public int LojaEstante { get; set; }
        /// <summary>
        /// livre  para armazenar mais itens
        /// </summary>
        public int Livre { get; set; }
        /// <summary>
        /// codigo da prateleira por estante 
        /// exemplo 
        /// estante 1 (loja_estante) prateleira 5 (codigo)
        /// estante 3 prateleira 5
        /// </summary>
        public int Codigo { get; set; }

        public virtual LojaEstante LojaEstanteNavigation { get; set; } = null!;
        public virtual ICollection<ProdutoLoja> ProdutoLojas { get; set; }
    }
}
