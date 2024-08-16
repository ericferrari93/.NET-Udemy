
/*
                    Exercicio de Fixação
---------------------------------------------------------
Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
Exemplos:
Entrada: 12    Saída: PAR
Entrada: -27   Saída: IMPAR
Entrada: 0     Saída: PAR

*/



namespace EstruturaCondicional2
{
    class Condicional2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");

            }
        }
    }
}