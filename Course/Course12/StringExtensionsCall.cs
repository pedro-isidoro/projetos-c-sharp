using System;
using Course12.Extensions;
namespace Course12
{
	public class StringExtensionsCall
	{
		public void Call()
		{
			string s1 = "Good morning dear students!";

			Console.WriteLine(s1.Cut(10));
		}
	}
}

