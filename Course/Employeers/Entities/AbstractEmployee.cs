using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeers.Entites
{
    internal abstract class AbstractEmployee : IPayable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public abstract double GetPayment();
    }
}
