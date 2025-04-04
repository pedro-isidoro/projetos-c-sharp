using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course3;

namespace Course3
{
    internal class NewProductList
    {
        public void List()
        {
            //Com o constructor, agora fazemos instancias temporaria, e depois passamos para a classe
            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Preço:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade em estoque:");
            int qtt = int.Parse(Console.ReadLine());

            //POR CONTA DOS CONSTRUCTORS
            //Posso passar os 3 - Constructor Padrão (Ele permite usar aquele personalizado com {})
            NewProduct p = new NewProduct(name, price, qtt);
            //Posso passar apenas 2
            NewProduct p2 = new NewProduct(name, price);
            //Posso passar 0
            NewProduct p3 = new NewProduct();

            //Posso chamar assim tambem, mesmo sem constructors
            NewProduct p4 = new NewProduct { //posso ou nao colocar o () depois de NewProduct 
                Name = "TV", 
                Price = 500.00, 
                Qtt = 20
            };

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
