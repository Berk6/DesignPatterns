using DesignPatterns.Creational.AbstractFactory.Solution3.Components.Buttons;
using DesignPatterns.Creational.AbstractFactory.Solution3.Components;
using DesignPatterns.Creational.AbstractFactory.Solution3.Components.Lists;
using DesignPatterns.Creational.AbstractFactory.Solution3.Components.Tables;

namespace DesignPatterns.Creational.AbstractFactory.Solution3
{
    public class WinGUIFactory : IGUIFactory
    {

        public IComponent CreateButton()
        {
            return new WinButton();
        }

        public IComponent CreateList()
        {
            return new WinList();
        }

        public IComponent CreateTable()
        {
            return new WinTable();
        }
    }
}
