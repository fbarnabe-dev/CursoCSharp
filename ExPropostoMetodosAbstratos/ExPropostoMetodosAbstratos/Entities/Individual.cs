using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPropostoMetodosAbstratos.Entities
{

    // Subclasse para pessoas físicas
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        // Implementação do cálculo do imposto para pessoa física
        public override double Tax()
        {
            double tax;
            if (AnnualIncome < 20000.0)
            {
                tax = AnnualIncome * 0.15;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }
            tax -= HealthExpenditures * 0.5;
            if (tax < 0.0)
            {
                tax = 0.0;
            }
            return tax;
        }
    }
}

