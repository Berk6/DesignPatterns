using DesignPatterns.Creational.FactoryMethod.Students;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    internal class AssociateDegreeStudentFactory : StudentFactory
    {
        public override Student CreateStudent(string name, string surname, DateTime birthDate)
        {
            return new AssociateDegreeStudent(name,surname,birthDate);
        }
    }
}
