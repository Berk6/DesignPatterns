using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Facade
{
    public class Computer
    {
        private CPU _cpu;
        private RAM _ram;
        private HardDrive _hd;
        private Display _display;

        public Computer()
        {
            _cpu = new CPU();
            _ram = new RAM();
            _hd = new HardDrive();
            _display = new Display();
        }

        public void Start()
        {
            _cpu.Start();
            _hd.Start();
            bool kernelLoaded = _ram.LoadOSKernelImage();
            while (!kernelLoaded)
            {
                _ram.FixIt();
                kernelLoaded = _ram.LoadOSKernelImage();
            }

            bool osLoaded = _ram.LoadOS();
            while (!osLoaded)
            {
                _ram.FixIt();
                osLoaded = _ram.LoadOS();
            }

            _ram.LoadDrivers();
            _ram.StartServices();
            _display.Start();
            Console.WriteLine("Computer has started.");
        }
    }
}
