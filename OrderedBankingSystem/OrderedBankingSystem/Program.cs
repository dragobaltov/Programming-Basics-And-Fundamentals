using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var banksData = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string bank = inputTokens[0];
                string account = inputTokens[1];
                decimal balance = decimal.Parse(inputTokens[2]);

                if (!banksData.ContainsKey(bank))
                    banksData.Add(bank, new Dictionary<string, decimal>());
                if (!banksData[bank].ContainsKey(account))
                    banksData[bank].Add(account, 0);

                banksData[bank][account] += balance;

                input = Console.ReadLine();
            }

            foreach (var item in banksData.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Max()))
            {
                foreach (var pair in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value} ({item.Key})");
                }
            }
        }
    }
}
