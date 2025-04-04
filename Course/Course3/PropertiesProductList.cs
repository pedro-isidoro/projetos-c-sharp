using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3
{
    internal class PropertiesProductList
    {
        public void List()
        {
            PropertiesProduct p = new("TV", 500.00, 10);

            p.Name = ("TV 4K");
            //p.Name = ("T");

            Console.WriteLine(p.Name);
        }
    }
}
