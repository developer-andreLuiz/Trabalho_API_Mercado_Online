using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    /// <summary>
    /// tabela com informações dos clientes
    /// </summary>
    public partial class Cliente
    {
        /// <summary>
        /// chave primaria da tabela e codigo de cada cliente
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome do cliente
        /// </summary>
        public string Nome { get; set; } = null!;
        public string? Img { get; set; }
        /// <summary>
        /// cpf do cliente
        /// </summary>
        public string? Cpf { get; set; }
        /// <summary>
        /// Data de nascimento  do cliente
        /// </summary>
        public DateTime? Nascimento { get; set; }
        /// <summary>
        /// numero de telefone do cliente
        /// </summary>
        public string Telefone { get; set; } = null!;
        public string AparelhoId { get; set; } = null!;
        /// <summary>
        /// saldo do cliente
        /// </summary>
        public decimal Saldo { get; set; }
        /// <summary>
        /// status do cliente
        /// </summary>
        public int Habilitado { get; set; }
    }
}
