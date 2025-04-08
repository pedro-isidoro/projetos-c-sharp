using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class FourthExerciceCall
    {
        public void Call()
        {
            int[] mat = new int[2];
            Console.WriteLine("Quantas linhas e colunas?");
            string[] values = Console.ReadLine().Split(' ');
            for (int i = 0; i < 2; i++)
            {
                mat[i] = int.Parse(values[i]);
            }

            int[,] mat2 = new int[mat[0], mat[1]];

            Console.WriteLine($"Valores da Matriz - {mat[0]} linhas e {mat[1]} colunas");

            for (int i = 0; i < mat[0]; i++)
            {
                values = Console.ReadLine().Split(' ');
                for (int j = 0; j < mat[1]; j++)
                {
                    mat2[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Selecione um valor do array: ");

            int selecteValue = int.Parse(Console.ReadLine());

            bool found = false;
            List<FourthExercice> foundedlist = new List<FourthExercice>();

            for (int i = 0; i < mat[0]; i++)
            {
                for (int j = 0; j < mat[1]; j++)
                {
                    if (mat2[i, j] == selecteValue)
                    {
                        int selectedRow = i;
                        int selectedColumn = j;
                        foundedlist.Add(new FourthExercice{ Row = selectedRow, Col = selectedColumn});
                        found = true;
                    }
                }
            }

            if (found)
            {
                foreach ( FourthExercice obj in foundedlist)
                {
                    Console.WriteLine($"Position: {obj.Row},{obj.Col}");
                    FourthExercice.ShowNeighborhoods(mat2, obj.Row, obj.Col);
                }
            } else
            {
                Console.WriteLine("Value not found.");
            }

        }
    }
}
