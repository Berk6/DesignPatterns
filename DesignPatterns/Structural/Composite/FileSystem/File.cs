using DesignPatterns.Structural.Composite.FileSystem.Abstract;
using DesignPatterns.Structural.Composite.FileSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem
{
    public class File : StorageElement
    {
        public File(string name, IStorage parent) : base(name, parent)
        {
        }
    }
}
