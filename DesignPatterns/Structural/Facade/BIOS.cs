using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class BIOS
    {
        private ROM _rom;
        public BIOS()
        {
            _rom = new ROM(2 * 1024);
        }

        public void Start()
        {
            Console.WriteLine("BIOS: Getting the image of OS kernel.");
            _rom.getOSKernelImage();
        }
    }
}
