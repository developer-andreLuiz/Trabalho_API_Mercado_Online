using System;
using System.Collections.Generic;

namespace Trabalho_API_Mercado_Online.Models
{
    public partial class FuncionarioCargo
    {
        public FuncionarioCargo()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        /// <summary>
        /// chave primaria de funcionario_cargo
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome do cargo do funcionario
        /// </summary>
        public string Nome { get; set; } = null!;

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
