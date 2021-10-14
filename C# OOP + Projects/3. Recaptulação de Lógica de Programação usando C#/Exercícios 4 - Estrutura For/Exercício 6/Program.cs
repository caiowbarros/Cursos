// Ler um número inteiro N e calcular todos os seus divisores.

using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número N:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
