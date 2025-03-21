using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution3.Components.Tables
{
    public class WinTable : Table
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a Windows Table!");
        }
    }
}
