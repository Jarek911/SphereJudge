using System;

namespace SphereJudge.Spoj.Solutions
{
    public interface IInputReader
    {
        string ReadLine();
    }

    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}