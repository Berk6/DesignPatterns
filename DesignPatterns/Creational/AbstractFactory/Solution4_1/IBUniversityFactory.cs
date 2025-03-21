using DesignPatterns.Creational.AbstractFactory.Solution4_1.Components;

namespace DesignPatterns.Creational.AbstractFactory.Solution4_1
{
    internal interface IBUniversityFactory
    {
        public IComponent CreateCourse();
        public IComponent CreateProfessor();
        public IComponent CreateSchedule();
        public IComponent CreateSyllabus();
        public IComponent CreateVirtualClassroom();
    }
}
