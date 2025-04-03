using DesignPatterns.Structural.Composite.FileSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem.Iterator
{
    public interface IStorageIterator:IEnumerable<IStorage>
    {
    }
}
