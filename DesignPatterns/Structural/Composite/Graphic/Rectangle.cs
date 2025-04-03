using DesignPatterns.Structural.Composite.Graphic.Abstract;

namespace DesignPatterns.Structural.Composite.Graphic
{
    internal class Rectangle : GraphicObject
    {
        public Rectangle(string name, string color) : base(name, color)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing an rectangle: " + Name);
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing an rectangle: " + Name);
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting an rectangle: {Name} and its color is {Color}");
        }
    }
}
