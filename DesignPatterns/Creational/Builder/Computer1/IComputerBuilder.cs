using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Computer1
{
    internal interface IComputerBuilder
    {
        public RAM BuildRam();
        public CPU BuildCPU();
        public HardDrive BuildHardDrive();
        public GraphicCard BuildGraphicCard();
        public Display BuildDisplay();
        public Computer BuildComputer();
    }
}
