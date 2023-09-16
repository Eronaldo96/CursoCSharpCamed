using Camed.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camed.Domain
{
    public partial class Funcionario
    {
        public static implicit operator FuncionarioDto(Funcionario funcionario)
        {
            return new FuncionarioDto
            {
                Rg = funcionario.Rg,
                Matricula = funcionario.Matricula,
                Nome = funcionario.Nome,
            };
        }
    }
}
