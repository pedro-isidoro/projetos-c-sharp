using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class AreaOfTheTriangle
    {
        public void Area()
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX.ToString("F4")}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4")}");

            double biggestArea = 0.0;
            char triangle = 'A';
            if (areaX > areaY)
            {
                biggestArea = areaX;
                triangle = 'X';
            }
            else
            {
                biggestArea = areaY;
                triangle = 'Y';
            }
            ;
            Console.WriteLine($"Maior Área: {triangle} -- {biggestArea.ToString("F4")}");
        }
    }
}
