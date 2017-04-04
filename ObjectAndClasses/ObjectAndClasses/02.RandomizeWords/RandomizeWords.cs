namespace _02.RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                var randomPossition = random.Next(0, input.Length);
                var temporaryWord = input[randomPossition];
                input[randomPossition] = currentWord;
                input[i] = temporaryWord;
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
