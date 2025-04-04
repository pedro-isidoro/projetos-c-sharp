using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Course3
{
    internal class NewProduct
    {
        public string Name;
        public double Price;
        public int Qtt;
        /*
        //Sobrecarga é quando instanciamos mais de 1 constructor

        //Esse constructor, permite nao passar nada
        public NewProduct()
        {
        }
        //Esse obriga ter os 3 parametros
        public NewProduct(string name, double price, int qtt)
        {
            Name = name;
            Price = price;
            Qtt = qtt;
        }
        //Esse deixa a quantidade nao obrigatoria
        public NewProduct(string name, double price) {
            Name = name;
            Price = price;
            Qtt = 0;
        }

        */

        //This
        public NewProduct()
        {
            Qtt = 10;
        }
        //Aqui ele irá pegar o qtt do constructor de cima
        public NewProduct(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }
        //Aqui ele pegará as informações, name e price, do constructor anterior
        public NewProduct(string name, double price, int qtt) : this(name, price)
        {
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
