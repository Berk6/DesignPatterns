using DesignPatterns.Creational.FactoryMethod.Students;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    internal class PhDStudentFactory
    {
        public Student CreateStudent(string name, string surname, DateTime birthDate, string mastersDegreeDepartmentName) => new PhDStudent(name, surname, birthDate, mastersDegreeDepartmentName);
    }
}
