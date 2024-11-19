using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPropostoMetodosAbstratos.Entities
{

        // Subclasse para pessoas jurídicas
        class Company : Taxpayer
        {
            public int NumberOfEmployees { get; set; }

            public Company(string name, double annualIncome, int numberOfEmployees)
                : base(name, annualIncome)
            {
                NumberOfEmployees = numberOfEmployees;
            }

            // Implementação do cálculo do imposto para pessoa jurídica
            public override double Tax()
            {
                if (NumberOfEmployees > 10)
                {
                    return AnnualIncome * 0.14;
                }
                else
                {
                    return AnnualIncome * 0.16;
                }
            }
        }
    }


