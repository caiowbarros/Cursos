// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
// casas decimais conforme exemplos.
// 
// Fórmula: área = pi * (raio * raio)
//
// Considere o valor de pi = 3.14159

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            // Raio
            Console.Write("Insira o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            // Cálculo
            double area = pi * (raio * raio);

            Console.WriteLine("A = " + Math.Round(area, 4));
        }
    }
}
