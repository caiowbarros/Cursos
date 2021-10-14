// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
// X, se for o caso.

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valor
            Console.WriteLine("Digite o valor de X:");
            int x = Convert.ToInt32(Console.ReadLine());

            // Calculando
            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
