using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class Types
    {
        public void TypeOfVariables()
        {
            //SByte - System
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 2147483647;
            long n3 = 2147483647L;
            bool completo = false;
            char gender = 'F';
            char letra = '\u0041';
            float n4 = 4.5f;
            double n5 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            double saldo = 10.35784;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(completo);
            Console.WriteLine(gender);
            Console.WriteLine(letra);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("------Tecnica do Placeholder-------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, n1, saldo);
            Console.WriteLine("------Tecnica da Interpolacao-------");
            Console.WriteLine($"{nome} tem {n1} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine("------Tecnica da Concatenacao-------");
            Console.WriteLine(nome + " tem" + n1 + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine("-------------------------------");
        }
    }
}
