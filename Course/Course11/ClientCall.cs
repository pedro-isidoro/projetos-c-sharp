using System;
using Course11.ClientEntities;
namespace Course11
{
	public class ClientCall
	{
		public void Call()
		{

			//Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
			//Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
			//Console.WriteLine(a.Equals(b));
			//return false
			//Console.WriteLine(a.GetHashCode());
			//Console.WriteLine(b.GetHashCode());


			Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
			Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };
			Console.WriteLine(a.Equals(b));
			//return true
			Console.WriteLine(a.GetHashCode());
			Console.WriteLine(b.GetHashCode());
		}
	}
}

