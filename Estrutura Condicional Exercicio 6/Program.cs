
/*
                    Exercicio de Fixação
---------------------------------------------------------
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
Exemplos:
Entrada: 25.01    Saída:Total: Intervalo (25,50]
Entrada: 25.00    Saída:Total: Intervalo [0,25]
Entrada: 100.00   Saída:Total: Intervalo (75,100]]
Entrada: -25.02   Saída:Total: Fora de intervalo

*/

using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstruturaCondicional6
{
    class Condicional6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor de intervalo: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}