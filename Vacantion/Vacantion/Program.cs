using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            //       влак автобус кораб самолет
            //adults 24.99   32.50   42.99   70.00
            //students  14.99   28.50   39.99   50.00

            if (transport == "train")
            {
                if ((adults + students) >= 50)
                {
                    Console.WriteLine($"{((adults * 24.99 + students * 14.99) * 2 * 0.5 + 82.99 * nights) * 1.1:F2}");
                }
                else
                {
                    Console.WriteLine($"{((adults * 24.99 + students * 14.99) * 2 + 82.99 * nights) * 1.1:F2}");
                }
            }
            else if (transport == "bus")
            {
                Console.WriteLine($"{((adults * 32.5 + students * 28.5) * 2 + 82.99 * nights) * 1.1:F2}");
            }
            else if (transport == "boat")
            {
                Console.WriteLine($"{((adults * 42.99 + students * 39.99) * 2 + 82.99 * nights) * 1.1:F2}");
            }
            else if (transport == "airplane")
            {
                Console.WriteLine($"{((adults * 70 + students * 50) * 2 + 82.99 * nights) * 1.1:F2}");
            }
        }
    }
}
