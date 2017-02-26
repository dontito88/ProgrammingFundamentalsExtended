namespace _04.SplitByWord
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWord
    {
        public static void Main()
        {
            String inputText = Console.ReadLine();
            string[] words = inputText
                                .Split(new char[] { ',', '.', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, 
                                StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string upCase = words[i].ToUpper();
                string lowCase = words[i].ToLower();
                if (words[i].Equals(upCase) && !CheckForSymbols(words[i]))
                {
                    upperCase.Add(words[i]);
                }
                else if (words[i].Equals(lowCase) && !CheckForSymbols(words[i]))
                {
                    lowerCase.Add(words[i]);
                }
                else
                {
                    mixedCase.Add(words[i]);
                }
            }
            Console.WriteLine();

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCase));

        }
        private static bool CheckForSymbols(string word)
        {
            char[] symbols = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if ((int)symbols[i] < 65)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
