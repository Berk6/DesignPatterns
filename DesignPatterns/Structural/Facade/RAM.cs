using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Facade
{
    public class RAM
    {
        private BIOS _bios;
        private bool _kernelLoaded = false;
        private bool _osLoaded = false;

        public RAM()
        {
            _bios = new BIOS();
            double random = new Random().NextDouble();
            if (random < 0.8)
            {
                _kernelLoaded = true;
                _osLoaded = true;
            }
        }

        public bool LoadOSKernelImage()
        {
            Console.WriteLine("RAM: Loading the image of OS kernel.");
            if (_kernelLoaded)
            {
                _bios.Start();
                Console.WriteLine("RAM: Image of OS kernel has been loaded.");
            }
            else
                Console.WriteLine("RAM: Image of OS kernel has been loaded.");
            return _kernelLoaded;
        }

        public bool LoadOS()
        {
            if (_osLoaded)
                Console.WriteLine("OS has been loaded successfully.");

        else
                Console.WriteLine("OS loading has been failed.");
            return _osLoaded;
        }

        public void LoadDrivers()
        {
            Console.WriteLine("Drivers have been loaded.");
        }

        public void StartServices()
        {
            Console.WriteLine("Services have started.");
        }

        public void FixIt()
        {
            Console.WriteLine("Fixing kernel and OS!");
            _kernelLoaded = true;
            _osLoaded = true;
        }
    }
}
