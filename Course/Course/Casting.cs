using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course1
{
    internal class Casting
    {
        public void ExplicitConverting()
        {

            // Tipo Implicito
            double a, c;
            float b;
            int d;

            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            c = 5;
            d = 2;
            //Tem que lembrar da malicia, e lembrar de converter, senao retorna um int
            Console.WriteLine((double)c / d);
            //Ou
            Console.WriteLine(10.0 / 8);

            double delta = Math.Pow(-3.0, 2.0) - 4.0 * 1.0 * -4.0;
            Console.WriteLine(delta);
        }
    }
}