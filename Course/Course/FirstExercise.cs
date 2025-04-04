using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class FirstExercise
    {
        public void FirstExerciseOfCourse()
        {
            Console.WriteLine("-------------------------------");
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preco e $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preco e $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-------------------------------");
        }
    }
}
