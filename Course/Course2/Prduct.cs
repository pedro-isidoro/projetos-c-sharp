using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Course2
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Qtt;

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
