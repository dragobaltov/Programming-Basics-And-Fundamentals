using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaceCounter = n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}{1}", new string(' ', spaceCounter), new string('*', 1));
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
                spaceCounter--;
            }
            int spaceCounter2 = 1;
            for (int i = n + 1; i <= 2 * n - 1; i++)
            {
                Console.Write("{0}{1}", new string(' ', spaceCounter2), new string('*', 1));
                for (int j = 2 * n - 1; j >= i + 1; j--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
                spaceCounter2++;
            }
        }
    }
}
