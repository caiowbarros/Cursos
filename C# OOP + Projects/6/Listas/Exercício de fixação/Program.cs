// Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salário) de
// N funcionários. Não deve haver repetição de id.
//
// Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para
// isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
// mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários.
//
// Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser
// mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento por
// porcentagem dada.
//
//      |                 EMPLOYEE                   |
//      |--------------------------------------------|
//      | - id : Integer                             |
//      | - name: String                             |
//      | - salary: Double                           |
//      |--------------------------------------------|
//      | + increaseSalary(percentage: double): void |

using System;
using System.Collections.Generic;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o número de funcionários:");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine("Digite o id do funcionário " + (i+1));
                int id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Digite o nome do funcionário " + (i+1));
                string nome = Console.ReadLine();
                System.Console.WriteLine("Digite o salário do funcionário " + (i+1));
                double salario = Convert.ToDouble(Console.ReadLine());

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            System.Console.WriteLine("How many employees will be registered? " + n);

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine("Employee #" + (i+1));
                System.Console.WriteLine("Id: " + funcionarios[i].id);
                System.Console.WriteLine("Name: " + funcionarios[i].nome);
                System.Console.WriteLine("Salary: " + funcionarios[i].salario + "\n");
            }

            System.Console.WriteLine("Enter the employee id that will have salary increase:");
            int increaseId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the percentage:");
            int percentage = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < n; i++) {
                if (funcionarios[i].id == increaseId) {
                    funcionarios[i].increaseSalary(percentage);
                    found = true;
                }
            }

            if (!found) {
                System.Console.WriteLine("Id does not exist");
            }

            System.Console.WriteLine("Updated list of employees:");
            for (int i = 0; i < n; i++) {
                System.Console.WriteLine(funcionarios[i].id + ", " + funcionarios[i].nome + ", " + funcionarios[i].salario);
            }
        }
    }
}
