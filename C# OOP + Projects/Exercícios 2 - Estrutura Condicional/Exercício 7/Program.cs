// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto
// em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um 
// dos eixos cartesianos ou na origem (x = y = 0).
//
// Seo ponto estiver na origem, escreva a mensagem "Origem".
//
// Se o ponto estiver sobre um dos eixos escreva "Eixo X" ou "Eixo Y", conforme for a situação.

using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite o valor de x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de y:");
            double y = Convert.ToDouble(Console.ReadLine());

            // Calculando e printando
            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            } else if (x == 0) {
                Console.WriteLine("Eixo Y");
            } else if (y == 0) {
                Console.WriteLine("Eixo X");
            } else {
                if (x > 0) {
                    if (y > 0) {
                        Console.WriteLine("Q1");
                    } else {
                        Console.WriteLine("Q2");
                    }
                } else {
                    if (y > 0) {
                        Console.WriteLine("Q4");
                    } else {
                        Console.WriteLine("Q3");
                    }
                }
            }
        }
    }
}
