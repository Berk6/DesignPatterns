using DesignPatterns.Creational.FactoryMethod.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    internal abstract class StudentFactory
    {
        public abstract Student CreateStudent(string name, string surname, DateTime birthDate);        
    }
}
