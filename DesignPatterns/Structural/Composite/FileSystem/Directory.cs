using DesignPatterns.Structural.Composite.FileSystem.Abstract;
using DesignPatterns.Structural.Composite.FileSystem.Interface;
using DesignPatterns.Structural.Composite.FileSystem.Iterator;

namespace DesignPatterns.Structural.Composite.FileSystem
{
    public class Directory : StorageElement, IStorageContainer
    {
        List<IStorage> _elements = new();
        public Directory(string name):base(name,null)
        {
            IsDirectory = true;
        }
        public Directory(string name, IStorage parent) : base(name, parent)
        {
            IsDirectory = true;
        }

        public void Add(IStorage element)
        {
            _elements.Add(element);
        }

        public void Delete(IStorage element)
        {
            _elements.Remove(element);
        }

        public  List<IStorage> Elements()
        {
            return _elements;
        }

        public DirectoryIterator Iterator()
        {
            return new DirectoryIterator(this);
        }

        public void List()
        {
            throw new NotImplementedException();
        }
        public virtual void Move(Directory target)
        {
            ((Directory)Parent).Delete(this);
            target.Add(this);
        }
        public virtual IStorage Copy()
        {
            try
            {
                return (StorageElement)this.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with copying: " + e.Message);
                return null;
            }
        }
        public bool IsDirectoryy()
        {
            return IsDirectory;
        }
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public IStorage GetParent()
        {
            return Parent;
        }

        public void SetParent(IStorage parent)
        {
            Parent = parent;
        }

        public override string ToString()
        {
            return Name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
