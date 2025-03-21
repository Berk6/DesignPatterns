using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution3.Components.Buttons
{
    public class WinButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a Windows Button!");
        }
    }
}
