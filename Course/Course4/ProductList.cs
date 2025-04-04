using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class ProductList
    {
        public void List()
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) { 
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) { 
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine($"Average Price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
