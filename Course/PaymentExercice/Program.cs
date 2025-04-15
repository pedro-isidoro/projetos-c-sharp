using System;
using System.Globalization;
using PaymentExercice.Entities;

namespace PaymentExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer() { Name = "Pedro", BaseSalary = 2700.00, NumberOfProjects = 2};
            Manager manager = new Manager() { Name = "Jason", BaseSalary = 4000, BonusPercentage = 0.02 };
            Intern intern = new Intern() { Name = "Victor", WorkingHours = 5, HourlyRate = 10 };
            List<AbstractEmployee> employess = new List<AbstractEmployee> { 
                manager,
                developer,
                intern,
            };

            double total = 0.0;
            foreach (AbstractEmployee emp in employess)
            {
                Console.WriteLine(emp);
                total += emp.GetPayment();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL PAYMENT by Employeer: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
