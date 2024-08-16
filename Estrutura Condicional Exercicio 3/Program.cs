
/*
                    Exercicio de Fixação
---------------------------------------------------------
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente..
Exemplos:
Entrada: 6 24    Saída: Sao Multiplos
Entrada: 6 25    Saída: Nao sao Multiplos
Entrada: 24 6    Saída: Sao Multiplos

*/



namespace EstruturaCondicional3
{
    class Condicional3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dois números inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int vet1 = int.Parse(vet[0]);
            int vet2 = int.Parse(vet[1]);

            if (vet1 % vet2 == 0 || vet2 % vet1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");

            }
        }
    }
}