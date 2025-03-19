using System;
namespace DesignPatterns.Creational.Builder.Models
{
    public class RAM
    {
		private BIOS _bios;

		public RAM()
		{
            _bios = new BIOS();
		}

		public void LoadOSKernelImage()
		{
			Console.WriteLine("RAM: Loading the image of OS kernel.");
            _bios.Start();
			Console.WriteLine("RAM: Image of OS kernel has been loaded.");
		}

		public void LoadOS()
		{
			Console.WriteLine("OS has been loaded.");
		}

		public void LoadDrivers()
		{
			Console.WriteLine("Drivers have been loaded.");
		}

		public void StartServices()
		{
			Console.WriteLine("Services have started.");
		}
	}
}
