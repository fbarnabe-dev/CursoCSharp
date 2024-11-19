using System;
using System.Globalization;

namespace EstruturaWhile
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo. */

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);





            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002. 

            Console.WriteLine("Digite a senha de acesso: ");
            double senha = double.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida!");
                senha = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!"); */




            /*Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }

            Console.WriteLine("Número negativo!"); */
        }
    }
}
