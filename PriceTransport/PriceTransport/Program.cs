using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            
            if(n < 20 && timeOfDay == "day")
            {
                Console.WriteLine(0.7 + 0.79 * n);
            }
            else if (n < 20 && timeOfDay == "night")
            {
                Console.WriteLine(0.7 + 0.90 * n);
            }
            else if(n < 100 && n>= 20 && timeOfDay == "day")
            {
                Console.WriteLine(0.09 * n);
            }
            else if (n < 100 && n>=20 && timeOfDay == "night")
            {
                Console.WriteLine(0.09 * n);
            }
            else if (n >= 100 && timeOfDay == "day")
            {
                Console.WriteLine(0.06 * n);
            }
            else if (n >= 100 && timeOfDay == "night")
            {
                Console.WriteLine(0.06 * n);
            }
        }
    }
}
