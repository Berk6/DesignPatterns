using DesignPatterns.Creational.AbstractFactory.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Solution2
{
    public interface IGUIFactory
    {
        IComponent CreateButton();

        IComponent CreateList();

        IComponent CreateTable();
    }
}
