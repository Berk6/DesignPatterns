using DesignPatterns.Creational.Builder.Computer1;
using DesignPatterns.Creational.Builder.Computer6;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    internal class Process
    {
        public void ComputerProcess1()
        {
            IComputerBuilder builder = new ComputerBuilder();
            Models.Computer computer=builder.BuildComputer();
            computer.Start();

            RAM ram= builder.BuildRam();
            Display display= builder.BuildDisplay();
        }
        public void ComputerProcess4()
        {
            Computer4.IComputerBuilder builder = Computer4.Computer.GetBuilder("Asus");
            builder.BuildGraphicCard();
            builder.BuildHardDrive();
            builder.BuildCPU();
            builder.BuildRam();
            Computer4.Computer computer = builder.BuildComputer();
            computer.Start();
        }

        public void ComputerProcess6()
        {
            IBaseComputerBuilder baseBuilder = Computer6.Computer.GetBaseBuilder("Huawei");
            IComputerDisplayBuilder displayBuilder= baseBuilder.BuildRAM().BuildCPU().BuildHardDrive().GetDisplayBuilder();
            Computer6.Computer computer= displayBuilder.BuildGraphicCard().BuildGraphicCard().BuildComputerDisplay();
        }
    }
}
