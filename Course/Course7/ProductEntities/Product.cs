using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course7.ProductEntities
{
    //Caso torne a classe em Abstrata (Palavra em Italico)
    //Não dará para instaciar seus valores,
    //apenas instanciar o de suas subclasses
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { 
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name}, $ {Price}";
        }
    }
}
