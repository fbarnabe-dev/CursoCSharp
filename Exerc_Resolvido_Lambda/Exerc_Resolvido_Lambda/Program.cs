using Exerc_Resolvido_Lambda.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exerc_Resolvido_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Solicita o caminho do arquivo ao usuário
                Console.Write("Enter full file path: ");
                string filePath = Console.ReadLine();

                // Lê os dados do arquivo
                List<Employee> employees = new List<Employee>();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }
                }

                // Solicita o salário limite ao usuário
                Console.Write("Enter salary: ");
                double salaryThreshold = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Filtra e ordena os funcionários com salário acima do limite
                var emailsAboveThreshold = employees
                    .Where(e => e.Salary > salaryThreshold)
                    .OrderBy(e => e.Name)
                    .Select(e => e.Email);

                Console.WriteLine("Email of people whose salary is more than {0:F2}:", salaryThreshold);
                foreach (var email in emailsAboveThreshold)
                {
                    Console.WriteLine(email);
                }

                // Soma os salários de funcionários cujo nome começa com 'M'
                double sumOfSalaries = employees
                    .Where(e => e.Name.StartsWith("M", StringComparison.InvariantCultureIgnoreCase))
                    .Sum(e => e.Salary);

                Console.WriteLine("Sum of salary of people whose name starts with 'M': {0:F2}", sumOfSalaries);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid file format or input.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
        }
    }
}
