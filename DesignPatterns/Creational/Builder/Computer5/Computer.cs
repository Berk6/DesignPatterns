using DesignPatterns.Creational.Builder.Models;
namespace DesignPatterns.Creational.Builder.Computer5
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
			private bool _hasRam;
			private bool _hasCpu;
			private bool _hasHd;
			private bool _hasGraphicCard;
			private bool _hasDisplay;
			private bool _hasKeyboard;
			private bool _hasMouse;

            public ComputerBuilder(string name) => this._name = name;

            public Computer BuildComputer()
            {
                Computer computer= new ();			
				if(_hasCpu)
					computer.Cpu = new CPU();
				if(_hasHd)
					computer.Hd = new HardDrive();
				if( _hasGraphicCard)
					computer.GraphicCard =	new GraphicCard();
				if(_hasDisplay)
					computer.Display = new Display();
				if(_hasKeyboard)
					computer.Keyboard = new Keyboard();
				if(_hasMouse)
					computer.Mouse = new Mouse();
				if(_hasRam)
					computer.Ram = new RAM();
				return computer;

            }

            public IComputerBuilder BuildCPU()
            {
                this._hasCpu =true;
				return this;
            }

            public IComputerBuilder BuildDisplay()
            {
                this._hasDisplay = true;
                return this;
            }

            public IComputerBuilder BuildGraphicCard()
            {
                this._hasGraphicCard = true;
                return this;
            }

            public IComputerBuilder BuildHardDrive()
            {
                this._hasHd = true;
                return this;
            }

            public IComputerBuilder BuildRam()
            {
                this._hasRam = true;
                return this;
            }
        }

    }
}
