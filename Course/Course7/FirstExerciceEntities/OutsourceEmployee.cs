using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course7.FirstExerciceEntities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Additional charge: ");
            sb.AppendLine(AdditionalCharge.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
