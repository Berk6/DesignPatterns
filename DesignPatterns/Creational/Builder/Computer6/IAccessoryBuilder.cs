
namespace DesignPatterns.Creational.Builder.Computer6
{
    public interface IAccessoryBuilder
    {
        public IAccessoryBuilder BuildMouse();
        public IAccessoryBuilder BuildKeyboard();
        public Computer BuildAccessories();
    }
}
