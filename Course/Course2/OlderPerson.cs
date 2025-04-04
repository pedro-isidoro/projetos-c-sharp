using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class OlderPerson
    {
        public void OPerson()
        {
            Person person1, person2;
            person1 = new Person();
            person2 = new Person();
            Console.WriteLine("Dados da Primeira Pessoa: ");
            Console.Write("Nome: ");
            person1.name = Console.ReadLine();
            Console.Write("Idade: ");
            person1.age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            person2.name = Console.ReadLine();
            Console.Write("Idade: ");
            person2.age = int.Parse(Console.ReadLine());

            if (person1.age > person2.age)
            {
                Console.WriteLine($"Pessoa Mais Velha: {person1.name}");
            }
            else
            {
                Console.WriteLine($"Pessoa Mais Velha: {person2.name}");
            }
        }
    }
}
