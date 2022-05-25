using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class Funcionario
    {
        /// <summary>
        /// chave primaria da tabela produto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome do funcionario
        /// </summary>
        public string Nome { get; set; } = null!;
        /// <summary>
        /// senha do funcionario
        /// </summary>
        public string Senha { get; set; } = null!;
        /// <summary>
        /// nivel de acesso
        /// 
        /// 1 Operação
        /// 2 Supervisão
        /// 3 Gerência
        /// 4 Técnico
        /// 5 Presidência
        /// </summary>
        public int Nivel { get; set; }
        /// <summary>
        /// id da tabela funcionario_cargo
        /// </summary>
        public int? Cargo { get; set; }
        public decimal? Salario { get; set; }
        public decimal? SalarioBonus { get; set; }
        public decimal? ValeCompra { get; set; }
        /// <summary>
        /// telefone do funcionaio
        /// </summary>
        public string Telefone { get; set; } = null!;
        /// <summary>
        /// endereço do funcionario
        /// </summary>
        public string? Endereco { get; set; }
        /// <summary>
        /// informação complementar sobre o funcionario
        /// </summary>
        public string? Informacao { get; set; }
        /// <summary>
        /// verifica se o funcionario esta ativo na empresa
        /// </summary>
        public bool Habilitado { get; set; }
    }
}
