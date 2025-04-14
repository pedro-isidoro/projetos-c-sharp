using System;
using System.IO;

namespace Course9
{
    internal class FileStreamAndStreamReader
    {
        public void Call()
        {
            //FileStream
            //Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita
            //Suporte a dados binários.

            //Instanciação
            //Vários construtores
            //File/FileInfo

            //StreamReader - Stream significa sequência de dados
            //É uma stream capaz de ler caracteres a partir de uma stream binária (ex: FileStream)
            //Suporte a dados no formato de texto.

            //Instanciação
            //Vários construtores
            //File/FileInfo

            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //É uma chamada externa
                //Isso é uma conversa com o sistema operacional
                //Esse recurso não é gerenciado pelo clr do .Net, por isso devemos fecha-lo manualmente
                //fs = new FileStream(path, StartMode);
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                
                //ou
                sr = File.OpenText(path); //Ele ja instancia o FeleStream e StreamReader

                //Como posso ler todas as linhas
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                //string line = sr.ReadLine();
                //Console.WriteLine(line);
            }
            catch (IOException e) {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Aqui fechamos manualmente.
                //if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
