using System;
using System.Globalization;

namespace PaymentExercice.Entities
{
    internal class Developer : AbstractEmployee
    {
        public int NumberOfProjects { get; set; }

        public override double GetPayment()
        {
            return BaseSalary + (NumberOfProjects * 500);
        }

        public override string ToString()
        {
            return Name 
                + ", Salary: R$ "
                + GetPayment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
