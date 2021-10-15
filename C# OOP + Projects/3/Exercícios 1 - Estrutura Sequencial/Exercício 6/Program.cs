// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
// mostre:
// 
// a) a área do triângulo retângulo que tem A por base e C por altura.
// b) a área do círculo de raio C. (pi = 3.14159)
// c) a área do trapézio que tem A e B por bases e C por altura.
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B.

using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite um valor para A:");
            double a = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("Digite um valor para B:");
            double b = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("Digite um valor para C:");
            double c = Convert.ToDouble((Console.ReadLine()));
            double pi = 3.14159;

            // Calculando
            double triangulo = (a * c) / 2;
            double circulo = pi * (c * c);
            double trapezio = ((a+b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            // Printando
            Console.WriteLine("TRIÂNGULO: " + Math.Round(triangulo, 3));
            Console.WriteLine("CÍRCULO: " + Math.Round(circulo, 3));
            Console.WriteLine("TRAPÉZIO: " + Math.Round(trapezio, 3));
            Console.WriteLine("QUADRADO: " + Math.Round(quadrado, 3));
            Console.WriteLine("RETÂNGULO:" + Math.Round(retangulo, 3));
        }
    }
}
