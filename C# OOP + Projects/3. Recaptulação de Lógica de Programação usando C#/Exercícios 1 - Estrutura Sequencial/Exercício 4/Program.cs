// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
// hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
// decimais.

using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite o número do funcionário:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas:");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora:");
            double valor = Convert.ToDouble(Console.ReadLine());

            // Calculando
            double salario = horas * valor;

            // Printando
            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + Math.Round(salario, 2));
        }
    }
}
