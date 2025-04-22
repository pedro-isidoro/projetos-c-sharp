using System;
using System.Linq;
using System.Collections.Generic;
using Course13.FuncEntities;

namespace Course13
{
	public class FuncCall
	{
		//Representa um método que recebe zero ou
		//mais argumentos, e retorna um valor
		//public delegate TResult Func<out TResult>();
		//public delegate TResult Func<in T, out TResult>(T obj);
		//public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
		//16 sobrecargas

		public void Call()
		{
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

			//Nessa nova lisata, so tera o nome em caixa alta
			//List<string> result = list.Select(NameUpper).ToList();
			//ou
			Func<Product, string> func = NameUpper;
			List<string> result = list.Select(func).ToList();

			foreach(string s in result)
			{
				Console.WriteLine(s);
			}

        }

		static string NameUpper(Product p)
		{
			return p.Name.ToUpper();
		}
    }
}

