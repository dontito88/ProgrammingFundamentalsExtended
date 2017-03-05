namespace _2SmallestElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElement
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input.Sort();

            Console.WriteLine(input[0]);
        }
    }
}
