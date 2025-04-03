using DesignPatterns.Structural.Composite.FileSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem
{
    internal class Alias : StorageElement
    {
        public Alias(string name, StorageElement parent) : base(name, parent)
        {
        }
    }
}
