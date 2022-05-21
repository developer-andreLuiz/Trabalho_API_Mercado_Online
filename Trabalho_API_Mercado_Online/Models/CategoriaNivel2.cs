using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com os dados da categoria nivel 2
    /// </summary>
    public partial class CategoriaNivel2
    {
        public CategoriaNivel2()
        {
            CategoriaNivel3s = new HashSet<CategoriaNivel3>();
            ProdutoCategoria = new HashSet<ProdutoCategorium>();
        }

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
        /// referencia ao id da categoria nivel 1
        /// </summary>
        public int CategoriaNivel1 { get; set; }

        public virtual CategoriaNivel1 CategoriaNivel1Navigation { get; set; } = null!;
        public virtual ICollection<CategoriaNivel3> CategoriaNivel3s { get; set; }
        public virtual ICollection<ProdutoCategorium> ProdutoCategoria { get; set; }
    }
}
