﻿using System;
namespace DesignPatterns.Creational.AbstractFactory.Solution3.Components.Buttons
{
    public class OSXButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Painting a macOS Button!");
        }
    }
}
