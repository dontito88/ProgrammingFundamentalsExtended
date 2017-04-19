namespace ex01.Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputItems = inputLine
                    .Split(new[] { '-', '>' }, StringSplitOptions
                    .RemoveEmptyEntries);

                var sentence = inputItems[0].Trim();
                var elements = inputItems[1]
                    .Trim()
                    .Split(new[] { ',', ' '},StringSplitOptions
                    .RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";
                    sentence = sentence.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentence);               

                inputLine = Console.ReadLine();
            }
        }
    }
}
