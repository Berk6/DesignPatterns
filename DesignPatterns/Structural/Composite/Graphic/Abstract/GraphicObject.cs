using DesignPatterns.Structural.Composite.Graphic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Graphic.Abstract
{
    public abstract class GraphicObject: IGraphic
    {
        protected string Name;
        protected string Color;

        public GraphicObject(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Draw();
        public abstract void Erase();
        public abstract void Paint();

        public string GetName()
        {
            return Name;
        }


        public void SetName(string name)
        {
            Name = name;
        }

        public string ToString()
        {
            return "Graphic Object: " + Name + " Color: " + Color;
        }
    }
}
