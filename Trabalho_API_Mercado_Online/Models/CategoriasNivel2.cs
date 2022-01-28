﻿using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com os dados da categoria nivel 2
    /// </summary>
    public partial class CategoriasNivel2
    {
        /// <summary>
        /// chave primaria da categoria nivel 2
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome da categoria nivel 2
        /// </summary>
        public string Nome { get; set; } = null!;
        /// <summary>
        /// url da imgagem
        /// </summary>
        public string Img { get; set; } = null!;
        /// <summary>
        /// ordem de exibição
        /// </summary>
        public int Ordem { get; set; }
        /// <summary>
        /// referencia codigo da categoria nivel 1
        /// </summary>
        public int CategoriaNivel1 { get; set; }
    }
}
