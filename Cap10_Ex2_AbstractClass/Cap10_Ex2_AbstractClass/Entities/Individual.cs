using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10_Ex2_AbstractClass.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double tax;
            if (AnnualIncome < 20000)
            {
                tax = AnnualIncome * 0.15;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }
            if (HealthExpenditures > 0)
            {
                tax -= 0.5 * HealthExpenditures;
            }
            return tax;
        }
    }
}
