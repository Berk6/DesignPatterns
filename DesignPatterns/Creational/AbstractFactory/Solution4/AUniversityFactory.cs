using DesignPatterns.Creational.AbstractFactory.Solution4.Components;
namespace DesignPatterns.Creational.AbstractFactory.Solution4
{
    internal class AUniversityFactory : IUniversityFactory
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
