using System;

namespace SphereJudge.Spoj.Solutions.Test
{
    public class TestSolutionSubmit
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var number = Console.ReadLine();
                if (number == "42")
                    break;
                Console.WriteLine(number);
            }
        }
    }
}