// Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um sumário do
// pedido conforme exemplo. Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now
//
// |                ORDER                |
// |-------------------------------------|                  |      ORDERITEM       |
// | - moment: Date                      |                  |----------------------|                  |     PRODUCT     |
// | - status: OrderStatus               |        - items   | - quantity: Integer  |       - product  |-----------------|
// |-------------------------------------| ---------------> | - price: Double      | ---------------> | - name: String  |
// | + addItem(item: OrderItem): void    |              *   |----------------------|               1  | - price: Double |
// | + removeItem(item: OrderItem): void |                  | + subTotal(): Double |
// | + total(): Double                   |
//
//                    |
//                    |                                                              |         <<enum>>           |
//                 1  |  - client                                                    |        ORDERSTATUS         |
//                    V                                                              |----------------------------|
//                                                                                   | - PENDING_PAYMENT: int = 0 |
//          |       CLIENT      |                                                    | - PROCESSING: int = 1      |
//          |-------------------|                                                    | - SHIPPED: int = 2         |
//          | - name: String    |                                                    | - DELIVERED: int = 3       |
//          | - email: String   |
//          | - birthDate: Date |

using System;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
