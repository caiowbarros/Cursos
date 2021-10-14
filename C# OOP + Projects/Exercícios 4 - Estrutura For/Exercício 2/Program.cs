// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos
// destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações
// conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

using System;
using System.Collections.Generic;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quantidade de números inteiros
            Console.WriteLine("Digite a quantidade de valores inteiros:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<double> nums = new List<double>();
            int inNum = 0;
            int outNum = 0;

            // Populando lista
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o " + (i+1) + "º número inteiro:");
                nums.Add(Convert.ToDouble(Console.ReadLine()));
            }

            // Verificando se números estão dentrou ou fora do intervalo
            foreach (double num in nums) {
                if (num >= 10 && num <= 20) {
                    inNum++;
                } else {
                    outNum++;
                }
            }

            // Print
            Console.WriteLine(inNum + " in");
            Console.WriteLine(outNum + " out");
        }
    }
}
