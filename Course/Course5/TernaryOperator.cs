using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course5
{
    internal class TernaryOperator
    {
        public void Operator()
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = preco < 20.0 ? desconto = preco * 0.1 : desconto = preco * 0.05;
            Console.WriteLine($"Desconto: {desconto}");
        }
    }
}
