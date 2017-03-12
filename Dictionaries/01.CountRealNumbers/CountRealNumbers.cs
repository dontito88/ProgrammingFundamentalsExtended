namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse);
            input = new SortedDictionary<double, double>();
        }
    }
}
