
/*
                    Exercicio de Fixação
---------------------------------------------------------
Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
Exemplos:
Entrada: -10 Saída: NEGATIVO
Entrada: 8   Saída: NAO NEGATIVO
Entrada: 0   Saída: NAO NEGATIVO

*/



namespace EstruturaCondicional1
{
    class Condicional1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");

            }
        }
    }
}