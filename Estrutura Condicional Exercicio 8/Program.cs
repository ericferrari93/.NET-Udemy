
/*
                    Exercicio de Fixação
---------------------------------------------------------
Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.
Exemplos:
Entrada: 3002.00    Saída: R$ 80.36
Entrada: 1701.12    Total: Isento
Entrada: 4520.00    Total: R$ 355.60

*/

using System.Globalization;

namespace EstruturaCondicional8
{
    class Condicional8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor da Renda: ");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double impostoFaixa1;
            double impostoFaixa2;
            double impostoFaixa3;
            double isencao1;
            double isencao2;
            double isencao3;

            if (renda > 0 && renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (renda > 2000.00 && renda <= 3000.00)
            {
                isencao1 = renda - 2000;
                impostoFaixa1 =  isencao1 * 0.08;
                Console.WriteLine("R$ " + impostoFaixa1.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (renda > 3000.00 && renda <= 4500.00)
            {   
                isencao1 = renda - 2000; 
                isencao2 = ; 
                impostoFaixa2 = ;
                Console.WriteLine("R$ " + impostoFaixa2.ToString("F2", CultureInfo.InvariantCulture));
            }




        }
    }
}