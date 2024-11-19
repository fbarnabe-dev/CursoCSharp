using ExPropostoMetodosAbstratos.Entities;
using System.Globalization;
using System;

namespace ExPropostoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista que armazenará os contribuintes
            List<Taxpayer> list = new List<Taxpayer>();

            // Entrada da quantidade de contribuintes
            Console.Write("Enter the number of taxpayers: ");
            int n = int.Parse(Console.ReadLine());

            // Loop para coletar dados de cada contribuinte
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Taxpayer #{i} data:");

                // Pergunta se o contribuinte é pessoa física ou jurídica
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                // Coleta o nome e renda anual
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Se for pessoa física, coleta também os gastos com saúde
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                // Se for pessoa jurídica, coleta o número de funcionários
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            // Exibe o imposto pago por cada contribuinte
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach (Taxpayer taxpayer in list)
            {
                double tax = taxpayer.Tax();
                Console.WriteLine(taxpayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += tax;
            }

            // Exibe o total de imposto arrecadado
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
