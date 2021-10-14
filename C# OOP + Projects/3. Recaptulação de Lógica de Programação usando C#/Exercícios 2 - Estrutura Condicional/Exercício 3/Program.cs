// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São Múltiplos" ou "Não são
// Múltiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados
// em ordem crescente ou decrescente.

using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite um valor inteiro para A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro para B:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Calculando e printando
            if (a > b) {
                if (a % b == 0) {
                    Console.WriteLine("São Múltiplos");
                } else {
                    Console.WriteLine("Não são Múltiplos");
                }
            } else {
                if (b % a == 0) {
                    Console.WriteLine("São Múltiplos");
                } else {
                    Console.WriteLine("Não são Múltiplos");
                }
            }
        }
    }
}
