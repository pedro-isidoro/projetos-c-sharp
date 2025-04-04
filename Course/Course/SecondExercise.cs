using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class SecondExercise
    {
        public void SecondExerciseOfCourse() {
            Console.WriteLine("Entre com seu nome completo:");
            string name =  Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Quantos quartos tem na sua casa");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine(qtd);
            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine(price.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2]);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
