using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Course13.FinalExerciceEntities;

namespace Course13
{
    internal class FinalExercice
    {
        public void Call()
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            
            Console.WriteLine("Enter salary: ");
            double salaryBase = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path)){
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = Double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee (name, email, salary));
                }
            }

            var emails = list
                .Where(e => e.Salary > salaryBase)
                .Select(e => e.Email)
                .OrderBy(email => email);
            Console.WriteLine($"Email of people whose salary is more than {salaryBase}: ");
            foreach (string e in emails) {
                Console.WriteLine(e);
            }

            var sumValues = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumValues.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
