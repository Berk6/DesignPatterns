using DesignPatterns.Creational.FactoryMethod.Students;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    internal class GraduateStudentFactory : StudentFactory
    {
        public override Student CreateStudent(string name, string surname, DateTime birthDate)
        {
            return new GraduateStudent(name,surname,birthDate);
        }
    }
}
