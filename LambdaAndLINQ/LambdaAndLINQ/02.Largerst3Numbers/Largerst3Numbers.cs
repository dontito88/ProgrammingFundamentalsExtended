namespace _02.Largerst3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largerst3Numbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList<int>()
                .OrderByDescending(x => x)
                .Take(3);

            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
