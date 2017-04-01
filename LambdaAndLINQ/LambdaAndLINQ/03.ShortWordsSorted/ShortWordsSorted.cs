namespace _03.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ', '.', ',', '/', '\\', ':', ';', ')', '(', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= 4)
                .OrderBy(x => x)
                .Distinct()
                .ToList<string>();
            
                Console.Write(string.Join(", ", input));
        }
    }
}
