using System;
using Course7.ShapesAreaEntities.Enums;

namespace Course7.ShapesAreaEntities
{
    internal class Circle : ShapesArea
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

}
