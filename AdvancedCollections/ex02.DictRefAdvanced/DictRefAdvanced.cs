namespace DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var dictionary = new Dictionary<string, List<int>>();

            while (inputLine != "end")
            {
                var inputParameters = inputLine.Split(new [] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = inputParameters[0];
                var info = inputParameters[1];
                var infoValue = -1;

                if (int.TryParse(info, out infoValue))
                {
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary[name] = new List<int>();
                    }

                    for (int i = 1; i < inputParameters.Length; i++)
                    {
                        dictionary[name].Add(int.Parse(inputParameters[i]));
                    }
                }
                else
                {
                    if (dictionary.ContainsKey(info))
                    {
                        dictionary[name] = new List<int>(dictionary[info]);
                    }
                }
               
                inputLine = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
            }
        }
    }
}