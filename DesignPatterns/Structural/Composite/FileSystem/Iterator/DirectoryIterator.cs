using DesignPatterns.Structural.Composite.FileSystem.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.FileSystem.Iterator
{
    public class DirectoryIterator: IEnumerator<IStorage>
    {
        private Directory dir;
        private List<IStorage> elements;
        private int position = -1;

        public DirectoryIterator(Directory dir)
        {
            this.dir = dir;
            elements = dir.Elements();
        }

        public bool MoveNext()
        {
            position++;
            return position < elements.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public IStorage Current => elements[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Gerekirse temizleme işlemleri burada yapılabilir.
        }
    }
}
