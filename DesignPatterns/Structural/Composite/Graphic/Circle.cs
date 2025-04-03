using DesignPatterns.Structural.Composite.Graphic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Graphic
{
    internal class Circle : GraphicObject
    {
        public Circle(string name, string color) : base(name, color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing circle: {Name}");
        }

        public override void Erase()
        {
            Console.WriteLine($"Erasing circle: {Name}");
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting circle: {Name} and its color is {Color}");
        }
    }
}
