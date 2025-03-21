namespace DesignPatterns.Creational.AbstractFactory.Components
{
    public class Table : IComponent
	{
		public void Paint()
		{
			Console.WriteLine("Painting a table!");
		}
	}
}
