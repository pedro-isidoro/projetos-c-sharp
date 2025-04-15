using System;

namespace Course10.DevicesEntities
{
    internal class Printer : Device, IPrinter
    {
        //Essa sobreescrita do ProcessDoc, é do Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        //E esta do IPrinter
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
