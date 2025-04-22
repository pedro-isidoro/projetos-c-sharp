using System;
using System.Globalization;
using Course13.ProductEntities;

namespace Course13
{
	public class ProductCall
	{
		public void Call()
		{
			List<Product> list = new List<Product>();

			list.Add(new Product("TV", 900.00));
			list.Add(new Product("Notebook", 1200.00));
			list.Add(new Product("Tablet", 450.00));

			//usando lambda (funcao anonima)
			Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(comp);

			//list.Sort(CompareProducts);

			foreach (Product p in list){
				Console.WriteLine(p);
			}

			//Aqui usamos um delegate
			//Uma referencia para a funcao, com type safety
			//static int CompareProducts(Product p1, Product p2)
			//{
			//	return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
			//}
		}
	}
}

