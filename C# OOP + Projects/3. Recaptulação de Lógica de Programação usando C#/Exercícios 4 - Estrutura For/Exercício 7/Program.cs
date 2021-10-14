// Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
// começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.

using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para N:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i + " " + (i*i) + " " + (i*i*i));
            }
        }
    }
}
