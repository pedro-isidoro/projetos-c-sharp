using System;
using System.IO;

namespace Course9
{
    internal class UsingBlock
    {
        public void Call()
        {
            //Sintaxe simplificada que garante que os objetos IDisposable serão fechados
            //Objetos IDisposable Não são gerenciados pelo CLR. Eles precisam se manualmente fechados
            //Ex: Font, FileStream, StreamReader, StreamWriter

            string path = @"c:\temp\file1.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
