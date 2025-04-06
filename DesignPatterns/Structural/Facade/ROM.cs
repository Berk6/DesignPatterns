using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class ROM
    {
        private int _size;  // Size of ROM in MB

        public ROM(int size)
        {
            this._size = size;
        }

        public byte[] getOSKernelImage()
        {
            Console.WriteLine("ROM: Loading the image of OS kernel.");
            byte[] kernelImage = new byte[2 * 1024 * 1024];
            return kernelImage;
        }
    }
}
