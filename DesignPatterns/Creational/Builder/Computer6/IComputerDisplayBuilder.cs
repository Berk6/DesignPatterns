using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Computer6
{
    public interface IComputerDisplayBuilder
    {
        public IComputerDisplayBuilder BuildGraphicCard();
        public IComputerDisplayBuilder BuildDisplay();
        public Computer BuildComputerDisplay();
    }
}
