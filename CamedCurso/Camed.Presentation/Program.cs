using Camed.Domain;
using Camed.Domain.Dto;

var funcionario = new Funcionario
{
    Id = 1,
    Nome = "Noob Saibot",
    Matricula = 12345,
    Rg = "2324443434",
    Gestor = "Shao Khan",
    Setor = "OutWorld",
};

Console.WriteLine(funcionario.Nome);

var dto = (FuncionarioDto)funcionario;

Console.WriteLine(dto.Matricula);

