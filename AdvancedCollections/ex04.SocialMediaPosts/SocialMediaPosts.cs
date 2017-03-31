namespace ex04.SocialMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var like = new Dictionary<string, int>();
            var dislike = new Dictionary<string, int>();
            var comment = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "drop the medi")
            {

                string firstElement = inputLine[0];
                
                if (firstElement == "post")
                {

                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
