using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var usernamesData = new Dictionary<string, User>();

            while (input != "exit")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "register")
                {
                    string username = tokens[1];
                    usernamesData.Add(username, new User(username));
                }
                else
                {
                    string sender = tokens[0];
                    string recipient = tokens[2];
                    string content = tokens[3];

                    if (usernamesData.ContainsKey(sender) && usernamesData.ContainsKey(recipient))
                    {
                        User senderUser = usernamesData[sender];
                        usernamesData[recipient].ReceivedMessages.Add(new Message(content, senderUser));
                    }
                }

                input = Console.ReadLine();
            }

            string[] names = Console.ReadLine().Split(' ');
            string firstName = names[0];
            string secondName = names[1];
            var firstNamePhrases = usernamesData[secondName].ReceivedMessages
                .Where(u => u.Sender.Username == firstName).ToList();
            var secondNamePhrases = usernamesData[firstName].ReceivedMessages
                .Where(u => u.Sender.Username == secondName).ToList();

            if (firstNamePhrases.Count == 0 && secondNamePhrases.Count == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {
                int index = 0;

                while (index < firstNamePhrases.Count && index < secondNamePhrases.Count)
                {
                    Console.WriteLine($"{firstName}: {firstNamePhrases[index].Content}");
                    Console.WriteLine($"{secondNamePhrases[index].Content} :{secondName}");

                    index++;
                }

                while (index < firstNamePhrases.Count)
                {
                    Console.WriteLine($"{firstName}: {firstNamePhrases[index].Content}");
                    index++;
                }
                while (index < secondNamePhrases.Count)
                {
                    Console.WriteLine($"{secondNamePhrases[index].Content} :{secondName}");
                    index++;
                }
            }
        }

        class Message
        {
            public string Content { get; set; }
            public User Sender { get; set; }

            public Message(string content, User sender)
            {
                Content = content;
                Sender = sender;
            }
        }

        class User
        {
            public string Username { get; set; }
            public List<Message> ReceivedMessages { get; set; }

            public User(string username)
            {
                Username = username;
                ReceivedMessages = new List<Message>();
            }
        }
    }
}
