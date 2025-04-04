using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class ProductList
    {
        public void List()
        {
            Product p = new Product();

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome:");
            p.Name = Console.ReadLine();

            Console.WriteLine("Preço:");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Quantidade em estoque:");
            p.Qtt = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qteToAdd = int.Parse(Console.ReadLine());
            p.AddProduct(qteToAdd);
            Console.WriteLine();

            Console.WriteLine($"Dados Atualizados: {p}");
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int qeToRemonve = int.Parse(Console.ReadLine());
            p.RemoveProduct(qeToRemonve);
            Console.WriteLine();

            Console.WriteLine($"Dados Atualizados: {p}");


        }

    }
}
