namespace SphereJudge.Spoj.Solutions
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var solver = DefaultIoC.Container.GetInstance<PuzzleSolver>();
            solver.Solve();
        }
    }
}