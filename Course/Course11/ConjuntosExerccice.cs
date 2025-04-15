using System;
using System.Collections.Generic;
using Course11.ConjuntosExercciceEntities;
namespace Course11
{
	public class ConjuntosExerccice
	{
		public void Void()
		{
			//Como a ordem nao importa, uso o HashSet
			HashSet<LogRecord> set = new HashSet<LogRecord>();

			Console.Write("Enter file full path: ");
			string path = Console.ReadLine();

			try
			{
				using(StreamReader sr = File.OpenText(path))
				{
					while (!sr.EndOfStream)
					{
						string[] line = sr.ReadLine().Split(' ');
						string name = line[0];
						DateTime instant = DateTime.Parse(line[1]);
						set.Add(new LogRecord
						{
							UserName = name,
							Instant = instant
						});
						Console.WriteLine(line);
					}
					Console.WriteLine($"Total user: {set.Count}");
				}
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}

