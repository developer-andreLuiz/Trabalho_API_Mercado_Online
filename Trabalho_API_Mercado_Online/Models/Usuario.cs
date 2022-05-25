using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com informações dos usuarios
    /// </summary>
    public partial class Usuario
    {
        /// <summary>
        /// chave primaria da tabela usuario
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome do usuario
        /// </summary>
        public string Nome { get; set; } = null!;
        public string? Img { get; set; }
        /// <summary>
        /// cpf do usuario
        /// </summary>
        public string? Cpf { get; set; }
        /// <summary>
        /// Data de nascimento  do usuario
        /// </summary>
        public DateTime? Nascimento { get; set; }
        /// <summary>
        /// saldo do cliente
        /// </summary>
        public decimal? Saldo { get; set; }
        /// <summary>
        /// numero de telefone do usuario
        /// </summary>
        public string Telefone { get; set; } = null!;
        /// <summary>
        /// id do dispositivo do usuario logado
        /// </summary>
        public string AparelhoId { get; set; } = null!;
        /// <summary>
        /// status do usuario
        /// </summary>
        public int Habilitado { get; set; }
    }
}
