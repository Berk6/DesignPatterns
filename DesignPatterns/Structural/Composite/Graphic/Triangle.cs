using DesignPatterns.Structural.Composite.Graphic.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Structural.Composite.Graphic
{
    internal class Triangle:GraphicObject
    {
        public Triangle(string name, string color) : base(name, color)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing an triangle: " + Name);
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing an triangle: " + Name);
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting an triangle: {Name} and its color is {Color}");
        }
    }
}
