// Fazer um programa para ler dois números inteiros M e N, e depois ler
// uma matriz de M linhas por N colunas contendo números inteiros, podendo
// haver repetições. Em seguida, ler um número inteiro X que pertence à
// matriz. Para cada ocorrência de X, mostrar os valores à esquerda, acima
// à direita e abaixo de X, quando houver.

using System;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor de M:");
            int m = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite o valor de N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[m, n];


            for (int i = 0; i < m; i++) {
                for (int k = 0; k < n; k++) {
                    System.Console.WriteLine("Digite um valor para casa [" + i + "][" + k + "]");
                    matriz[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }

            System.Console.WriteLine("Digite o valor de X:");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int k = 0; k < n; k++) {
                    if (matriz[i, k] == x) {
                        System.Console.WriteLine("Position " + i + "," + k + ":");
                        if (i > 0) {
                            System.Console.WriteLine("Up: " + matriz[i-1,k]);
                        } if (k < n - 1) {
                            System.Console.WriteLine("Right: " + matriz[i,k+1]);
                        } if (i < m - 1) {
                            System.Console.WriteLine("Down: " + matriz[i+1,k]);
                        } if (k > 0) {
                            System.Console.WriteLine("Left: " + matriz[i,k-1]);
                        }
                    }
                }
            }

        }
    }
}
