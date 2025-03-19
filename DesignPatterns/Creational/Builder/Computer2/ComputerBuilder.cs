using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Computer2
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

        private CPU BuildCPU()
        {
            CPU cpu = new CPU();
            _computer.SetCPU(cpu);
            return cpu;
        }

        private Display BuildDisplay()
        {
            Display display = new ();
            _computer.SetDisplay(display);
            return display;
        }

        private GraphicCard BuildGraphicCard()
        {
            GraphicCard card = new GraphicCard();
            _computer.SetGraphicCard(card);
            return card;
        }

        private HardDrive BuildHardDrive()
        {
            HardDrive drive = new HardDrive();
            _computer.SetHardDrive(drive);
            return drive;
        }

        private RAM BuildRam()
        {            
            RAM ram = new RAM();
            _computer.SetRam(ram);
            return ram;
        }
    }
}
