namespace _05.SortedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            input.Sort();
             
            Console.Write(string.Join(" <= ", input));
            Console.WriteLine();
        }
    }
}
