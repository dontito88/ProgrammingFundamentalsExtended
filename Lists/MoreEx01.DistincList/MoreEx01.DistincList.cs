namespace MoreEx01.DistincList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                var firstElement = inputList[0];
                if (inputList.Contains(firstElement))
                {
                    inputList.Remove(firstElement);
                }
                else
                {
                    Console.WriteLine("No repeating elements");
                }
            }
            foreach (var item in inputList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
