using System;
using System.Globalization;
using Course10.InterfaceInActionEntities;
using Course10.InterfaceInActionEnums;

namespace Course10
{
    internal class InterfaceInAction
    {
        public void Call()
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
            IShape s2 = new Retangle() { Width = 3.5, Height = 4.2, Color = Color.Yellow };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
