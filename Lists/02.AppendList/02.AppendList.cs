namespace _02.AppendList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var numbers = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                numbers.AddRange(input[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
