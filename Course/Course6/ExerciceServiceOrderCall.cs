using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course6.OSEntities;
using Course6.OSEntities.Enums;

namespace Course6
{
    internal class ExerciceServiceOrderCall
    {
        public void Call()
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new(name, email, date);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OS status = Enum.Parse<OS>(Console.ReadLine());
            Order order = new(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQtt = int.Parse(Console.ReadLine());
                Product product = new(productName, productPrice);
                OrderItem item = new(productQtt, productPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
//Repositorio da solução do Professor Nélio
//https://github.com/acenelio/composition3-csharp/tree/master