using System;
using System.Globalization;
using Course7.TaxesExerciceEntities;

namespace Course7.TaxesExerciceEntities
{
    internal class Individual : TaxPayer
    {
       public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15;
            }
            else
            {
                if (HealthExpenditures > 0)
                {
                    return AnnualIncome * 0.25 - HealthExpenditures * 0.50;
                }
                else
                {
                    return AnnualIncome * 0.25;
                }
            }
        }
    }
}
