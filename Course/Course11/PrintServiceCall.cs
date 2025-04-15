using System;
namespace Course11
{
	public class PrintServiceCall
	{
		public void Call()
		{
			PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
			int n = int.Parse(Console.ReadLine());

            //Com o Type safe, caso deixe como "PrintService<string>"
			//dara erro caso passe int
            for (int i = 1; i <= n; i++)
			{
				Console.Write($"{i}º: ");
				int x = int.Parse(Console.ReadLine());
				printService.AddValue(x);
            }
			printService.Print();
			Console.WriteLine();
			Console.WriteLine("First: " + printService.First());

        }
	}
}

