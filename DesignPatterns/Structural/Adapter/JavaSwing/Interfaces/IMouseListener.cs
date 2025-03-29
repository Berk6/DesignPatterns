using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.JavaSwing.Interfaces
{
    internal interface IMouseListener:IEventListener
    {
        void MouseClicked();
        void MousePressed();
        void MouseReleased();
        void MouseEntered();
        void MouseExited();

    }
}
