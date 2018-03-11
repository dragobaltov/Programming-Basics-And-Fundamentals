using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int addition = 15;
            int newMinutes = minutes + addition;

            if (newMinutes >= 60)
            {
                if (hours == 23)
                {
                    Console.WriteLine($"0:{newMinutes - 60:00}");
                }
                else
                {
                    Console.WriteLine($"{hours + 1}:{newMinutes - 60:00}");
                }
            }
            else
            {
                Console.WriteLine($"{hours}:{newMinutes:00}");
            }
        }
    }
}
