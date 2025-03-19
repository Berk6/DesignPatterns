using DesignPatterns.Creational.Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Computer3
{
    internal class ComputerBuilder : IComputerBuilder
    {
        private static ComputerBuilder _builder = new ();        
        private Computer _computer;
         ComputerBuilder()
        {
            _computer = new();        
        }
        public static ComputerBuilder GetBuilder()=> _builder;
        public Computer BuildComputer()
        {
            return _computer;
        }

        public IComputerBuilder BuildCPU()
        {
            CPU cpu = new ();
            _computer.SetCPU(cpu);
            return _builder ;
        }

        public IComputerBuilder BuildDisplay()
        {
            Display display = new ();
            _computer.SetDisplay(display);
            return _builder;
        }

        public IComputerBuilder BuildGraphicCard()
        {
            GraphicCard card = new GraphicCard();
            _computer.SetGraphicCard(card);
            return _builder;
        }

        public IComputerBuilder BuildHardDrive()
        {
            HardDrive drive = new HardDrive();
            _computer.SetHardDrive(drive);
            return _builder;
        }

        public IComputerBuilder BuildRam()
        {            
            RAM ram = new RAM();
            _computer.SetRam(ram);
            return _builder;
        }
    }
}
