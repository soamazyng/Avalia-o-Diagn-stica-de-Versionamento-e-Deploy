using avaliacao_diagnostica.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace avaliacao_diagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Olá! Por favor informe 1 caso você seja funcionário ou 2 caso você seja terceiro...");

            var tipoUsuario = int.Parse(Console.ReadLine());

            if (tipoUsuario.Equals(1))
            {
                var funcionario = new Funcionario("John Doe", 340, 60.00);
                var salario = funcionario.CalculaSalario();

                Console.WriteLine("Você está vendo os dados de um funcionário");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Salário: {salario:C2}");
            }
            else
            {
                var funterceiro = new FuncionarioTerceirizado("John Doe Ter", 340, 60.00, "Space X", 3.50);
                var salario = funterceiro.CalculaSalario();

                Console.WriteLine("Você está vendo os dados de um terceiro:");
                Console.WriteLine($"Nome: {funterceiro.Nome}");
                Console.WriteLine($"Empresa de: {funterceiro.EmpresaOrigem}");
                Console.WriteLine($"Salário: {salario:C2}");
            }
            
        }
    }
}
