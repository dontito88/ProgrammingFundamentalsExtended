namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {      
                    result[word] = 0;
                }

                result[word]++;
            }

            var oddNumbesWords = new List<string>();

            foreach (var kvp in result)
            {
                var value = kvp.Value;
                if (value % 2 != 0)
                {
                    oddNumbesWords.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumbesWords));
        }
    }
}
