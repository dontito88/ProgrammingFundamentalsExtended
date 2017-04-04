namespace ex02.OrderedBankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class OrderedBankSystem
    {
        public static void Main()
        {
            var bankNameAndAccount = new Dictionary<string, Dictionary<string, decimal>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var inputResult = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bankName = inputResult[0];
                var accountName = inputResult[1];
                var accountDetails = decimal.Parse(inputResult[2]);

                if (!bankNameAndAccount.ContainsKey(bankName))
                {
                    bankNameAndAccount.Add(bankName, new Dictionary<string, decimal>());
                }
                if (!bankNameAndAccount[bankName].ContainsKey(accountName))
                {
                    bankNameAndAccount[bankName].Add(accountName, 0);
                }

                bankNameAndAccount[bankName][accountName] += accountDetails;

                input = Console.ReadLine();
            }

            bankNameAndAccount
                .OrderByDescending(x => x.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})", account.Key, account.Value, bank.Key)));
        }
    }
}
