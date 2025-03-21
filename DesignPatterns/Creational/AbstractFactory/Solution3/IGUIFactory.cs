using DesignPatterns.Creational.AbstractFactory.Solution3.Components;

namespace DesignPatterns.Creational.AbstractFactory.Solution3
{
    public interface IGUIFactory
    {
        IComponent CreateButton();
        IComponent CreateList();
        IComponent CreateTable();
    }
}