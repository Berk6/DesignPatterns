using DesignPatterns.Creational.FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Students
{
    internal class UndergraduateStudent : Student
    {
        public UndergraduateStudent(string name, string surname, DateTime birthDate)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
        }
    }
}
