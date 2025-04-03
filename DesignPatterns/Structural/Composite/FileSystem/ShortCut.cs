using DesignPatterns.Structural.Composite.FileSystem.Abstract;
using DesignPatterns.Structural.Composite.FileSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem
{
    public class ShortCut : StorageElement
    {
        public ShortCut(string name, IStorage parent) : base(name, parent)
        {
        }
    }
}
