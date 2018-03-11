using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int children = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string typeTransport = Console.ReadLine();
            //         влак   автобус  кораб   самолет
            //Възрастн 24.99  32.50    42.99   70.00
            //Ученици  14.99   28.50   39.99   50.00

            if (typeTransport == "train")
            {
                if (children + adults < 50)
                {
                    Console.WriteLine($"{(2 * (adults * 24.99 + children * 14.99) + nights * 82.99) * 1.1:F2}");
                }
                else
                {
                    Console.WriteLine($"{(2 * (adults * 24.99 * 0.5 + children * 14.99 * 0.5) + nights * 82.99) * 1.1:F2}");
                }
            }
            else if (typeTransport == "bus")
            {
                Console.WriteLine($"{(2 * (adults * 32.5 + children * 28.5) + nights * 82.99) * 1.1:F2}");
            }
            else if (typeTransport == "boat")
            {
                Console.WriteLine($"{(2 * (adults * 42.99 + children * 39.99) + nights * 82.99) * 1.1:F2}");
            }
            else if (typeTransport == "airplane")
            {
                Console.WriteLine($"{(2 * (adults * 70 + children * 50) + nights * 82.99) * 1.1:F2}");
            }
        }
    }
}
