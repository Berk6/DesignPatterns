using DesignPatterns.Creational.AbstractFactory.Solution4.Components;

namespace DesignPatterns.Creational.AbstractFactory.Solution4
{
    internal interface IUniversityFactory
    {
        public IComponent CreateCourse();
        public IComponent CreateProfessor();
        public IComponent CreateSchedule();
        public IComponent CreateSyllabus();
    }
}
