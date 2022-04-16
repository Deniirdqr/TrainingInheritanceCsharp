using System;
using System.Collections.Generic;
using System.Globalization;

namespace TrainingTen.Entities
{
    internal class CompanyPayer : Payer
    {
        public  int NumberEmployees  { get; set; }

        public CompanyPayer()
        {
        }

        public CompanyPayer(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Taxes()
        {
            double taxes = 0.0;

            if (NumberEmployees > 10)
            {
                taxes = AnualIncome * 0.14;
            }
            else
            {
                taxes = AnualIncome * 0.16;
            }
            return taxes;
        }
    }
}
