namespace SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numberList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                numberList.Add(input);
            }

            var min = numberList.Min();
            var max = numberList.Max();
            var sum = numberList.Sum();
            var first = numberList.First();
            var last = numberList.Last();
            var average = numberList.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
