namespace _03.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nameSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                nameSet.Add(inputLine);
            }

            foreach (var item in nameSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
