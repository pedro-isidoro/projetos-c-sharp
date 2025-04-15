using System;
using Course10.InterfaceInActionEnums;

namespace Course10.InterfaceInActionEntities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        //Como é um método abstrato, quem herdar é obrigado a sobreescrever este método.
        public abstract double Area();
    }
}
