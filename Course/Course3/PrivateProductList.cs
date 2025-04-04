using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3
{
    internal class PrivateProductList
    {
        public void List()
        {
            PrivateProduct p = new("TV", 500.00, 10);

            //p.SetName("TV 4K");
            p.SetName("T");

            Console.WriteLine(p.GetName());
        }
    }
}
