using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course4
{
    internal class SecondExerciceCall
    {
        public void Call()
        {
            //Partes comentadas foi Feito com Vetor
            Console.Write("How many employees will be registered? ");
            int EmployeesQuantity = int.Parse(Console.ReadLine());

            //SecondExercice[] vect = new SecondExercice[EmployeesQuantity];
            List<SecondExercice> employees = new List<SecondExercice>();

            for (int i = 0; i < EmployeesQuantity; i++) {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                //vect[i] = new SecondExercice { Id = id, Name = name, Salary = salary };
                employees.Add(new SecondExercice { Id = id, Name = name, Salary = salary });
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //bool found = false;

            //foreach (SecondExercice obj in vect) {
            //    if (obj.Id == EmployeeId) {
            //        Console.Write("Enter the percentage: ");
            //        double Percentage = double.Parse(Console.ReadLine());
            //        obj.IncreaseSalary(Percentage);
            //        found = true;
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("This id does not exist!");
            //}

            SecondExercice employee = employees.Find(e => e.Id == EmployeeId);

            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employee");
            //foreach (SecondExercice obj in vect)
            //{
            //    Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary}");
            //}
            foreach (SecondExercice obj in employees)
            {
                Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary}");
            }

        }
    }
}
