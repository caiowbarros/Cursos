// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valor
            Console.WriteLine("Digite um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calculando e printando
            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
