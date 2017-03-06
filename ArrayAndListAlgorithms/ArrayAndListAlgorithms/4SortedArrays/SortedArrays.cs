namespace _4SortedArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedArrays
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
