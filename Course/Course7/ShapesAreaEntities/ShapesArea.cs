using System;
using Course7.ShapesAreaEntities;
using Course7.ShapesAreaEntities.Enums;

namespace Course7.ShapesAreaEntities
{
    internal abstract class ShapesArea
    {
        public Color Color { get; set; }


        public ShapesArea()
        {
        }
        public ShapesArea(Color color)
        {
            Color = color;
        }

        //Aqui assimilamos como abstrata
        public abstract double Area();
    }
}
