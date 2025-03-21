using DesignPatterns.Creational.AbstractFactory.Solution4_1.Components;
namespace DesignPatterns.Creational.AbstractFactory.Solution4_1
{
    internal class BUniversityFactory : IBUniversityFactory
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

        public IComponent CreateVirtualClassroom()
        {
            return new VirtualClassroom();
        }
    }
}
