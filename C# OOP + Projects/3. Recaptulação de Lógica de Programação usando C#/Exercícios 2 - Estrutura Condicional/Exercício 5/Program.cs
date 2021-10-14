// Com base na tabela de preços a seguir, faça um programa que leia o código de um item e a quantidade
// deste item. A seguir, calcule e mostre o valor da conta a pagar.
//
//      CODIGO   ESPECIFICAÇÃO       PREÇO
//      1        Cachorro Quente     R$ 4.00
//      2        X-Salada            R$ 4.50
//      3        X-Bacon             R$ 5.00
//      4        Torrada simples     R$ 2.00
//      4        Refrigerante        R$ 1.50

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Digite o código do produto: ");
            int cod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto: ");
            int qtd = Convert.ToInt32(Console.ReadLine());
            double total = 0;

            // Cálculo
            if (cod == 1) {
                total = qtd * 4;
            } else if (cod == 2) {
                total = qtd * 4.5;
            } else if (cod == 3) {
                total = qtd * 5;
            } else if (cod == 4) {
                total = qtd * 2;
            } else if (cod == 5) {
                total = qtd * 1.5;
            } else {
                Console.WriteLine("Código do produto inválido.");
            }

            Console.WriteLine("Total: R$ " + Math.Round(total, 2));
        }
    }
}
