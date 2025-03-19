using DesignPatterns.Creational.Builder.Models;
namespace DesignPatterns.Creational.Builder.Computer6
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
            this.Hd = hd;
            this.GraphicCard = graphicCard;
        }

        private Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard, Display display)
        {
            this.Name = name;
            this.Cpu = cpu;
            this.Ram = ram;
            this.Hd = hd;
            this.GraphicCard = graphicCard;
            this.Display = display;
        }

        private Computer(string name, CPU cpu, RAM ram, HardDrive hd, GraphicCard graphicCard,
                Display display, Keyboard keyboard)
        {
            this.Name = name;
            this.Cpu = cpu;
            this.Ram = ram;
            this.Hd = hd;
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
            this.Hd = hd;
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

        public static IBaseComputerBuilder GetBaseBuilder(string name)
        {
            return new BaseComputerBuilder(name);
        }
        private static IComputerDisplayBuilder GetPrivateDisplayBuilder(Computer computer)
        {
            return new ComputerDisplayBuilder(computer);
        }
        private static IAccessoryBuilder GetPrivateAccessoryBuilder(Computer computer)
        {
            return new AccessoryBuilder(computer);
        }
        private class BaseComputerBuilder : IBaseComputerBuilder
        {
            private string _name;
            private bool _hasRam;
            private bool _hasHd;
            private bool _hasCPU;
            private Computer _computer;
            public BaseComputerBuilder(string name) => this._name = name;


            public Computer Build()
            {
                _computer ??= new Computer
                    {
                        Name = this._name
                    };
                if (_hasCPU)
                    _computer.Cpu = new CPU();
                if (_hasHd)
                    _computer.Hd = new HardDrive();
                if (_hasRam)
                    _computer.Ram = new RAM();
                return _computer;
            }

            public IComputerDisplayBuilder GetDisplayBuilder()
            {
                _computer ??= Build();
                return GetPrivateDisplayBuilder(_computer);
            }
            public IAccessoryBuilder GetAccessoryBuilder()
            {
                _computer ??= Build();
                return GetPrivateAccessoryBuilder(_computer);
            }

            IBaseComputerBuilder IBaseComputerBuilder.BuildCPU()
            {
                this._hasCPU = true;
                return this;
            }

            IBaseComputerBuilder IBaseComputerBuilder.BuildHardDrive()
            {
                this._hasCPU = true;
                return this;
            }

            IBaseComputerBuilder IBaseComputerBuilder.BuildRAM()
            {
                this._hasCPU = true;
                return this;
            }
        }
        private class ComputerDisplayBuilder : IComputerDisplayBuilder
        {
            private bool _hasDisplay;
            private bool _hasGraphicCard;
            private Computer _computer;
            public ComputerDisplayBuilder(Computer computer)
            {
                this._computer = computer;
            }
            public Computer BuildComputerDisplay()
            {
                if (_hasGraphicCard)
                    _computer.GraphicCard = new GraphicCard();
                if (_hasDisplay)
                    _computer.Display = new Display();
                return _computer;
            }

            IComputerDisplayBuilder IComputerDisplayBuilder.BuildDisplay()
            {
                _hasDisplay = true;
                return this;
            }

            IComputerDisplayBuilder IComputerDisplayBuilder.BuildGraphicCard()
            {
                _hasGraphicCard = true;
                return this;
            }
        }
        private class AccessoryBuilder : IAccessoryBuilder
        {
            private Computer _computer;
            private bool _hasMouse;
            private bool _hasKeyboard;

            public AccessoryBuilder(Computer computer)
            {
                _computer = computer;
            }

            public Computer BuildAccessories()
            {
                if(_hasKeyboard)
                        _computer.Keyboard = new Keyboard();
                if (_hasMouse)
                    _computer.Mouse = new Mouse();
                return _computer;
            }

            IAccessoryBuilder IAccessoryBuilder.BuildKeyboard()
            {
                this._hasKeyboard = true;
                return this;
            }

            IAccessoryBuilder IAccessoryBuilder.BuildMouse()
            {
                this._hasMouse = true;
                return this;                
            }
        }
    }
}
