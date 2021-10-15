// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa
// mais velha.

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            System.Console.WriteLine("Digite o nome da primeira pessoa:");
            pessoa1.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite a idade da primeira pessoa:");
            pessoa1.Idade = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Digite o nome da segunda pessoa:");
            pessoa2.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite a idade da segunda pessoa:");
            pessoa2.Idade = Convert.ToInt32(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            } else {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
        }
    }
}
