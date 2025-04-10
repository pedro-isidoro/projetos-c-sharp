using System;
using System.Globalization;
using System.Text;

namespace Course7.FirstExerciceEntities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        public Employee() { 
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.AppendLine(Name);
            sb.Append("Hours: ");
            sb.AppendLine(Hours.ToString());
            sb.Append("Value per hour: ");
            sb.AppendLine(ValuePerHour.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
