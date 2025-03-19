
namespace DesignPatterns.Creational.Builder.Computer6
{
    public interface IBaseComputerBuilder
    {
        public IBaseComputerBuilder BuildRAM();
        public IBaseComputerBuilder BuildCPU();
        public IBaseComputerBuilder BuildHardDrive();
        public IComputerDisplayBuilder GetDisplayBuilder();
        public IAccessoryBuilder GetAccessoryBuilder();
        public Computer Build();
    }
}
