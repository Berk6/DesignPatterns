using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Book
    {
        private string _bookName;
        private List<Page> _pages;
        private static Character _endOfPage = new(12);

        public Book(string bookName, int numberOfPages)
        {
            this._bookName = bookName;
            _pages = new List<Page>(numberOfPages);
        }

        public void Add(Page page) => _pages.Add(page);

        public List<Page> GetPages() => _pages;

        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var page in _pages)
            {
                sb.Append(page.ToString());
                sb.Append(_endOfPage.ToString());
            }
            return sb.ToString();
        }
    }
}
