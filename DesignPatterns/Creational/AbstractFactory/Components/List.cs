using System;
namespace DesignPatterns.Creational.AbstractFactory.Components
{
	public class List : IComponent
	{
		public void Paint()
		{
			Console.WriteLine("Painting a list!");
		}
	}
}
