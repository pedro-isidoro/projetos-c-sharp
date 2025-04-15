using System;

namespace Course10.DevicesEntities
{
    internal class Scanner : Device, IScanner
    {

        //Essa sobreescrita do ProcessDoc, é do Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        //E esta do IScanner
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
