using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;


namespace VetoresPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

