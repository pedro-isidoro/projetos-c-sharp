using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeers.Entites
{
    internal class SalariedEmployee : AbstractEmployee
    {
        public override double GetPayment()
        {
            return Salary;
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", R$ " + Salary;
        }
    }
}
