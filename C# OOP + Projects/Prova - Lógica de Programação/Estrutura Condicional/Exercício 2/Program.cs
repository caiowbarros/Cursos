// Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau. Em seguida, mostrar
// os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara. Se a equação não possuir
// raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser negativo), mostrar uma 
// mensagem "Impossível calcular".

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegando valores 
            Console.WriteLine("Digite o valor de a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de c:");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calculando Baskara
            double delta = (b * b) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            // Verificando validez
            if (a == 0 || delta < 0) {
                Console.WriteLine("Impossível calcular");
            } else {
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }
        }
    }
}
