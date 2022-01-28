using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class EncarteItem
    {
        public int Id { get; set; }
        public int IdEncarte { get; set; }
        public string Img { get; set; } = null!;
        public string Produto { get; set; } = null!;
        public string Valor { get; set; } = null!;
    }
}
