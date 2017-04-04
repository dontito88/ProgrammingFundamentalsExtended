namespace _01.DayOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DayOfWeek
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('-').ToList();
            int day = int.Parse(input[0]);
            int month = int.Parse(input[1]);
            int year = int.Parse(input[2]);

            var date = new DateTime(year, month, day);
            Console.WriteLine(date.DayOfWeek);

        }
    }
}
