using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class Encarte
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Data { get; set; } = null!;
        public string Validade { get; set; } = null!;
        public int Tipo { get; set; }
        public int Frente { get; set; }
    }
}
