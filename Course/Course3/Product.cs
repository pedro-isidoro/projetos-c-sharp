using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Course3
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Qtt;

        //Criando um constructor (Faz ser obrigatorio a passagem de valores padrao,
        //para nao se inicializar em nullo ou vazio)

        public Product(string name, double price, int qtt)
        {
            Name = name;
            Price = price;
            Qtt = qtt;
        }

        public double TotalValueInStorage()
        {
            return Price * Qtt;
        }

        public override string ToString()
        {
            return Name
                + " $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtt
                + " unidades, Total: $ "
                + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProduct(int quantity)
        {
            Qtt += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Qtt -= quantity;
        }
    }
}
