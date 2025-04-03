using DesignPatterns.Structural.Composite.FileSystem.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem.Interface
{
    public interface IStorageContainer
    {
        public void Add(IStorage element);

        public void Delete(IStorage element);

        public void List();

        public List<IStorage> Elements();

        public DirectoryIterator Iterator();
    }
}
