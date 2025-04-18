﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course5
{
    internal class StringsFunctions
    {
        public void String()
        {
            //Formatar
            string original = "abcde FGHIJ ABC abc DEFG     ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            //Buscar
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            //Recortar
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            //Substituir
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            //Ver o estado do resultado
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);
            //Ainda temos:
            //Split('')
            //Conversão para número
            //int x = int.Parse()
            //int x = Convert.ToInt32(str)
            //Conversão de número
            //str = x.ToString()
            //str = x.ToString("C")
            //str = x.ToString("C3")
            //str = x.ToString("F2")

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"ToLower: -{s2}-");
            Console.WriteLine($"Trim: -{s3}-");
            Console.WriteLine($"IndexOf: {n1}");
            Console.WriteLine($"LastIndexOf: {n2}");
            Console.WriteLine($"Substring(3): -{s4}-");
            Console.WriteLine($"Substring(3, 5): -{s5}-");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");

        }
    }
}
