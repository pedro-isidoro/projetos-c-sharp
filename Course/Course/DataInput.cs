using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class DataInput
    {
        public void Data()
        {
            Console.WriteLine("Escreva algo: ");
            string phrase = Console.ReadLine();
            Console.WriteLine("Agora Cor 1: ");
            string color1 = Console.ReadLine();
            Console.WriteLine("Agora Cor 2: ");
            string color2 = Console.ReadLine();
            Console.WriteLine("Agora Cor 3: ");
            string color3 = Console.ReadLine();

            Console.WriteLine("--------------------");
            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(phrase);
            Console.WriteLine(color1);
            Console.WriteLine(color2);
            Console.WriteLine(color3);

            Console.WriteLine("--------------------");
            Console.WriteLine("Escreva 3 palavras: ");
            string newPhrase = Console.ReadLine();
            string[] vet = newPhrase.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
    internal class DataInput2
    {
        public void Data2()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            //OU double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(ch);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Digite um Nome Sexo Idade e Altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        }
    }
}
