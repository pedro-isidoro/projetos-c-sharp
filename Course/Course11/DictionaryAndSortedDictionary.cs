using System;
namespace Course11
{
	public class DictionaryAndSortedDictionary
	{
		public void Call()
		{
			//Dictionary<TKey, TValue>
			//É uma coleção de pares chave/valor
			//Não admite repetições do objeto chave
			//Os elementos são indexados pelo objeto chave (não possuem posição)
			//Acesso, inserção e remoção de elemnentos são rápidos

			//Uso comum: cookies, local storage, qualquer modelo chave-valor

			Dictionary<string, string> cookies = new Dictionary<string, string>();

			cookies["user"] = "maria";
			cookies["email"] = "maria@gmail.com";
			cookies["phone"] = "99712234";
			cookies["phone"] = "99799994";
			//Como nao admite repeticoes, ira sobreescrever
			Console.WriteLine(cookies["user"]);
			Console.WriteLine(cookies["email"]);
			Console.WriteLine(cookies["phone"]);
			cookies.Remove("email");
			if (cookies.ContainsKey("email"))
			{
				Console.WriteLine(cookies["email"]);
			}else
			{
				Console.WriteLine("There is no 'email' key.");
			}

			Console.WriteLine($"Size: {cookies.Count}");

			Console.WriteLine("All Cookies:");
			//foreach(var item in cookies)
			foreach(KeyValuePair<string, string> item in cookies)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}
	}
}

