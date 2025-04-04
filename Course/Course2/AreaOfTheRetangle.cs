using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class AreaOfTheRetangle
    {
        public void AreaRetangle() {
            Retangle retangle;
            retangle = new Retangle();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangle.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangle.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"AREA = {retangle.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro = {retangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {retangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
