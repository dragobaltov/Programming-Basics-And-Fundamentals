using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes + 15;

            if (newMinutes > 59)
            {
                newMinutes -= 60;
                hours += 1;
                if (hours > 23)
                {
                    hours -= 24;
                }
            }

            string newMinutesToString = "";
            if (newMinutes < 10)
            {
                newMinutesToString = "0" + newMinutes.ToString();
            }
            else
            {
                newMinutesToString = newMinutes.ToString();
            }
            Console.WriteLine($"{hours}:{newMinutesToString}");
        }
    }
}
