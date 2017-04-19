namespace ex02.JSONstringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }

    public class JSONstringify
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            var inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                var inputItems = inputLine
                    .Split(new[] { ' ', ':', ',', '-', '>' }, StringSplitOptions
                    .RemoveEmptyEntries);

                var studentName = inputItems[0];
                var studentAge = int.Parse(inputItems[1]);
                var studentGrades = inputItems
                    .Skip(2)
                    .Select(int.Parse)
                    .ToArray();

                Student newStudent = new Student();
                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(newStudent);

                inputLine = Console.ReadLine();
            }

            string output = "[";

            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                output += "{";
                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                output += "}";

                if (i < students.Count - 1)
                {
                    output += ",";
                }
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
