using DesignPatterns.Creational.AbstractFactory.Solution3.Components.Buttons;
using DesignPatterns.Creational.AbstractFactory.Solution3.Components;
using DesignPatterns.Creational.AbstractFactory.Solution3.Components.Lists;
using DesignPatterns.Creational.AbstractFactory.Solution3.Components.Tables;

namespace DesignPatterns.Creational.AbstractFactory.Solution3
{
    public class OSXGUIFactory : IGUIFactory
    {
        public IComponent CreateButton()
        {
            return new OSXButton();
        }

        public IComponent CreateList()
        {
            return new OSXList();
        }

        public IComponent CreateTable()
        {
            return new OSXTable();
        }
    }
}
