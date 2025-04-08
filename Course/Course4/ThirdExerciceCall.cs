using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course4
{
    internal class ThirdExerciceCall
    {
        public void Call()
        {
            Console.Write("Qual a ordem da Matriz? ");
            int qtt = int.Parse(Console.ReadLine());


            int[,] mat = new int[qtt, qtt];

            /*//Percorre as linhas
            for (int i = 0; i < qtt; i++)
            {
                //Percorre as colunas
                for (int j = 0; j < qtt; j++)
                {
                    int value = int.Parse(Console.ReadLine());
                    mat[i, j] = value;
                }
            }*/
            for (int i = 0; i < qtt; i++)
            {
                //Assim leremos a linha inteira, pois faremos o usuário digitá-la
                //ao inves de ter que digitar um valor por linha
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < qtt; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int[] mainDiagonal = new int[qtt];
            int negativeNumbers = 0;

            /*for (int i = 0; i < qtt; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < qtt; j++)
                {
                    if (i == j)
                    {
                        mainDiagonal[i] = mat[i, j];
                    }
                    if (mat[i, j] < 0)
                    {
                        negativeNumbers++;
                    }
                }
            }*/
            
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < qtt; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < qtt; i++)
            {
                for (int j = 0; j < qtt; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negativeNumbers++;
                    }
                }
            }

            //Console.WriteLine("Main diagonal:");
            //Console.WriteLine(string.Join(" ", mainDiagonal));
            Console.WriteLine($"Negative numbers = {negativeNumbers}");
        }
    }
}
