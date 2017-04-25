namespace Test1._03.EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split();

            var trackIndices = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var checkpointIndices = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var participant in participants)
            {
                double fuel = participant[0];
                
                for (int currentTrackIndex = 0; currentTrackIndex < trackIndices.Length; currentTrackIndex++)
                {
                    bool outOfFuel = fuel <= 0;
                    bool reachedEndOfTrack = currentTrackIndex == trackIndices.Length;
                    var raceEnded = outOfFuel || reachedEndOfTrack;

                    if (raceEnded)
                    {

                        if (outOfFuel)
                        {
                            Console.WriteLine($"{participant} - reached {currentTrackIndex - 1}");
                        }
                        else if (reachedEndOfTrack)
                        {
                            Console.WriteLine($"{participant} - fuel left {fuel:F2}");
                        }

                        break;
                    }

                    var fuelAtCheckpoint = trackIndices[currentTrackIndex];

                    var isCheckpoint = checkpointIndices.Contains(currentTrackIndex);

                    if (isCheckpoint)
                    {
                        fuel += fuelAtCheckpoint;
                    }
                    else
                    {
                        fuel -= fuelAtCheckpoint;
                    }

                }
            }
        }
    }
}
