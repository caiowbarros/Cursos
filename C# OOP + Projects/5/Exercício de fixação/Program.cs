// Em um banco, para se cadastrar uma conta bancário, é necessário informar o número da conta, o nome do
// titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de
// depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento
// de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
//
// Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o
// nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
//
// Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso.
// O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o
// banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o salvo não for suficiente para
// realizar o saque e/ou pagar a taxa.
//
// Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o
// valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da
// conta após cada operação.

using System;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1;
            System.Console.WriteLine("Digite o número da conta:");
            int numConta = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite o nome do titular da conta:");
            string nomeTitular = Console.ReadLine();
            System.Console.WriteLine("Deseja fazer um depósito inicial? (S/N)");
            string desejaDepositar = Console.ReadLine();

            if (desejaDepositar == "S") {
                System.Console.WriteLine("Digite o valor inicial do depósito:");
                double depositoInicial = Convert.ToDouble(Console.ReadLine());
                conta1 = new Conta(numConta, nomeTitular, depositoInicial);
            } else if (desejaDepositar == "N") {
                conta1 = new Conta(numConta, nomeTitular);
            } else {
                System.Console.WriteLine("Por favor, digite uma resposta válida.");
                conta1 = null;
            }

            conta1.depositar(1000);
            conta1.sacar(1500);
        }
    }
}
