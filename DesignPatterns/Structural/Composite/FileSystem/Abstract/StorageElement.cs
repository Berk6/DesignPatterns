using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem.Abstract
{
    using DesignPatterns.Structural.Composite.FileSystem.Interface;
    using System;

    public abstract class StorageElement : IStorage, ICloneable
    {
        protected string Name { get; set; }
        protected IStorage Parent { get; set; }
        protected bool IsDirectory { get; set; }

        public StorageElement(string name, IStorage parent)
        {
            Name = name;
            Parent = parent;
            if (parent != null)
                ((Directory)parent).Add(this);
        }

        public void Rename(string newName)
        {
            Name = newName;
        }

        public void Save()
        {
            Console.WriteLine("Saving the element.");
        }

        public void Delete()
        {
            ((Directory)Parent).Delete(this);
        }

        public IStorage Copy()
        {
            try
            {
                return (IStorage)Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with copying: " + e.Message);
                return null;
            }
        }

        public void Move(Directory target)
        {
            ((Directory)Parent).Delete(this);
            target.Add(this);
        }

        public override string ToString()
        {
            return Name;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        IStorage IStorage.Copy()
        {
            throw new NotImplementedException();
        }
    }

}
