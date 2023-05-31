using System;
using System.Globalization;

/*
                    Exercicio de Fixação
---------------------------------------------------------
Fazer um programa para executar a seguinte interação com o
usuário, lendo os valores destacados em vermelho, e depois
mostrar os dados na tela:
Entre com seu nome completo:
Alex Green
Quantos quartos tem na sua casa?
3
Entre com o preço de um produto:
500.50
Entre seu último nome, idade e altura (mesma linha):
Green 21 1.73
*/

namespace EntradaDeDados
{
    class EntradaDeDados
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split();
            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(n1);
            Console.WriteLine("Quantos quartos tem na sua casa?");
            Console.WriteLine(n2);
            Console.WriteLine("Entre como preço de um produto: ");
            Console.WriteLine(n3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
