using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernamePassword = Console.ReadLine().Split
                (new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> info = new Dictionary<string, string>();
            int counter = 0;

            while (usernamePassword[0] != "login")
            {
                string username = usernamePassword[0];
                string password = usernamePassword[1];

                if (info.ContainsKey(username))
                {
                    if (password != info[username])
                    {
                        info[username] = password;
                    }
                }
                else
                {
                    info.Add(username, password);
                }

                usernamePassword = Console.ReadLine().Split
                (new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] accounts = Console.ReadLine().Split
                (new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (accounts[0] != "end")
            {
                string username = accounts[0];
                string password = accounts[1];

                if (info.ContainsKey(username))
                {
                    if (info[username] == password)
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    counter++;
                }

                accounts = Console.ReadLine().Split
                (new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
