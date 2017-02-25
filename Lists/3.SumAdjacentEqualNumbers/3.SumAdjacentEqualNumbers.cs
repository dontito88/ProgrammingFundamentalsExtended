namespace _3.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                }
            }
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
