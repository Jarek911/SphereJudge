namespace SphereJudge.Spoj.Solutions.Test
{
    public class TestSolution : PuzzleSolver
    {
        public TestSolution(IInputReader inputReader, IOutputWriter outputWriter)
            : base(inputReader, outputWriter)
        {
        }

        public override void Solve()
        {
            while (true)
            {
                var number = InputReader.ReadLine();
                if (number == "42")
                    break;
                OutputWriter.WriteLine(number);
            }
        }
    }
}