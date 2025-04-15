using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeers.Entites
{
    internal class CommissionEmployee : AbstractEmployee
    {
        public override double GetPayment()
        {
            return Salary * 0.1;
        }

        public override string ToString()
        {
            return Name + ", "  + Email + ", R$ " + Salary + ", Comissao: R$ " + GetPayment();
        }
    }
}
