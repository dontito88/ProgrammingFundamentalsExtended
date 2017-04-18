namespace _03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWors = Console.ReadLine()
                .Split(new[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var word in bannedWors)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
