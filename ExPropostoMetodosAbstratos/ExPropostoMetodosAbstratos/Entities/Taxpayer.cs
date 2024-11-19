using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPropostoMetodosAbstratos.Entities
{
    // Classe base para os contribuintes
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        // Método abstrato para calcular o imposto
        public abstract double Tax();
    }

}
