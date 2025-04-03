using DesignPatterns.Structural.Composite.Graphic.Abstract;
using DesignPatterns.Structural.Composite.Graphic.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Graphic
{
    public class Canvas : GraphicObject, ICompositeGraphic
    {
        protected List<IGraphic> Elements;

        public Canvas(string name, string color) : base(name, color)
        {
            Elements = new List<IGraphic>();
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing canvas: {Name}");
            foreach (var graphic in Elements)
            {
                graphic.Draw();
            }
        }

        public override void Erase()
        {
            Console.WriteLine($"Erasing canvas: {Name}");
            foreach (var graphic in Elements)
            {
                graphic.Erase();
            }
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting canvas: {Name} and its color is {Color}");
            foreach (var graphic in Elements)
            {
                graphic.Paint();
            }
        }

        public void AddGraphic(IGraphic graphic)
        {
            Elements.Add(graphic);
        }

        public void RemoveGraphic(IGraphic graphic)
        {
            Elements.Remove(graphic);
        }

        public List<IGraphic> GetGraphics()
        {
            return Elements;
        }

        public void ListGraphic()
        {
            Console.WriteLine("\nGraphic objects:");
            foreach (var graphic in Elements)
            {
                Console.WriteLine(graphic);
            }
        }

    }

}
