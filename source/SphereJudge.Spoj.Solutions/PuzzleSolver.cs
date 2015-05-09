namespace SphereJudge.Spoj.Solutions
{
    public abstract class PuzzleSolver
    {
        protected readonly IInputReader InputReader;
        protected readonly IOutputWriter OutputWriter;

        protected PuzzleSolver(IInputReader inputReader, IOutputWriter outputWriter)
        {
            InputReader = inputReader;
            OutputWriter = outputWriter;
        }

        public abstract void Solve();
    }
}