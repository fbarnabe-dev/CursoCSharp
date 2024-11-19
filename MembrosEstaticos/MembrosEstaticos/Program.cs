using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicita ao usuário que entre com o valor do raio
            Console.Write("Entre com o valor do Raio: ");
            // Lê o valor inserido pelo usuário e converte para double usando a cultura invariante
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcula a circunferência usando o método Circunferencia
            double circ = Calculadora.Circunferencia(raio);
            // Calcula o volume usando o método Volume
            double volume = Calculadora.Volume(raio);

            // Exibe o resultado da circunferência formatado com duas casas decimais
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            // Exibe o resultado do volume formatado com duas casas decimais
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            // Exibe o valor de Pi formatado com duas casas decimais
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
