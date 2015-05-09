using System;

namespace SphereJudge.Spoj.Solutions
{
    public interface IOutputWriter
    {
        void WriteLine(string s);
    }

    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}