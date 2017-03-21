namespace ex01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var vladiSshell = new Dictionary<string, HashSet<int>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "Aggregate")
            {
                var shellInfo = inputLine.Split(' ');
                var region = shellInfo[0];
                var size = int.Parse(shellInfo[1]);

                if (!vladiSshell.ContainsKey(region))
                {
                    vladiSshell[region] = new HashSet<int>();
                }
                vladiSshell[region].Add(size);

                inputLine = Console.ReadLine();
            }

            foreach (var item in vladiSshell)
            {
                var regionName = item.Key;
                var shells = item.Value;
                var sumOfShells = shells.Sum();
                var giantShell = sumOfShells - sumOfShells / shells.Count;
                Console.WriteLine($"{regionName} -> {string.Join(", ", shells)} ({giantShell})");
            }
        }
    }
}
