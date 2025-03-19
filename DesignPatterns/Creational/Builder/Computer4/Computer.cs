using DesignPatterns.Creational.Builder.Models;
namespace DesignPatterns.Creational.Builder.Computer4
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

		private Computer() { }

        private Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard)
		{
			this.Name = name;
			this.Cpu = cpu;
			this.Ram = ram;
			this.Hd= hd;
			this.GraphicCard = graphicCard;
		}

        private Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard, Display display)
		{
			this.Name = name;
			this.Cpu = cpu;
			this.Ram = ram;
			this.Hd= hd;
			this.GraphicCard = graphicCard;
			this.Display = display;
		}

        private Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard,
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

        private Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard,
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

		public static IComputerBuilder GetBuilder(string name)
		{
			return new ComputerBuilder(name);
		}
        public  class ComputerBuilder : IComputerBuilder
        {
			private string _name;
			private CPU _cpu;
			private RAM _ram;
			private HardDrive _hd;
            private GraphicCard _graphicCard;
            private Display _display;
			private Keyboard _keyboard;
			private Mouse _mouse;

           public ComputerBuilder(string name)
            {
                this._name = name;
            }

            public Computer BuildComputer()
            {
                 return new Computer(this._name,this._cpu,this._ram,this._hd,this._graphicCard,this._display,this._keyboard,this._mouse);				
            }

            public IComputerBuilder BuildCPU()
            {
                this._cpu = new();
				return this;
            }

            public IComputerBuilder BuildDisplay()
            {
                this._display = new();
                return this;
            }

            public IComputerBuilder BuildGraphicCard()
            {
                this._graphicCard = new();
                return this;
            }

            public IComputerBuilder BuildHardDrive()
            {
                this._hd = new();
                return this;
            }

            public IComputerBuilder BuildRam()
            {
                this._ram = new();
                return this;
            }
        }

    }
}
