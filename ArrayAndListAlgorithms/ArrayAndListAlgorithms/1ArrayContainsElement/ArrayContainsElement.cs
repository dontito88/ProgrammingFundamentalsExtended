namespace _1ArrayContainsElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int containedNum = int.Parse(Console.ReadLine());

            bool isContain = inputArray.Contains(containedNum);

            if (isContain)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
