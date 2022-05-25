using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class UsuarioEndereco
    {
        /// <summary>
        /// chave primaria da tabela usuario
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// referencia ao id de usuario
        /// </summary>
        public int Usuario { get; set; }
        /// <summary>
        /// endereço do usuario
        /// </summary>
        public string Endereco { get; set; } = null!;
        /// <summary>
        /// cep do endereço cadastrado
        /// </summary>
        public string Cep { get; set; } = null!;
        /// <summary>
        /// verifica se o endereço é o principal
        /// </summary>
        public int? Principal { get; set; }
        /// <summary>
        /// complemento do endereço (opcional)
        /// </summary>
        public string? Complemento { get; set; }
        /// <summary>
        /// ponto de referencia do endereço (opcional)
        /// </summary>
        public string? Referencia { get; set; }
    }
}
