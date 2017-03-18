namespace ex02.DitRef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRef
    {
        public static void Main()
        {

            var resultDict = new Dictionary<string, int>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split();
                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referenceValue = resultDict[lastElement];
                        resultDict[firstElement] = referenceValue;
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var itemPricePair in resultDict)
            {
                var item = itemPricePair.Key;
                var price = itemPricePair.Value;
                Console.WriteLine($"{item} === {price}");
            }
        }
    }
}
