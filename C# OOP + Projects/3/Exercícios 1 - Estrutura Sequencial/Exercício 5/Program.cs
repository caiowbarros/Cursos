// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
// o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Peça 1
            Console.WriteLine("Insira o código da peça 1: ");
            int codPeca1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o número de peças 1:");
            int numPeca1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário de cada peça 1: ");
            double precoPeca1 = Convert.ToDouble(Console.ReadLine());

            // Peça 2
            Console.WriteLine("Insira o código da peça 2: ");
            int codPeca2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o número de peças 2:");
            int numPeca2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário de cada peça 2: ");
            double precoPeca2 = Convert.ToDouble(Console.ReadLine());

            // Cálculo
            double total = (numPeca1 * precoPeca1) + (numPeca2 * precoPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + Math.Round(total, 2));
        }
    }
}
