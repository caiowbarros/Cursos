// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
// começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo valores
            Console.WriteLine("Digite a hora inicial:");
            int horaInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a hora final:");
            int horaFinal = Convert.ToInt32(Console.ReadLine());

            // Calculando e printando
            if (horaInicial == horaFinal) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            } else if (horaInicial > horaFinal) {
                Console.WriteLine("O JOGO DUROU " + (24 - horaInicial + horaFinal) + " HORA(S)");
            } else {
                Console.WriteLine("O JOGO DUROU " + (horaFinal - horaInicial) + " HORA(S)");
            }
        }
    }
}
