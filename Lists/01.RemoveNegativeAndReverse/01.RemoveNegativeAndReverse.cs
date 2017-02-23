namespace _01.RemoveNegativeAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            inputList.Reverse();
            var possitiveList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > 0)
                {
                    possitiveList.Add(inputList[i]);
                }
            }

            if (possitiveList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            foreach (var number in possitiveList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
