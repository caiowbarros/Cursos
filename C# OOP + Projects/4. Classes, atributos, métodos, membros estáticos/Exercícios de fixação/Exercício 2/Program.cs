// Fazer um programa para ler os dados de um funconário (nome, salário bruto e imposto). Em
// seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o 
// salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado
// pela porcentagem) e mostrar novamente os dados do funcionário. Usar a classe projetada.
//
//      |                FUNCIONÁRIO                   |
//      |----------------------------------------------|
//      | - Nome: string                               |
//      | - SalarioBruto: double                       |
//      | - Imposto: double                            |
//      |----------------------------------------------|
//      | + SalarioLiquido(): double                   |
//      | + AumentarSalario(porcentagem: double): void |

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            System.Console.WriteLine("Digite o nome do funcionário:");
            func.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite o salário bruto do funcionário:");
            func.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Digite o imposto pago pelo funcionário:");
            func.Imposto = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Funcionário: " + func.Nome + ", $ " + func.SalarioLiquido());

            System.Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            System.Console.WriteLine("Dados atualizados: " + func.Nome + ", $ " + func.SalarioLiquido());
        }
    }
}
