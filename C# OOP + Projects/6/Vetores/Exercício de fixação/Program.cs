// A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos
// identificados pelos número 0 a 9.
//
// Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
//
// Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N
// representando o número de estudantes, que vão alugar quartos (N pode ser 1 a 10). Em seguida,
// registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do
// estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um 
// quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato
// por ordem de quarto.

using System;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite quantos estudantes irão alugar um quarto:");
            int n = Convert.ToInt32(Console.ReadLine());

            Quarto[] quartos = new Quarto[n];

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Digite seu email:");
                string email = Console.ReadLine();
                System.Console.WriteLine("Digite o número do quarto que deseja (0 a 9):");
                int numero = Convert.ToInt32(Console.ReadLine());

                quartos[i] = new Quarto(numero, nome, email);
            }

            System.Console.WriteLine("Quantos quartos serão alugados? " + n);

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine("\nAluguel #" + (i+1) + ":");
                System.Console.WriteLine("Nome: " + quartos[i].nomeEstudante);
                System.Console.WriteLine("Email: " + quartos[i].email);
                System.Console.WriteLine("Quarto: " + quartos[i].numQuarto);
            }

            Quarto[] quartosOrdenados = new Quarto[n];
            int contador = 0;

            for (int i = 0; i < 9; i++) {
                for (int k = 0; k < n; k++) {
                    if (i == quartos[k].numQuarto) {
                        quartosOrdenados[contador] = quartos[k];
                        contador++;
                    }
                }
            }

            System.Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine(quartosOrdenados[i].numQuarto + ": " + quartosOrdenados[i].nomeEstudante + ", " + quartosOrdenados[i].email);
            }
        }
    }
}
