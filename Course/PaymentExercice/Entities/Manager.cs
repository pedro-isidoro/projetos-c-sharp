using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExercice.Entities
{
    internal class Manager : AbstractEmployee
    {
        public double BonusPercentage { get; set; }
        public override double GetPayment()
        {
            double extra = BaseSalary * BonusPercentage;
            return BaseSalary + extra;
        }

        public override string ToString()
        {
            double bonus = BaseSalary * BonusPercentage;
            return Name
                + ", Base Salary: R$ " + BaseSalary.ToString("F2", CultureInfo.InvariantCulture)
                + ", Bonus: R$ " + bonus.ToString("F2", CultureInfo.InvariantCulture)
                + ", Total: R$ " + GetPayment().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
