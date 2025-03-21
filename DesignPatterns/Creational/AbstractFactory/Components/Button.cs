using System;
namespace DesignPatterns.Creational.AbstractFactory.Components
{
	public class Button : IComponent
	{
		public void Paint()
		{
			Console.WriteLine("Painting a button!");
		}
	}
}
