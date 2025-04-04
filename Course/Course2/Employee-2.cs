using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Course2
{
    internal class Employee2
    {
        public string Name;
        public double Salary;
        public double Tariff;
        public override string ToString()
        {
            return Name
                + " , $ "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void NewSalary(double percent)
        {
            Salary = (percent * Salary / 100) + Salary; 
        }
    }
}
