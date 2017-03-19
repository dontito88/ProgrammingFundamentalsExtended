namespace ex06.FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterBase
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var ageDatabase = new Dictionary<string, int>();
            var salaryDatabase = new Dictionary<string, double>();
            var positionDatabase = new Dictionary<string, string>();

            while (inputLine != "filter base")
            {
                var employeeInfo = inputLine.Split();
                var name = employeeInfo[0];
                var details = employeeInfo[employeeInfo.Length - 1];

                int employeeAge = 0;
                double employeeSalary = 0;

                if (int.TryParse(details, out employeeAge))
                {
                    ageDatabase[name] = employeeAge;
                }
                else if (double.TryParse(details, out employeeSalary))
                {
                    salaryDatabase[name] = employeeSalary;
                }
                else
                {
                    positionDatabase[name] = details;
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();
            if (inputLine == "Age")
            {
                foreach (var item in ageDatabase)
                {
                    var name = item.Key;
                    var age = item.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine("====================");
                }
            }
            else if (inputLine == "Salary")
            {
                foreach (var item in salaryDatabase)
                {
                    var name = item.Key;
                    var salary = item.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Salary: {salary.ToString("0.00")}");
                    Console.WriteLine("====================");
                }
            }
            else if (inputLine == "Position")
            {
                foreach (var item in positionDatabase)
                {
                    var name = item.Key;
                    var position = item.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
