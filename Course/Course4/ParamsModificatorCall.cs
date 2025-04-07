using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class ParamsModificatorCall
    {
        public void Call()
        {
            //1° Forma de se usar
            int s1 = ParamsModificator.Sum(new int[] { 2, 5 });
            int s2 = ParamsModificator.Sum(new int[] { 10, 20, 30 });

            Console.WriteLine($"Valor da soma-1: {s1}");
            Console.WriteLine($"Valor da soma-2: {s2}");

            //2° Forma de se usar - Usandose Params
            int s3 = ParamsModificator.ParamsSum(2, 5);
            int s4 = ParamsModificator.ParamsSum(10, 20, 30);

            Console.WriteLine($"Valor da soma-1: {s3}");
            Console.WriteLine($"Valor da soma-2: {s4}");
        }
    }
}
