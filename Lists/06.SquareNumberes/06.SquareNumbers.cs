namespace _06.SquareNumberes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareList = new List<int>();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    squareList.Add(input[i]);
                }
            }
            squareList.Sort((a, b) => b.CompareTo(a));

            foreach (var item in squareList)
            {
                Console.Write(" " + item);
            }
        }
    }
}
