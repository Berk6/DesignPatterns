using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.JavaSwing
{
    internal class CustomMouseListener:MouseAdapter
    {
        public override void MouseExited()
        {
            base.MouseExited();
        }
        public override void MouseDragged()
        {
            base.MouseDragged();
        }

        public override void MouseWheelMoved()
        {
            base.MouseWheelMoved();
        }
    }
}
