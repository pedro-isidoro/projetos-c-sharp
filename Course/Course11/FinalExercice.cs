using System;
using Course11.ConjuntosExercciceEntities;

namespace Course11
{
	public class FinalExercice
	{
		public void Call()
		{
            Dictionary<string, int> candidate = new Dictionary<string, int>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (candidate.ContainsKey(name))
                        {
                            candidate[name] += votes;
                        }
                        else {
                            candidate[name] = votes;
                        }
                    }
                }
                foreach(KeyValuePair<string, int> c in candidate)
                {
                    Console.WriteLine($"{c.Key}: {c.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

