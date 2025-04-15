using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExercice.Entities
{
    internal abstract class AbstractEmployee : IPayable
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public abstract double GetPayment();
    }
}
