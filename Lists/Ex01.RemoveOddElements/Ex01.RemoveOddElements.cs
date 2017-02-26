namespace Ex01.RemoveOddElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var evenElements = new List<string>();

            for (int i = 1; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    evenElements.Add(input[i]);
                }
            }
            foreach (var item in evenElements)
            {
                Console.Write(item);
            }
        }
    }
}
