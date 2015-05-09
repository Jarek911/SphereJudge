using System;

namespace SphereJudge.Spoj.Solutions.Addrev
{
    public class AddrevSolutionSubmit
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                var line = Console.ReadLine();
                var numberStrings = line.Split(' ');
                var firstNumber = ulong.Parse(numberStrings[0]);
                var secondNumber = ulong.Parse(numberStrings[1]);
                var resultNumber = ReverseNumber(firstNumber) + ReverseNumber(secondNumber);
                var result = ReverseNumber(resultNumber);
                Console.WriteLine(result);
            }
        }

        private static ulong ReverseNumber(ulong number)
        {
            ulong result = 0;

            while (number > 0)
            {
                ulong digit = number % 10;
                result = result * 10 + digit;
                number /= 10;
            }

            return result;
        }
    }
}