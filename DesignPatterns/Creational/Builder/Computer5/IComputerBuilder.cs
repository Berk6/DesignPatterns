using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Computer5
{
    public interface IComputerBuilder
    {
        public IComputerBuilder BuildRam();
        public IComputerBuilder BuildCPU();
        public IComputerBuilder BuildHardDrive();
        public IComputerBuilder BuildGraphicCard();
        public IComputerBuilder BuildDisplay();
        public Computer BuildComputer();
    }
}
