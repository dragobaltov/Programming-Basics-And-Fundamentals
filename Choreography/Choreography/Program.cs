using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double movesForADay = Math.Ceiling((moves * 1.0 / days) / moves * 100);
            double movesDancer = movesForADay / dancers;

            if (movesForADay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {movesDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {movesDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
