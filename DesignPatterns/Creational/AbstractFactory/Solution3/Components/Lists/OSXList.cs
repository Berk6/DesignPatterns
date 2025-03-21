using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution3.Components.Lists
{
    public class OSXList : List
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a macOS List!");
        }
    }
}
