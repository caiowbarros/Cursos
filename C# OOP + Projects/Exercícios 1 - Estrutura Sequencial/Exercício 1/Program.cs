// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
// mensagem explicativa

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegando números
            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Printando resultado
            Console.WriteLine("SOMA = " + (num1 + num2));
        }
    }
}
