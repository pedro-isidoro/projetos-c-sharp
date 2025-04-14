using System;
using System.IO;

namespace Course9
{
    internal class StreamWriterCall
    {
        public void Call()
        {
            //É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream)
            //Suporte a dados no formato de texto

            //Instantiation
            //Several constructors
            //File/FileInfo (
            //CreateText(path)
            //AppendText(string)
            //)

            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt"; //Que sera criado

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
