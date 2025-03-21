using DesignPatterns.Creational.AbstractFactory.Components;
using DesignPatterns.Creational.AbstractFactory.Solution1;
using DesignPatterns.Creational.AbstractFactory.Solution2;
using DesignPatterns.Creational.AbstractFactory.Solution3;
namespace DesignPatterns.Creational.AbstractFactory
{
    public class Process
    {
        public static void Solution1()
        {

            Solution1.IGUIFactory factory = new ListFactory();
            new Client(factory);
        }
        public static void Solution2()
        {

            Solution2.IGUIFactory factory = new GUIFactory();
            IComponent list = factory.CreateList();
            IComponent button = factory.CreateButton();
            IComponent table = factory.CreateTable();
        }
        public static void Solution3()
        {
            Solution3.IGUIFactory osxFactory = new OSXGUIFactory();
            Solution3.IGUIFactory winFactory = new WinGUIFactory();
            Solution3.Components.IComponent osxList = osxFactory.CreateList();
            Solution3.Components.IComponent osxButton = osxFactory.CreateButton();
            Solution3.Components.IComponent osxTable = osxFactory.CreateTable();
            Solution3.Components.IComponent winList = osxFactory.CreateList();
            Solution3.Components.IComponent winButton = winFactory.CreateButton();
            Solution3.Components.IComponent winTable = winFactory.CreateTable();

        }
    }
}
