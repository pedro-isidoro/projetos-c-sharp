//using Course12.Extensions;
//ou - pelo proprio system, pois setei o namespace como System
using System;
namespace Course12
{
	public class DateTimeExtensionsCall
	{
		public void Call()
		{
			DateTime dt = new DateTime(2025, 04, 16, 8, 10, 45);
			Console.WriteLine(dt.ElapsedTime());
		}
	}
}

