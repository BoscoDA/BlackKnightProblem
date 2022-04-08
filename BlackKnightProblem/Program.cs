using System;

namespace BlackKnightProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(increment("1.1.1", 2));
            Console.WriteLine(increment("1.5.17", 1));
            Console.WriteLine(increment("2.1.0"));
            Console.WriteLine(increment("2.1.0", 3));
            Console.ReadKey();
        }
        static string increment(string input, int target = 0)
        {
            string[] subStrings = input.Split('.');
            int temp = 0;
            if (target == 0)
            {
                int.TryParse(subStrings[subStrings.Length - 1], out temp);
                temp++;
                subStrings[subStrings.Length - 1] = temp.ToString();
                return $"{subStrings[0]}.{subStrings[1]}.{subStrings[2]}";
            }
            int.TryParse(subStrings[target - 1], out temp);
            temp++;
            subStrings[target - 1] = temp.ToString();
            for (int i = target; i < subStrings.Length; i++)
            {
                subStrings[i] = "0";
            }

            return $"{subStrings[0]}.{subStrings[1]}.{subStrings[2]}";
        }
    }
}
