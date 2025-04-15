using System;
using System.Collections.Generic;
using Course11.CourseExerciceEntities;
namespace Course11
{
	public class CourseExercice
	{
		public void Call()
		{
			Console.WriteLine("Hello, I'm Alex your new Teacher!");
            HashSet<Student> aSet = GetStudentsFromCourse("A");
            HashSet<Student> bSet = GetStudentsFromCourse("B");
            HashSet<Student> cSet = GetStudentsFromCourse("C");

            HashSet<Student> totalStudents = new HashSet<Student>(aSet);
            totalStudents.UnionWith(bSet);
            totalStudents.UnionWith(cSet);

            Console.WriteLine($"Total students: {totalStudents.Count}");
        }
        private HashSet<Student> GetStudentsFromCourse(string courseName)
        {
            HashSet<Student> students = new HashSet<Student>();

            Console.Write($"How many students for course {courseName}? ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
            {
                Console.Write("Please enter a valid non-negative number: ");
            }

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Enter code for student #{i + 1}: ");
                int code;
                while (!int.TryParse(Console.ReadLine(), out code))
                {
                    Console.Write("Invalid code. Enter again: ");
                }

                students.Add(new Student { StudentCode = code });
            }

            return students;
        }

    }
}

