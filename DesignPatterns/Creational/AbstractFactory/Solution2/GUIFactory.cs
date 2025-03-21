using DesignPatterns.Creational.AbstractFactory.Components;

namespace DesignPatterns.Creational.AbstractFactory.Solution2
{
    public class GUIFactory : IGUIFactory
    {

        public IComponent CreateButton()
        {
            return new Button();
        }

        public IComponent CreateList()
        {
            return new List();
        }

        public IComponent CreateTable()
        {
            return new Table();
        }
    }
}
