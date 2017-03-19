namespace _01.AvarageStudentsGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AvarageStudentsGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');
                var name = inputLine[0];
                var grade = double.Parse(inputLine[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<double>();
                    studentsGrades[name].Add(grade);
                }
                else
                {
                    studentsGrades[name].Add(grade);
                }
            }

            foreach (var item in studentsGrades)
            {
                var name = item.Key;
                var grades = item.Value;
                var gradeString = grades.Select(p => string.Format("{0:f2}", p));
                var avgGrade = grades.Average();
                Console.WriteLine($"{name} -> {string.Join(" ", gradeString)} (avg: {avgGrade.ToString("0.00")})");
            }
        }
    }
}
