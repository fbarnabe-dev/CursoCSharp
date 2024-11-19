using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            // EXERCICIO PROPOSTO PARA ENTRADA DE DADOS, PROCESSAMENTO E SAIDA DE DADOS
            Console.WriteLine("Entre com seu nome Completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura ");
            string[] vet = Console.ReadLine().Split(' ');
            string u = vet[0];
            int i = int.Parse(vet[1]);
            double a = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(u);
            Console.WriteLine(i);
            Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));


            /* EXEMPLOS ENTRADA DE DADOS ABAIXO FEITO DURANTE O CURSO
            
            
              string frase = Console.ReadLine();
              string x = Console.ReadLine();
              string y = Console.ReadLine();
              string z = Console.ReadLine();


              string[] vet = Console.ReadLine().Split(' ');
              string a = vet[0];
              string b = vet[1];
              string c = vet[2];

              Console.WriteLine("Voce digitou: " + frase);
              Console.WriteLine(frase);
              Console.WriteLine(x);
              Console.WriteLine(y);
              Console.WriteLine(z);
              Console.WriteLine(a);
              Console.WriteLine(b);
              Console.WriteLine(c); 

            // ENTRADA DE DADOS PARTE 02

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(d);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura); */
        }
    }
}







