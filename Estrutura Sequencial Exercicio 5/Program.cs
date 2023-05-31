using System;
using System.Globalization;

/*
                 Exercicio de Fixação
---------------------------------------------------------
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

Entrada:
12 1 5.30
16 2 5.10
Saída:
VALOR A PAGAR: R$ 15.50

Entrada:
13 2 15.30
161 4 5.20
Saída:
VALOR A PAGAR: R$ 51.40

Entrada:
1 1 15.10
2 1 15.10
Saída:
VALOR A PAGAR: R$ 30.20
*/

namespace ExecEstrSeque5
{
    class ExecEstrSeque5
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            string[] vet2 = Console.ReadLine().Split();
            int n4 = int.Parse(vet2[0]);
            int n5 = int.Parse(vet2[1]);
            double n6 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double soma = (n2 * n3) + (n5 * n6);
            

            Console.WriteLine("Valor a pagar: R$" + soma.ToString("F2", CultureInfo.InvariantCulture));
           


        }
    }
}
