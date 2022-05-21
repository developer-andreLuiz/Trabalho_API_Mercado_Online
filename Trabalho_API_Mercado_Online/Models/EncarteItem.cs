using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class EncarteItem
    {
        /// <summary>
        /// chave primaria do encarte_item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// id do encarte
        /// </summary>
        public int Encarte { get; set; }
        /// <summary>
        /// url da imagem
        /// </summary>
        public string Img { get; set; } = null!;
        /// <summary>
        /// nome do produto
        /// </summary>
        public string Produto { get; set; } = null!;
        /// <summary>
        /// valor do produto
        /// </summary>
        public string Valor { get; set; } = null!;

        public virtual Encarte EncarteNavigation { get; set; } = null!;
    }
}
