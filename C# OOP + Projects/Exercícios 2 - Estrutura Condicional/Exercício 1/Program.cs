// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valor
            Console.WriteLine("Digite um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calculando e printando
            if (num < 0) {
                Console.WriteLine("NEGATIVO");
            } else {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
