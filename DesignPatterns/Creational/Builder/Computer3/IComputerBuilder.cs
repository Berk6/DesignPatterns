using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Computer3
{
    internal interface IComputerBuilder
    {
        public IComputerBuilder BuildRam();
        public IComputerBuilder BuildCPU();
        public IComputerBuilder BuildHardDrive();
        public IComputerBuilder BuildGraphicCard();
        public IComputerBuilder BuildDisplay();
        public Computer BuildComputer();
    }
}
