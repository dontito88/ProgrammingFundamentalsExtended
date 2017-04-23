namespace Test1._01.SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var timeFormat = @"hh\:mm\:ss";
            var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);

            var stepsNeeded = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            var secondsPerDay = 60 * 60 * 24;
            var totalSecondsNeeded = (int)((double)stepsNeeded * secondsPerStep % secondsPerDay);

            var arrivalTime = leavingTime.Add(new TimeSpan(0, 0, totalSecondsNeeded));

            Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");

        }
    }
}
