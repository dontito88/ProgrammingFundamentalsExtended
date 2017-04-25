namespace Test1._04.WinningTickets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            const string pattern = @"([$#^^@])\1{5,}";
            var tickets = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();
            var ticketRegEx = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftHalf = ticket.Substring(0, ticket.Length / 2);
                var rightHalf = ticket.Substring(ticket.Length / 2);

                var leftMatch = ticketRegEx.Match(leftHalf);
                var rightMatch = ticketRegEx.Match(rightHalf);

                if (leftMatch.Success && rightMatch.Success)
                {
                    var winningSymbol = leftMatch.Value[0];
                    var shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);

                    var jackpot = string.Empty;

                    if (shorterMatch == 10)
                    {
                        jackpot = "jackpot";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{winningSymbol}{jackpot}");
                }
            }
        }
    }
}
