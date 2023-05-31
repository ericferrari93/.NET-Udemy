using System;
using System.Globalization;

/*
                 Exercicio de Fixação
---------------------------------------------------------
Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.

Entrada:
3.0 4.0 5.2
Saída:
TRIANGULO: 7.800
CIRCULO: 84.949
TRAPEZIO: 18.200
QUADRADO: 16.000
RETANGULO: 12.000

Entrada:
12.7 10.4 15.2
Saída:
TRIANGULO: 96.520
CIRCULO: 725.833
TRAPEZIO: 175.560
QUADRADO: 108.160
RETANGULO: 132.080


*/

namespace ExecEstrSeque6
{
    class ExecEstrSeque6
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double triangulo = (a * c) / 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;


            Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
