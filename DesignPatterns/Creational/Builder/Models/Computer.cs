using System;
namespace DesignPatterns.Creational.Builder.Models
{
    public class Computer
    {
		public string Name { set; get; }
		public CPU Cpu { set; get; }
		public RAM Ram { set; get; }
		public HardDrive Hd { set; get; }
		public GraphicCard GraphicCard { set; get; }
		public Display Display { set; get; }
	    public Keyboard Keyboard { set; get; }
		public Mouse Mouse { set; get; }

		public Computer() { }

		public Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard)
		{
			this.Name = name;
			this.Cpu = cpu;
			this.Ram = ram;
			this.Hd= hd;
			this.GraphicCard = graphicCard;
		}

		public Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard, Display display)
		{
			this.Name = name;
			this.Cpu = cpu;
			this.Ram = ram;
			this.Hd= hd;
			this.GraphicCard = graphicCard;
			this.Display = display;
		}

		public Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard,
				Display display, Keyboard keyboard)
		{
			this.Name = name;
			this.Cpu = cpu;
			this.Ram = ram;
			this.Hd= hd;
			this.GraphicCard = graphicCard;
			this.Display = display;
			this.Keyboard = keyboard;
		}

        public Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard,
				Display display, Keyboard keyboard, Mouse mouse)
		{
			this.Name = name;
			this.Cpu = cpu;
			this.Ram = ram;
			this.Hd= hd;
			this.GraphicCard = graphicCard;
			this.Display = display;
			this.Keyboard = keyboard;
			this.Mouse = mouse;
		}
		public void SetDisplay(Display display)=> this.Display = display;
		public void SetRam(RAM ram)=> this.Ram = ram;
		public void SetCPU(CPU cpu)=> this.Cpu = cpu;
		public void SetHardDrive(HardDrive hardDrive)=> this.Hd = hardDrive;
		public void SetGraphicCard(GraphicCard graphicCard)=> this.GraphicCard = graphicCard;
		public void SetKeyboard(Keyboard keyboard)=> this.Keyboard = keyboard;
		public void SetMouse(Mouse mouse)=> this.Mouse = mouse;
		public void SetName(string name)=> this.Name = name;
		public void Start()
		{
			Cpu.Start();
			Ram.LoadOSKernelImage();
			Ram.LoadOS();
			Ram.LoadDrivers();
			Ram.StartServices();
			Hd.Start();
			GraphicCard.Start();
			if (Display != null)
				Display.Start();
			if (Keyboard != null)
				Keyboard.Start();
			if (Mouse != null)
				Mouse.Start();
			Console.WriteLine("Computer " + Name + " has started.\n");
		}
	}
}
