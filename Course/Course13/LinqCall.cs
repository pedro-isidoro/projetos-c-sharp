using System;
namespace Course13
{
	public class LinqCall
	{
		//Linq - Language Integrated Query
		// Consulta integrada a linguagem
		//É um conjunto de tecnologias baseadas na integração de
		//funcionalidades de consulta diretamente na lnguagem C#
		//Operações chamadas diretamente a partir das coleções
		//Consultas são objetos de primeira classe
		//Suporte do compilador e IntelliSense da IDE

		//Namespace: System.Linq

		//Possui diversas operações de consulta, cujos parâmetros
		//tipicamente são expressões lambda ou expressões de
		//sintaxe similar à SQL.

		public void Call()
		{
			//Specify the data source
			int[] numbers = new int[] { 2, 3, 4, 5 };

			//Define the query expression
			var result = numbers
				.Where(x => x % 2 == 0)
				.Select(x => x * 10);

			//Execute the query
			foreach(int x in result)
			{
				Console.WriteLine(x);
			}
		}
	}
}

