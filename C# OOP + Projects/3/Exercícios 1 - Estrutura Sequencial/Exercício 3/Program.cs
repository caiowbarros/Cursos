// Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite o valor de A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de D:");
            int d = Convert.ToInt32(Console.ReadLine());

            // Calculando diferença
            int diferenca = a * b - c * d;

            // Printando resultado
            Console.WriteLine("DIFERENÇA = " + diferenca);
        }
    }
}
