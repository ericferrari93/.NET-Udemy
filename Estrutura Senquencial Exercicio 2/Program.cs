using System;
using System.Globalization;

/*
                 Exercicio de Fixação
---------------------------------------------------------
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159

Exemplos:
Entrada: 2.00    Saída: A = 12.5664

Entrada: 100.64  Saída: A = 31819.3103
           
Entrada: 150.00  Saída: A = 70685.7750
*/

namespace ExecEstrSeque2
{
    class ExecEstrSeque2
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = 3.14159;
            double n3 = n2 * Math.Pow(n1, 2.0);

            Console.WriteLine($"A = " + n3.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
