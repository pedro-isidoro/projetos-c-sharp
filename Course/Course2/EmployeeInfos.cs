using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class EmployeeInfos
    {
        public void Infos() {

            Employee employee1, employee2;
            employee1 = new Employee();
            employee2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.WriteLine("Nome:");
            employee1.name = Console.ReadLine();
            Console.WriteLine("Salário:");
            employee1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.WriteLine("Nome:");
            employee2.name = Console.ReadLine();
            Console.WriteLine("Salário:");
            employee2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio = {((employee1.salary + employee2.salary) / 2).ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
