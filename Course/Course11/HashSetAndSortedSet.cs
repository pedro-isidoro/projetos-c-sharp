using System;
using System.Collections.Generic;
namespace Course11
{
	public class HashSetAndSortedSet
	{
		public void Call()
		{
            //Representa um conjunto de elementos (similar ao da Álgebra)
            //Não admite reptições
            //Elementos não possuem posição
            //Acesso, inserção e remoção de elementos são rápidos
            //Oferece operações eficientes de conjunto:
            //inserção, união, diferença.

            //HashSet
            //Armazenamento em tabela hash
            //Extremamente rápido: inserção, remoção e busca O(1)
            //A ordem dos elementos não é garantida

            //SortedSet
            //Armazenamento em árvore
            //Rápido: inserção, remoção e busca O(log(n))
            //Os elementos são armazenados ordenadamente conforme
            //implementação IComparer<T>

            //Alguns métodos importantes

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            set.Add("Cellphone");

            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("Computer"));

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine();
            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);
            PrintCollection(b);
            
            Console.WriteLine();
            Console.WriteLine("Union: ");
            //Union
            //Estou instancindo o conjunto c com os elementos do conjunto a
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            Console.WriteLine();
            Console.WriteLine("Intersection: ");
            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            Console.WriteLine();
            Console.WriteLine("Difference: ");
            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection){
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
