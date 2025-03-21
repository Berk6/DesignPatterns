using DesignPatterns.Creational.AbstractFactory.Solution4_1.Components;

namespace DesignPatterns.Creational.AbstractFactory.Solution4_1
{
    internal interface IAUniversityFactory
    {
        public IComponent CreateCourse();
        public IComponent CreateProfessor();
        public IComponent CreateSchedule();
        public IComponent CreateSyllabus();
    }
}
