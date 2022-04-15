using System;
using System.Collections.Generic;
using System.Globalization;

namespace TrainingTen.Entities
{
    internal class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer()
        {
        }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double Taxes()
        {
            double taxes = 0.0;

            if(AnualIncome  > 20000.00)
            {
                taxes = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            else
            {
                taxes = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            return taxes;
        }
    }
}
