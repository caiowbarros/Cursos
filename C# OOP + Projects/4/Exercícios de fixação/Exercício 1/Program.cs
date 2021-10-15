// Fazer um programa para ler os valores da largura e altura de um retângulo.
// Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar
// uma classe como mostrado no projeto.
//
//     |      RETÂNGULO        |
//     |-----------------------|
//     | - Largura: double     |
//     | - Altura: double      |
//     |-----------------------|
//     | + Area(): double      |
//     | + Perimetro(): double |
//     | + Diagonal(): double  |

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            System.Console.WriteLine("Digite a largura do retângulo:");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Digite a altura do retângulo:");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("ÁREA = " + retangulo.Area());
            System.Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro());
            System.Console.WriteLine("DIAGONAL = " + retangulo.Diagonal());
        }
    }
}
