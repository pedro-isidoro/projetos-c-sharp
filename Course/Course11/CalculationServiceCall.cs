using System;
using System.Globalization;
namespace Course11
{
	public class CalculationServiceCall
	{
        public void Call()
        {
            //	List<int> list = new List<int>();

            //  Console.Write("Enter N: ");
            //	int n = int.Parse(Console.ReadLine());

            //	for(int i = 1; i <= 3; i++)
            //	{
            //		int x = int.Parse(Console.ReadLine());
            //		list.Add(x);
            //	}

            //	CalculationService calculationService = new CalculationService();

            //	int max = calculationService.Max(list);

            //	Console.WriteLine("Max:");
            //	Console.WriteLine(max);
            
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
	}
}
