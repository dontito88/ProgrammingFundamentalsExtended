namespace _01.ReversedString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReversedString
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .ToArray()
                .Reverse();

            foreach (var item in text)
            {
                Console.Write(item);
            }
        }
    }
}
