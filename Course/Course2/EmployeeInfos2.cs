using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
	internal class EmployeeInfos2
	{
		public void Infos2()
		{
			Employee2 person1;

			person1 = new Employee2();

			Console.WriteLine("Nome: ");
			person1.Name = Console.ReadLine();
			Console.WriteLine("Sal�rio bruto: ");
			person1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Imposto: ");
			person1.Tariff = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine();
			Console.WriteLine($"Funcion�rio: {person1}");
			Console.WriteLine();
			Console.WriteLine("Digite a porcetagem para aumentar o sal�rio: ");
			double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			person1.NewSalary(percent);
			Console.WriteLine();
			Console.WriteLine($"Dados Atualizados: {person1}");

		}
	}
}