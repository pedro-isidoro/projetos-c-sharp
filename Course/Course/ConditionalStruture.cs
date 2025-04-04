using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class ConditionalStruture
    {
        public void Conditionals()
        {
            int x = 10;

            Console.WriteLine("Bom dia");
            if (x < 5)
            {
                Console.WriteLine("Boa tarde");
            }
            if (x > 5)
            {
                Console.WriteLine("Boa tarde 2.0");
            }
            Console.WriteLine("Boa noite");

            Console.WriteLine("------------------------");

            Console.WriteLine("Entre com um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            //if (hora < 12)
            //{
            // Console.WriteLine("Bom Dia!");
            //}
            //else if (hora < 18)
            //{
            // Console.WriteLine("Boa Tarde!");
            //}
            //else
            //{
            // Console.WriteLine("Boa Noite!");
            //}

            //Ou

            if (hora < 12)
                Console.WriteLine("Bom Dia!");
            else if (hora < 18)
                Console.WriteLine("Boa Tarde!");
            else
                Console.WriteLine("Boa Noite!");

        }
    }
}
