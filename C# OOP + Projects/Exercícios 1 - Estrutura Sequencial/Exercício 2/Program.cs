// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
// casas decimais.
//
// Fórmula da área: area = pi * (raio * raio)
//
// Considere o valor de pi = 3.14159

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegando valores
            Console.WriteLine("Digite o valor do raio:");
            double raio = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14159;

            // Calculando área
            double area = pi * (raio * raio);

            // Printando resultado
            Console.WriteLine("A=" + Math.Round(area, 4));
        }
    }
}
