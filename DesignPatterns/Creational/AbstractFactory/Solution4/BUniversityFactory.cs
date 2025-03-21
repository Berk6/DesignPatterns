using DesignPatterns.Creational.AbstractFactory.Solution4.Components;
namespace DesignPatterns.Creational.AbstractFactory.Solution4
{
    internal class BUniversityFactory : IUniversityFactory
    {
        public BUniversityFactory()
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
