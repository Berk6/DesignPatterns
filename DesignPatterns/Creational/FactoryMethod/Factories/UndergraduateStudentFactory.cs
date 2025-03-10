using DesignPatterns.Creational.FactoryMethod.Students;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    internal class UndergraduateStudentFactory : StudentFactory
    {
        public override Student CreateStudent(string name, string surname, DateTime birthDate)
        {
            return new UndergraduateStudent(name,surname,birthDate);
        }
    }
}
