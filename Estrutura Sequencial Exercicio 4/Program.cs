using System;
using System.Globalization;

/*
                 Exercicio de Fixação
---------------------------------------------------------
Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.

Entrada:
25
100
5.50
Saída:
NUMBER = 25
SALARY = U$ 550.00

Entrada:
1
200
20.50
Saída:
NUMBER = 1
SALARY = U$ 4100.00

Entrada:
6
145
15.55
Saída:
NUMBER = 6
SALARY = U$ 2254.75
*/

namespace ExecEstrSeque4
{
    class ExecEstrSeque4
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valorPorHora;

            Console.WriteLine($"Number = {numero}");
            Console.WriteLine("Salary = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
