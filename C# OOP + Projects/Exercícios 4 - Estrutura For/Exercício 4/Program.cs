// Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
// segundo. Se o denominador for igual a zero, mostrar a mensagem "divisão impossível".

using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valor
            Console.WriteLine("Digite o valor de N:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o primeiro valor:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0) {
                    Console.WriteLine("divisão impossível");
                } else {
                    Console.WriteLine(num1 / num2);
                }
            }
        }
    }
}
