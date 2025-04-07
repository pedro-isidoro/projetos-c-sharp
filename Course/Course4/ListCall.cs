using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class ListCall
    {
        public void Call() {
            //Lista é uma estrutura de dados:
            //Homogênea;
            //Ordenada;
            //Iniciada vazia, e seus elementos são alocados sob demanda;
            //Cada elemento ocua um "nó" (ou nodo) da lista
            //O anterior sempre referencia o proximo, menos o último que não referencia ninguém.

            //Ele vem do Namespace: System.Collections.Generic

            //Vantagens:
            //Tamanha variável
            //Facilidade para se realizar inserções e deleções

            //Desvantagens:
            //Acesso sequencil aos elementos* (Porém dá para-se "burlar" essa desvantagem)

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); //Ele adiciona na posição informada, e empurra o valor que estava para baixo

            foreach (string obj in list) { 
                Console.WriteLine(obj);
            }

            //Mostrar o tamanho da Lista
            Console.WriteLine("-----------------------------2-------------------------------");
            Console.WriteLine($"List Count: {list.Count}");

            //Encontrar primeiro ou último elementos da lista que satisfaça um predicado
            //A função Find recebe como argumento uma função que faz um teste
            //Não é preciso passar uma função como teste, podemos passar um argumento Lambda
            //string s1 = list.Find(Test); - Retornará o primeiro elementto da Lista com A no começo
            Console.WriteLine("-----------------------------3-------------------------------");
            string s1 = list.Find(x => x[0] == 'A'); //Lambda - expressão anônima
            Console.WriteLine($"First 'A': { s1}");; //Lambda - expressão anônima
            string s2 = list.FindLast(x => x[0] == 'A'); //- Retornará o último elementto da Lista com A no começo
            Console.WriteLine($"Last 'A': { s2}");

            //Encontrar primeira ou últimoa posição de elemento da lista que satisfaça um predicado
            Console.WriteLine("-----------------------------4-------------------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First Position 'A': {pos1}");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last Position 'A': {pos2}");

            //filtrar a lista com base em um predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------5-------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos da lista
            list.Remove("Alex");
            Console.WriteLine("----------------------------6--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remove todos com o predicado passado
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------------7-------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remove pelo index passado
            list.RemoveAt(1);
            Console.WriteLine("-----------------------------8-------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            //Ele remove a partir da posição 2, 2 elementos 
            list.RemoveRange(2,2);
            Console.WriteLine("-----------------------------9-------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

        }
        //Função Teste
        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}
