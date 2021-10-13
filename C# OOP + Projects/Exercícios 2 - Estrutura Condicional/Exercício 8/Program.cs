// Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
// que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
// qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
//
// Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
// mostre o valor que esta pessoa deve pegar de Imposto de Renda, segundo a tabela abaixo.
//
//   | RENDA                         | IMPOSTO DE RENDA
//   | de 0.00 a R$ 2000.00          |     Isento
//   | de R$ 2000.01 até R$ 3000.00  |       8 %
//   | de R$ 3000.01 até R$ 4500.00  |      18 %
//   | acima de R$ 4500.00           |      28 %
//
// Lembre que, se o salário for R$ 3302.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
// salário que fica de R$0.00 até R$ 2000.00 é isenta de Imposto de Renda. O valor deve ser impresso com duas
// casas decimais.

using System;

namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valor
            Console.WriteLine("Digite o valor do salário:");
            double salario = Convert.ToDouble(Console.ReadLine());

            // Calculando e printando
            if (salario <= 2000) {
                Console.WriteLine("Isento");
            } else if (salario <= 3000) {
                double imposto = (0.08 * (salario - 2000));
                Console.WriteLine("R$ " + Math.Round(imposto, 2));
            } else if (salario <= 4500) {
                double imposto = (0.18 * (salario - 3000)) + (0.08 * 1000);
                Console.WriteLine("R$ " + Math.Round(imposto, 2));
            } else {
                double imposto = (0.28 * (salario - 4500)) + (0.18 * 1500) + (0.08 * 1000);
                Console.WriteLine("R$ " + Math.Round(imposto, 2));
            }
        }
    }
}
