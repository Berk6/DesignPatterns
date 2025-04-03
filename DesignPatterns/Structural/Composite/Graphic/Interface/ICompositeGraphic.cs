using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Graphic.Interface
{
    public interface ICompositeGraphic
    {
        public void AddGraphic(IGraphic graphic);
        public void RemoveGraphic(IGraphic graphic);
        public List<IGraphic> GetGraphics();
        public void ListGraphic();
    }
}
