using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class StudentGrade
    {
        public void Grade() {
            Student student = new Student();
            
            Console.WriteLine("Nome do aluno:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno:");
            student.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"Nota Final = {(student.FinalNote()).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(student.Situation());
        }
    }
}
