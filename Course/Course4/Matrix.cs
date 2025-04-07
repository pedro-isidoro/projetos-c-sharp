using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class Matrix
    {
        public void MatrixContent() {
            //"Matriz" é o nome dado a arranjos bidimensionais
            //Arranjo é uma estrutura de dados:
            //Homogênea
            //Ordenada
            //Alocada de uma vez só, em um bloco contíguo de memória

            //Vantagens
            //Acesso imediato aos elementos pela sua posição

            //Desvantagens
            //Tamanho fixo
            //Dificuldade para se realizar inserções e deleções

            double[,] mat = new double[2, 3];

            //Total de elementos
            Console.WriteLine(mat.Length);
            //Quantidade de linhas
            Console.WriteLine(mat.Rank);
            //Quantidade de linhas (primeiro atributo da Matriz)
            Console.WriteLine(mat.GetLength(0));
            //Quantidade de colunas (segundo atributo da Matriz)
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
