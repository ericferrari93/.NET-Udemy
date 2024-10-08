﻿
/*
                    Exercicio de Fixação
---------------------------------------------------------
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
Exemplos:
Entrada: 16 2    Saída: O JOGO DUROU 10 HORA(S)
Entrada: 0 0     Saída: O JOGO DUROU 24 HORA(S)
Entrada: 2 16    Saída: O JOGO DUROU 14 HORA(S)

*/



namespace EstruturaCondicional4
{
    class Condicional4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a hora inicial e a hora final do jogo: ");
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}