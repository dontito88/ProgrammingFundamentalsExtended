namespace _7LargestNelements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNelements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var n = int.Parse(Console.ReadLine());

            input.Sort();

            for (int i = input.Count - 1; i > input.Count - n - 1; i--)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
