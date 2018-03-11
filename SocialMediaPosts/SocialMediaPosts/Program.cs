using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var likes = new Dictionary<string, int>();
            var dislikes = new Dictionary<string, int>();
            var comments = new Dictionary<string, Dictionary<string, string>>();

            while (input[0] != "drop")
            {
                string command = input[0];
                string postName = input[1];

                if (command == "post")
                {
                    if (!likes.ContainsKey(postName))
                        likes.Add(postName, 0);

                    if (!dislikes.ContainsKey(postName))
                        dislikes.Add(postName, 0);

                    if (!comments.ContainsKey(postName))
                        comments.Add(postName, new Dictionary<string, string>());
                }
                else if (command == "like")
                {
                    likes[postName]++;
                }
                else if (command == "dislike")
                {
                    dislikes[postName]++;
                }
                else if (command == "comment")
                {
                    string name = input[2];
                    string text = null;
                    for (int i = 3; i < input.Length; i++)
                    {
                        text += input[i];
                        text += " ";
                    }

                    comments[postName].Add(name, text);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in likes)
            {
                Console.WriteLine($"Post: {item.Key} | Likes: {item.Value} | Dislikes: {dislikes[item.Key]}");
                Console.WriteLine("Comments:");
                if (comments[item.Key].Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var pair in comments[item.Key])
                    {
                        Console.WriteLine($"*  {pair.Key}: {pair.Value}");
                    }
                }
            }
        }
    }
}
