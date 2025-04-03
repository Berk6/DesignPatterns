namespace DesignPatterns.Structural.Composite.FileSystem.Interface
{
    public interface IStorage
    {
        void Rename(string newName);
        void Save();
        void Delete();
        IStorage Copy();
        void Move(Directory target);
    }

}
