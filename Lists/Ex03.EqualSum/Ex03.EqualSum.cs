namespace Ex03.EqualSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSum
    {
        public static void Main()
        {
            var firstListOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondListOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            foreach (var item in firstListOfInt)
            {
                secondListOfInt.Remove(item);
            }

            var sumFirts = firstListOfInt.Sum();
            var sumSecond = secondListOfInt.Sum();
            var diff = Math.Abs(sumFirts - sumSecond);
            if (sumFirts == sumSecond)
            {
                Console.WriteLine($"Yes. Sum: {sumFirts}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
