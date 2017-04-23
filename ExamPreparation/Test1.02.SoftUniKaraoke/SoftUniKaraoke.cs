namespace Test1._02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var participantsAndAwards = new Dictionary<string, SortedSet<string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "dawn")
            {
                var inputElements = inputLine
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();

                var participant = inputElements[0];
                var song = inputElements[1];
                var award = inputElements[2];

                if (songs.Contains(song) && participants.Contains(participant))
                {
                    if (!participantsAndAwards.ContainsKey(participant))
                    {
                        participantsAndAwards[participant] = new SortedSet<string>(); 
                    }

                    participantsAndAwards[participant].Add(award);
                }

                inputLine = Console.ReadLine();
            }

            if (participantsAndAwards.Count <=0)
            {
                Console.WriteLine("No awards");
                return;
            }

            var sortedParticipantAwards = participantsAndAwards
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var participantAwart in sortedParticipantAwards)
            {
                var participant = participantAwart.Key;
                var awards = participantAwart.Value;

                Console.WriteLine($"{participant}: {awards.Count} awards");

                foreach (var award in awards)
                {
                    Console.WriteLine($"--{award}");
                }
            }

        }
    }
}
