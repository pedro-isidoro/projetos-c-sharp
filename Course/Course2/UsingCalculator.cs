using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Course2
{
    internal class UsingCalculator
    {
        public void UsingTheCalculator() {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circumference(raio);
            double vol = Calculator.Volume(raio);

            Console.WriteLine($"Circunsferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
