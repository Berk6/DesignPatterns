using DesignPatterns.Creational.AbstractFactory.Components;
using DesignPatterns.Creational.AbstractFactory.Solution1;

namespace DesignPatterns.Creational.AbstractFactory.Solution1
{
    internal class TableFactory : IGUIFactory
    {
        public IComponent Create()
        {
            return new Table();
        }
    }
}
