using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class Comparatives
    {
        public void ComparativesFunctions() {
            int a = 10;
            bool c1 = a < 10;

            Console.WriteLine(c1);
            Console.WriteLine("----------------------------");

            bool c2 = 2 > 3 && 4 != 5;
            bool c3 = 2 < 3 && 5 == 5;
            bool d1 = 2 > 3 || 4 != 5;

            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(d1);
        }
    }
}
