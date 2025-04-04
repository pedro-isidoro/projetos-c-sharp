using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class FirstExerciceCall
    {

        public void Call()
        {
            Console.Write("How many rooms will be rented?");

            FirstExercice[] vect = new FirstExercice[10];
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                // Verifica se o número do quarto é válido
                if (roomNumber < 0 || roomNumber >= vect.Length)
                {
                    Console.WriteLine("Invalid room number! Try again.");
                    i--; // Repetir a iteração
                    continue;
                }

                // Verifica se o quarto já está ocupado
                if (vect[roomNumber] != null)
                {
                    Console.WriteLine("Room already occupied! Choose another.");
                    i--;
                    continue;
                }


                vect[roomNumber] = new FirstExercice
                {
                    Rent = i,
                    Name = name,
                    Email = email,
                    RoomNumber = roomNumber
                };

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < vect.Length; i++)
            {
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine($"{i}: {vect[i].Name}, {vect[i].Email}");
                    }
                }
            }
        }
    }
}
