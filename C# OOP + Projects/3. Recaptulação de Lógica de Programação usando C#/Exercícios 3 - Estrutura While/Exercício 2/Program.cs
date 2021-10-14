// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade inderteminada de pontos no sistema
// cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
// menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            int x = 1;
            int y = 1;

            // Calculando e printando
            while (x != 0 && y != 0) {
                Console.WriteLine("Digite um valor para X:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um valor para Y:");
                y = Convert.ToInt32(Console.ReadLine());
                
                if (x > 0) {
                    if (y > 0) {
                        Console.WriteLine("primeiro");
                    } else if (y < 0) {
                        Console.WriteLine("quarto");
                    }
                } else if (x < 0) {
                    if (y > 0) {
                        Console.WriteLine("segundo");
                    } else if (y < 0) {
                        Console.WriteLine("terceiro");
                    }
                } 
            }
        }
    }
}
