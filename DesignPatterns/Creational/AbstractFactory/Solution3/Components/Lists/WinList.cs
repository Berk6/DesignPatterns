using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution3.Components.Lists
{
    public class WinList : List
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a Windows List!");
        }
    }
}
