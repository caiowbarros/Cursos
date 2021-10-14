// Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) - (N-2) * (N-3) * ... * 1.
// Lembrando que, por definição, fatorial de 0 é 1.

using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;

            for (int i = n; i > 0; i--) {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
