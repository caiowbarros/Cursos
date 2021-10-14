// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
// de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos
// de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite o valor de N:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Calculando e printando
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o 1º valor do caso de teste " + (i+1));
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o 2º valor do caso de teste " + (i+1));
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o 3º valor do caso de teste " + (i+1));
                double num3 = Convert.ToDouble(Console.ReadLine());

                double media = (((num1*2) + (num2*3) + (num3*5)) / 10);
                Console.WriteLine(Math.Round(media, 1));
            }
        }
    }
}
