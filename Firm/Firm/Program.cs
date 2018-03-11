using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double time = Math.Floor((days * 0.9) * 8) + workers * 2 * days;

            if (time >= hours)
            {
                Console.WriteLine($"Yes!{time - hours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hours - time} hours needed.");
            }

        }
    }
}
