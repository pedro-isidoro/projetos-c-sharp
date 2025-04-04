using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class Functions
    {
        public void Function()
        {
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //if(n1 > n2 && n1> n3)
            //{
            //Console.WriteLine($"O {n1} é o maior número!");
            //}
            //else if (n2 > n3)
            //{
            //Console.WriteLine($"O {n2} é o maior número!");
            //}
            //else
            //{
            //Console.WriteLine($"O {n3} é o maior número!");
            //}

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }

        int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c) { 
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
