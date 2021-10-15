// Fazer um programa para ler o nome e salário de dois funcionários. Depois, mostrar o salário
// médios dos funcionários.

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            System.Console.WriteLine("Digite o nome do primeiro funcionário:");
            funcionario1.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite o salário do primeiro funcionário:");
            funcionario1.Salario = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do segundo funcionário:");
            funcionario2.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite o salário do segundo funcionário:");
            funcionario2.Salario = Convert.ToDouble(Console.ReadLine());

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;
            System.Console.WriteLine("Salário médio = " + Math.Round(media, 2));
        }
    }
}
