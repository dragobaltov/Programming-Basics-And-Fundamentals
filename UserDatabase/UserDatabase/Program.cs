using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var users = new List<User>();
            var newUsers = new List<User>();
            bool loggedIn = false;
            string[] currentUsers = File.ReadAllLines("users.txt");

            for (int i = 0; i < currentUsers.Length; i++)
            {
                string[] tokens = currentUsers[i].Split(' ');
                string username = tokens[0];
                string password = tokens[1];

                users.Add(User.ReadUser(username, password));
            }

            while (input != "exit")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                

                if (command == "register")
                {
                    string username = tokens[1];
                    string password = tokens[2];
                    string confirmedPassword = tokens[3];

                    if (!users.Select(u => u.Username).Contains(username))
                    {
                        if (password == confirmedPassword)
                        {
                            User user = User.ReadUser(username, password);
                            newUsers.Add(user);
                            users.Add(user);
                        }
                        else
                        {
                            Console.WriteLine("The two passwords must match.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The given username already exists.");
                    }
                }
                else if (command == "login")
                {
                    string username = tokens[1];
                    string password = tokens[2];

                    if (!loggedIn)
                    {
                        if (!users.Select(u => u.Username).Contains(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else
                        {
                            string realPassword = User.ReturnPassword(users, username);

                            if (realPassword == password)
                            {
                                Console.WriteLine("There is no currently logged in user.");
                                loggedIn = true;
                            }
                            else
                            {
                                Console.WriteLine("The password you entered is incorrect.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is already a logged in user.");
                    }
                }
                else if (command == "logout")
                {
                    loggedIn = false;
                }

                input = Console.ReadLine();
            }

            string[] newUsersToAdd = new string[newUsers.Count];

            for (int i = 0; i < newUsers.Count; i++)
            {
                string text = newUsers[i].Username + " " + newUsers[i].Password;
                newUsersToAdd[i] = text;
            }

            File.AppendAllLines("users.txt", newUsersToAdd);
        }
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static User ReadUser(string username, string password)
        {
            return new User
            {
                Username = username,
                Password = password
            };
        }

        public static string ReturnPassword(List<User> users, string username)
        {
            string password = "";
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username)
                {
                    password = users[i].Password;
                }
            }

            return password;
        }
    }
}
