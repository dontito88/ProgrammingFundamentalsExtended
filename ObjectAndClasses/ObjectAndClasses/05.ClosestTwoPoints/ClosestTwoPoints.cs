namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minimumDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = Distance(firstPoint, secondPoint);

                    if (distance < minimumDistance)
                    {
                        minimumDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }

                }

            }

            Console.WriteLine($"{minimumDistance:F3}");
            Console.WriteLine($"({ firstPointResult.X}, { firstPointResult.Y})");
            Console.WriteLine($"({ secondPointResult.X}, { secondPointResult.Y})");
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
