using DesignPatterns.Creational.AbstractFactory.Solution1;
using System;
namespace DesignPatterns.Creational.AbstractFactory.Components
{
    public class Client
    {
        public Client(IGUIFactory factory)
        {
            IComponent button = factory.Create();
            button.Paint();

            IComponent list = factory.Create();
            list.Paint();

            IComponent table = factory.Create();
            table.Paint();
        }
    }
}
