// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha inválida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegando senha
            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();

            // Verificando senha
            while (senha != "2002") {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite a senha novamente:");
                senha = Console.ReadLine();
            }

            // Senha correta
            Console.WriteLine("Acesso Permitido");
        }
    }
}
