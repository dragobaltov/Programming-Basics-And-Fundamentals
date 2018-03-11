using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midLineCounter = 0;
            int leftLineCounter = 3 * n;
            int rightLineCounter = 2 * n - 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}", new string('-', 3 * n), new string('*', 1), new string('-', midLineCounter), new string('-', rightLineCounter));
                midLineCounter++;
                rightLineCounter--;
            }
            midLineCounter--;
            rightLineCounter++;
            for (int i = n + 1; i <= n + n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}", new string('*', 3 * n + 1), new string('-', midLineCounter), new string('*', 1), new string('-', rightLineCounter));
            }
            for (int i = n + n / 2 + 1; i <= n + (n / 2) + (n / 2); i++)
            {
                if (i == n + (n / 2) + (n / 2))
                {
                    Console.WriteLine("{0}{1}{2}", new string('-', leftLineCounter), new string('*', 5 * n - (leftLineCounter + rightLineCounter)), new string('-', rightLineCounter));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}", new string('-', leftLineCounter), new string('*', 1), new string('-', midLineCounter), new string('-', rightLineCounter));
                }
                leftLineCounter--;
                midLineCounter += 2;
                rightLineCounter--;
            }
            
        }
    }
}
