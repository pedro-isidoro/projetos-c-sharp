using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeers.Entites
{
    internal class HourlyEmployee : AbstractEmployee
    {
        public override double GetPayment()
        {
            double dailyRate = Salary / 30;
            double hourlyRate = dailyRate / 9; // supondo 8h por dia
            return hourlyRate;
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", R$ " + Salary + ", Ganha por hora: R$" + GetPayment();
        }
    }
}
