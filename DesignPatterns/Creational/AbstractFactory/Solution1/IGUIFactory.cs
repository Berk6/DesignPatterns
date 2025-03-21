using DesignPatterns.Creational.AbstractFactory.Components;
using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution1
{
    public interface IGUIFactory
    {
         IComponent Create();
    }
}
