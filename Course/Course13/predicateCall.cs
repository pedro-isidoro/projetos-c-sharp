using System;
using System.Collections.Generic;
using Course13.PredicateEntities;

namespace Course13
{
	public class predicateCall
	{
		public void Call()
		{
			//Representa um método que recebe um objeto do tipo T e
			//retorna um valor booleano
			List<Product> list = new List<Product>();

			list.Add(new Product("TV", 900.00));
			list.Add(new Product("Mouse", 50.00));
			list.Add(new Product("Tablet", 350.50));
			list.Add(new Product("HD Case", 80.90));

			//list.RemoveAll(p => p.Price >= 100.0);
			list.RemoveAll(ProductTest);
			foreach (Product p in list)
			{
				Console.WriteLine(p);
			}


		}
		//Pega o Objeto e devolve um boolean
		public static bool ProductTest(Product p)
		{
			return p.Price >= 100.0;
		}
	}
}

