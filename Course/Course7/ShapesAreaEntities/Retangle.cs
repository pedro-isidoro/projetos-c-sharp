using Course7.ShapesAreaEntities.Enums;

namespace Course7.ShapesAreaEntities
{
    //Ou assimilamos como abstrato
    //ou
    //Implementamos o metodo abstrato
    internal class Retangle : ShapesArea
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Retangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        

        public override double Area()
        {
            //Isso seria uma exceção
            //throw new System.NotImplementedException();
            return Width * Height;
        }
    }
}
