using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Graphic.Interface
{
    public interface IGraphic
    {
        public void Draw();
        public void Erase();
        public void Paint();
    }
}
