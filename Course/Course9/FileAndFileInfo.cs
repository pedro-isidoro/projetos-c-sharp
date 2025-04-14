
using System;
using System.IO;

namespace Course9
{
    internal class FileAndFileInfo
    {
        public void Call()
        {
            //Colocamos @ para não usar \\, assim usando so uma
            string sourcePath = @"C:\temp\teste.txt";
            string targetPath = @"C:\temp\teste2.txt";
            string targetPath2 = @"C:\temp\teste3.txt";

            try
            {
                //Aqui clonamos o arquivo fonte, no caso teste.txt
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                //Console.WriteLine("Arquivo copiado com sucesso!");

                //File.Copy(sourcePath, targetPath2, true);
                //Console.WriteLine("Arquivo copiado com sucesso2!");

                //Aqui lemos o arquivo fonte
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}