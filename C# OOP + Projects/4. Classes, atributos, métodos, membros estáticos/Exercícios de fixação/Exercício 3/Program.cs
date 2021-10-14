// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
// (primeiro trismestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do
// aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
// para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você criar uma classe Aluno para 
// resolver esse problema.

using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            System.Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite a primeira nota do aluno:");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Digite a segunda nota do aluno:");
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Digite a terceira nota do aluno:");
            aluno.Nota3 = Convert.ToDouble(Console.ReadLine());

            aluno.NotaFinal();
        }
    }
}
