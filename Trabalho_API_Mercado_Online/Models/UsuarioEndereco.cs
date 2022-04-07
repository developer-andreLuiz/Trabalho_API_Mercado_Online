using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class UsuarioEndereco
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public int? Principal { get; set; }
        public string? Cep { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
    }
}
