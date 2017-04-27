namespace Test2._01.ChariryMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharityMarathon
    {
        public static void Main()
        {
            int marathonDays = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int averageLapsOnTrack = int.Parse(Console.ReadLine());
            long lapLenght = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());
            
            trackCapacity = trackCapacity * marathonDays;

            runners = Math.Min(trackCapacity, runners);

            long totalKm = (runners * lapLenght * averageLapsOnTrack) / 1000;

            var totalMoney = totalKm * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
