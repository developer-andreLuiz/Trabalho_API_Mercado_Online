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
        /// <summary>
        /// numero de telefone do cliente
        /// </summary>
        public string Celular { get; set; } = null!;
        /// <summary>
        /// saldo do cliente
        /// </summary>
        public decimal Saldo { get; set; }
        /// <summary>
        /// status do cliente
        /// </summary>
        public int Habilitado { get; set; }
        /// <summary>
        /// referencia do codigo do estado de entrega
        /// </summary>
        public string CodigoEstado { get; set; } = null!;
        /// <summary>
        /// referencia do codigo do municipio de entrega
        /// </summary>
        public string CodigoMunicipio { get; set; } = null!;
        /// <summary>
        /// referencia do codigo do bairro de entrega
        /// </summary>
        public string CodigoBairro { get; set; } = null!;
        /// <summary>
        /// endereço de entrega da compra
        /// </summary>
        public string Endereco { get; set; } = null!;
        /// <summary>
        /// complemento de endereço 
        /// </summary>
        public string? Complemento { get; set; }
    }
}
