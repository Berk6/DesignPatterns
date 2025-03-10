using DesignPatterns.Creational.FactoryMethod.Bloch;
using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Students;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Process
    {
        internal void CheckStudentObjects()
        {
            StudentFactory ugStudentFactory = new UndergraduateStudentFactory();
            StudentFactory graduateStudentFactory = new GraduateStudentFactory();
            StudentFactory associateDegreeStudentFactory = new AssociateDegreeStudentFactory();
            PhDStudentFactory phDStudentFactory = new ();

            Student ugStudent= ugStudentFactory.CreateStudent("Berk", "000", new DateTime(1995, 01, 13));
            Student graduateStudent= graduateStudentFactory.CreateStudent("Ahmet", "123", new DateTime(1995, 01, 13));
            Student associateDegreeStudent = associateDegreeStudentFactory.CreateStudent("Mehmet", "456", new DateTime(1995, 01, 13));

            Student phdStudent= phDStudentFactory.CreateStudent("Berk", "99", new DateTime(1995, 01, 13),"Mechanical");

            BlochStudent blochPhdStudent = BlochStudent.GetPhdStudent("Berk", "1232", new DateTime(1995, 01, 13), "Mechanical");
        }
    }
}
