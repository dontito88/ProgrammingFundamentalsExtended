namespace _3ReverseArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseArray
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            input.Reverse();

            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
