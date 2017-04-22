namespace RegEx.ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            var pattern = @"<a.+?href=(.+?)>(.+?)<\/a>";
            var regex = new Regex(pattern);

            var text = Console.ReadLine();
            var replacement = "[URL href=$1]$2[/URL]";
            var result = regex.Replace(text, replacement);
            Console.WriteLine(result);
        }
    }
}
