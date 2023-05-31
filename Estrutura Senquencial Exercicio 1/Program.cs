using System;
using System.Globalization;

/*
                 Exercicio de Fixação
---------------------------------------------------------
Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos.

Exemplos:
Entrada:       
10             
30 
Saida:
SOMA = 40

Entrada: 
-30
10
Saida:
SOMA = -20

Entrada:
0
0
Saida:
SOMA = 0

*/

namespace ExecEstrSeque1
{
    class ExecEstrSeque1
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma = {n1 + n2}");
            
        }
    }
}
