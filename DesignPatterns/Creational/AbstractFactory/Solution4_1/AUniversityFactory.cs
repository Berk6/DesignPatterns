using DesignPatterns.Creational.AbstractFactory.Solution4_1.Components;
namespace DesignPatterns.Creational.AbstractFactory.Solution4_1
{
    internal class AUniversityFactory : IAUniversityFactory
    {
        public AUniversityFactory()
        {

        }
        public IComponent CreateCourse()
        {
            return new Course();
        }

        public IComponent CreateProfessor()
        {
            return new Professor();
        }

        public IComponent CreateSchedule()
        {
            return new Schedule();
        }

        public IComponent CreateSyllabus()
        {
            return new Syllabus();
        }
    }
}
