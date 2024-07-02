using CadastroFuncionario.Entities;
using CadastroFuncionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario.Controllers
{
    public class FuncionarioController
    {

        public void CadastrarFucionario()
        {
            var funcionario = new Funcionario();

            Console.WriteLine("\tCADASTRAR FUNCIONARIO: ");

            funcionario.IdFuncionario = Guid.NewGuid();

            funcionario.DataAdimissao = DateTime.Now;

            Console.Write("Informe o nome do funcionario.........: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe o cpf do funcionario..........: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Informe a matricula do funcionario....: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Informe o cargo do funcionario........: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Informe o salario do funcionario......: ");
            funcionario.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\tDADOS DO FUNCIONARIO: ");

            Console.WriteLine("ID...........: " + funcionario.IdFuncionario);
            Console.WriteLine("NOME.........: " + funcionario.Nome);
            Console.WriteLine("CPF..........: " + funcionario.Cpf);
            Console.WriteLine("MATRICULA....: " + funcionario.Matricula);
            Console.WriteLine("CARGO........: " + funcionario.Cargo);
            Console.WriteLine("SALARIO......: " + funcionario.Salario);
            Console.WriteLine("DATAADIMISSAO: " + funcionario.DataAdimissao);

            var funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.Exportar(funcionario);

            Console.WriteLine("\n\tDADOS GRAVADOS COM SUCESSO!");


        }

    }
}
