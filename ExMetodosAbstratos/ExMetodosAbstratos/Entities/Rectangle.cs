using ExMetodosAbstratos.Entities.Enums;

namespace ExMetodosAbstratos.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double widht, double height, Color color) : base(color)
        {
            Width = widht;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
