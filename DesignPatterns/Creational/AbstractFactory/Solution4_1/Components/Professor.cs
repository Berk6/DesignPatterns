using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Solution4_1.Components
{
    internal class Professor : IComponent
    {
        public void WriteName()
        {
            Console.WriteLine("Professor");
        }
    }
}
