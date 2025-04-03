
using DesignPatterns.Structural.Composite.Graphic.Abstract;

namespace DesignPatterns.Structural.Composite.Graphic
{
    internal class Ellipse: GraphicObject
    {
        public Ellipse(string name, string color) : base(name, color) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing an ellipse: " + Name);
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing an ellipse: " + Name);
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting an ellipse: {Name} and its color is {Color}");
        }
    }
}
