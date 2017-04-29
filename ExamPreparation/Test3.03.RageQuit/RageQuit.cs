namespace Test3._03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            Regex regex = new Regex(@"(\D+)(\d+)");

            MatchCollection matches = regex.Matches(inputLine);

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string partition = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);

                result.Append(Repeat(partition, times).ToUpper());
            }

            int symbolCounter = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {symbolCounter}");
            Console.WriteLine(result);
        }

        private static string Repeat(string partition, int times)
        {
            StringBuilder finalString = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                finalString.Append(partition);
            }

            return finalString.ToString();
        }
    }
}
