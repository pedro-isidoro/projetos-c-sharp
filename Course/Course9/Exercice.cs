using System;
using System.Globalization;
using System.IO;

namespace Course9
{
    internal class Exercice
    {
        public void Call()
        {
            string sourceFile = @"c:\temp\myFolder\exercice.txt";
            string targetFolder = @"c:\temp\myFolder\out";
            string targetFile = Path.Combine(targetFolder, "summary.txt");

            try
            {
                Directory.CreateDirectory(targetFolder);

                string[] lines = File.ReadAllLines(sourceFile);

                using (StreamWriter writer = new StreamWriter(targetFile)) {
                    foreach (string line in lines)
                    {
                        string[] partes = line.Split(',');
                        string name = partes[0];
                        double price = double.Parse(partes[1], CultureInfo.InvariantCulture);
                        int qtt = int.Parse(partes[2]);

                        double total = qtt * price;

                        writer.WriteLine($"{name}, {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
                Console.WriteLine("Arquivo de resumo criado com sucesso!");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
