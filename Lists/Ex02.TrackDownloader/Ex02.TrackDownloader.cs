namespace Ex02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine().Split();
            var trackList = new List<string>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var isInBlacklist = false;

                foreach (var blacklistedWord in blackList)
                {
                    if (line.Contains(blacklistedWord))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }

                if (!isInBlacklist)
                {
                    trackList.Add(line);
                }

                line = Console.ReadLine();

            }

            trackList.Sort();

            foreach (var item in trackList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
