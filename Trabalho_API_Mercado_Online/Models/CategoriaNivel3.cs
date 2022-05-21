using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com os dados da categoria nivel 3
    /// </summary>
    public partial class CategoriaNivel3
    {
        public CategoriaNivel3()
        {
            CategoriaNivel4s = new HashSet<CategoriaNivel4>();
            ProdutoCategoria = new HashSet<ProdutoCategorium>();
        }

        /// <summary>
        /// chave primaria da categoria nivel 3
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome da categoria nivel 3
        /// </summary>
        public string Nome { get; set; } = null!;
        /// <summary>
        /// url da imagem
        /// </summary>
        public string Img { get; set; } = null!;
        /// <summary>
        /// ordem de exibição
        /// </summary>
        public int Ordem { get; set; }
        /// <summary>
        /// referencia ao id da categoria nivel 1
        /// </summary>
        public int CategoriaNivel1 { get; set; }
        /// <summary>
        /// referencia ao id da categoria nivel 2
        /// </summary>
        public int CategoriaNivel2 { get; set; }

        public virtual CategoriaNivel2 CategoriaNivel2Navigation { get; set; } = null!;
        public virtual ICollection<CategoriaNivel4> CategoriaNivel4s { get; set; }
        public virtual ICollection<ProdutoCategorium> ProdutoCategoria { get; set; }
    }
}
