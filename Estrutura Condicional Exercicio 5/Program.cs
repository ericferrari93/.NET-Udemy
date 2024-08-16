
/*
                    Exercicio de Fixação
---------------------------------------------------------
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.
Exemplos:
Entrada: 3 2    Saída: Total: R$ 10.00
Entrada: 2 3    Total: R$ 13.50

*/

using System.Globalization;

namespace EstruturaCondicional5
{
    class Condicional5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código do item e a quantidade deste item: ");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            double quantidade = double.Parse(vet[1]);
            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;

                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;

                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;

                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Código não encontrado.");
            }




        }
    }
}