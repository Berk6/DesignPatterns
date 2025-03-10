using DesignPatterns.Creational.FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Students
{
    internal class PhDStudent : Student
    {
        public string MastersDegreeDepartmentName { get; set; }
        public PhDStudent(string name, string surname, DateTime birthDate, string mastersDegreeDepartmentName)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
            this.MastersDegreeDepartmentName = mastersDegreeDepartmentName;
        }
    }
}
