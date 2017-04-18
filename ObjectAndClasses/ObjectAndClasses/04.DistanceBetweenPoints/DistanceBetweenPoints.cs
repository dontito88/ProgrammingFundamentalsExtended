namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firsPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firsPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow((first.X - second.X), 2);
            var squareY = Math.Pow((first.Y - second.Y), 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
