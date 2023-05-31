using System;
using System.Globalization;

/*
                 Exercicio de Fixação
---------------------------------------------------------
Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada:
5
6
7
8
Saída:
DIFERENCA = -26

Entrada:
5
6
-7
8
Saída:
DIFERENCA = 86
*/

namespace ExecEstrSeque3
{
    class ExecEstrSeque3
    {
        static void Main(string[] args)
        {
           int A = int.Parse(Console.ReadLine());
           int B = int.Parse(Console.ReadLine());
           int C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           int D = int.Parse(Console.ReadLine());
           int R = A * B - C * D;
           
           Console.WriteLine($"DIFERENÇA = {R}");
           

        }
    }
}
