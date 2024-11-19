using System;
using System.Collections.Generic;
using ExHerança.Entities;
using System.Globalization;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de funcionários (Employee)
            List<Employee> list = new List<Employee>();

            // Solicita o número de funcionários
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            // Loop para inserir os dados de cada funcionário
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                // Verifica se o funcionário é terceirizado
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                // Solicita nome, horas trabalhadas e valor por hora
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Se terceirizado, solicita o valor adicional e cria um objeto OutsourcedEmployee
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                // Se não terceirizado, cria um objeto Employee
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            // Exibe os pagamentos de cada funcionário
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                // Mostra o nome do funcionário e o pagamento calculado
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
