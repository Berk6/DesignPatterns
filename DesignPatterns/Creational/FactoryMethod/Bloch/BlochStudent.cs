using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Bloch
{
    public class BlochStudent
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string MastersDegreeDepartmentName { get; set; }
        public BlochStudent(string name, string surname, DateTime birthDate, string mastersDegreeDepartmentName)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
            this.MastersDegreeDepartmentName = mastersDegreeDepartmentName;
        }
        public BlochStudent(string name, string surname, DateTime birthDate)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
        }
        public static BlochStudent GetAssociateDegreeStudent(string name, string surname, DateTime birthDate)
        {
            return new BlochStudent(name, surname, birthDate);
        }
        public static BlochStudent GetUndergraduateStudent(string name, string surname, DateTime birthDate)
        {
            return new BlochStudent(name, surname, birthDate);
        }
        public static BlochStudent GetGraduateStudent(string name, string surname, DateTime birthDate)
        {
            return new BlochStudent(name, surname, birthDate);
        }
        public static BlochStudent GetPhdStudent(string name, string surname, DateTime birthDate, string mastersDegreeDepartmentName)
        {
            return new BlochStudent(name, surname, birthDate, mastersDegreeDepartmentName);
        }
        private BlochStudent()
        {
        }
    }

}
