using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = null;
            double spent = 0.0;

            while (game != "Game Time")
            {
                game = Console.ReadLine();

                if (game == "OutFall 4")
                {
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        spent += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (balance >= 15.99)
                    {
                        balance -= 15.99;
                        spent += 15.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (balance >= 19.99)
                    {
                        balance -= 19.99;
                        spent += 19.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (balance >= 59.99)
                    {
                        balance -= 59.99;
                        spent += 59.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (balance >= 29.99)
                    {
                        balance -= 29.99;
                        spent += 29.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        spent += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    if (game != "Game Time")
                    {
                        Console.WriteLine("Not Found");
                    }
                }
            }

            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}
