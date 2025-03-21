using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution3.Components.Tables
{
    public class OSXTable : Table
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a macOS Table!");
        }
    }
}
