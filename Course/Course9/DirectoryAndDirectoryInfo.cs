using System;
using System.IO;
using System.Collections.Generic;

namespace Course9
{
    internal class DirectoryAndDirectoryInfo
    {
        public void Call()
        {
            //Operações com pastas(create, enumerate, get files, etc.)

            //Directory
            //static members (simple, but performs security check for each operation)

            //DirectoryInfo
            //instance members

            string path = @"c:\temp\myFolder";

            try
            {
                //*****
                //Pegar subpastas a apartir da pasta original
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //caminho, padrao de busca (nesse caso, qualquer nome de arquivo e extensão), opcao de busca
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("----------------------------------------------------------------");
                //*****
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("----------------------------------------------------------------");
                //*****
                //Directory.CreateDirectory(path + "\\newfolder");
                //ou
                Directory.CreateDirectory(@"c:\temp\myFolder\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
