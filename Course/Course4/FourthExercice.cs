using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class FourthExercice
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public static void ShowNeighborhoods(int[,] mat, int linha, int coluna)
        {
            if (coluna > 0)
            {
                Console.WriteLine($"Left: {mat[linha, coluna - 1]}");
            }
            if (linha > 0)
            {
                Console.WriteLine($"Up: {mat[linha - 1, coluna]}");
            }
            if (coluna < mat.GetLength(1) - 1)
            {
                Console.WriteLine($"Rigth: {mat[linha, coluna + 1]}");
            }
            if (linha < mat.GetLength(0) - 1)
            {
                Console.WriteLine($"Down: {mat[linha + 1, coluna]}");
            }
        }
    }
}
