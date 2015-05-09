using SphereJudge.Spoj.Solutions.Test;
using StructureMap.Configuration.DSL;

namespace SphereJudge.Spoj.Solutions
{
    public class IoCRegistry : Registry
    {
        public IoCRegistry()
        {
            For<PuzzleSolver>().Use<TestSolution>().Singleton();

            For<IInputReader>().Use<ConsoleInputReader>().Singleton();
            For<IOutputWriter>().Use<ConsoleOutputWriter>().Singleton();
        }
    }
}