using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenStarCounter = 2;
            int oddStarCounter = 1;
            int evenlineCounter = (n - 2) / 2;
            int oddlineCounter = (n - 1) / 2;

            for (int i = 1; i <= Math.Ceiling(n * 1.0 / 2); i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', evenlineCounter), new string('*', evenStarCounter));
                    evenStarCounter += 2;
                    evenlineCounter--;
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', oddlineCounter), new string('*', oddStarCounter));
                    oddStarCounter += 2;
                    oddlineCounter--;
                }
            }
            if (n % 2 == 1)
            {
                for (int i = n / 2 + 1; i < n; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('|', 1), new string('*', n - 2));
                }
            }
            else
            {
                for (int i = n / 2 + 1; i <= n; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('|', 1), new string('*', n - 2));
                }
            }
        }
    }
}
