using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class ForEachCall
    {
        public void Call() {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i < vect.Length; i++) { 
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-------------------------------------------------------------");

            foreach (string obj in vect) { 
                Console.WriteLine(obj);
            }
        }
    }
}
