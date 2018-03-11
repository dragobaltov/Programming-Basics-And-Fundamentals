using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<BankAccount> accounts = new List<BankAccount>();

            while (input != "end")
            {
                BankAccount bankAccount = BankAccount.ReadBankAccount(input);
                accounts.Add(bankAccount);

                input = Console.ReadLine();
            }

            foreach (var item in accounts.OrderByDescending(a => a.Balance).ThenBy(a => a.Bank.Length))
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }

        class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }

            public static BankAccount ReadBankAccount(string input)
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                return new BankAccount
                {
                    Name = tokens[1],
                    Bank = tokens[0],
                    Balance = decimal.Parse(tokens[2])
                };
            }
        }
    }
}
