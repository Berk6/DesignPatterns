using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Computer1
{
    internal class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer;
        public Computer BuildComputer()
        {
            _computer = new Computer();
            BuildRam();
            BuildCPU();
            BuildHardDrive();
            BuildGraphicCard();
            BuildDisplay();
            return _computer;
        }

        public CPU BuildCPU()
        {
            CPU cpu = new CPU();
            _computer.SetCPU(cpu);
            return cpu;
        }

        public Display BuildDisplay()
        {
            Display display = new ();
            _computer.SetDisplay(display);
            return display;
        }

        public GraphicCard BuildGraphicCard()
        {
            GraphicCard card = new GraphicCard();
            _computer.SetGraphicCard(card);
            return card;
        }

        public HardDrive BuildHardDrive()
        {
            HardDrive drive = new HardDrive();
            _computer.SetHardDrive(drive);
            return drive;
        }

        public RAM BuildRam()
        {            
            RAM ram = new RAM();
            _computer.SetRam(ram);
            return ram;
        }
    }
}
