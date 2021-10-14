// Um posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um 
// algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
// 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
// que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem:
// "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível.

using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (cod != 4) {
                Console.WriteLine("Digite o código desejado:");
                cod = Convert.ToInt32(Console.ReadLine());

                if (cod == 1) {
                    alcool++;
                } else if (cod == 2) {
                    gasolina++;
                } else if (cod == 3) {
                    diesel++;
                } else if (cod == 4) {
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Álcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                }
            }
        }
    }
}
