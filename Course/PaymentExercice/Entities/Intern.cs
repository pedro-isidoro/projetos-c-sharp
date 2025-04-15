using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExercice.Entities
{
    internal class Intern : AbstractEmployee
    {
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }

        public override double GetPayment()
        {
            double basePerDay = WorkingHours * HourlyRate;
            return basePerDay * 30;
        }

        public override string ToString()
        {
            return Name
                + ", Salary: R$ "
                + GetPayment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
