using DesignPatterns.Structural.Adapter.JavaSwing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.JavaSwing
{
    internal class MouseAdapter : IMouseWheelListener,IMouseMoutionListener,IMouseListener
    {
        public virtual void MouseClicked()
        {
            throw new NotImplementedException();
        }

        public virtual void MouseDragged()
        {
            throw new NotImplementedException();
        }

        public virtual void MouseEntered()
        {
            throw new NotImplementedException();
        }

        public virtual void MouseExited()
        {
            throw new NotImplementedException();
        }

        public virtual void MouseMoved()
        {
            throw new NotImplementedException();
        }

        public virtual void MousePressed()
        {
            throw new NotImplementedException();
        }

        public virtual void MouseReleased()
        {
            throw new NotImplementedException();
        }

        public virtual void MouseWheelMoved()
        {
            throw new NotImplementedException();
        }
    }
}
