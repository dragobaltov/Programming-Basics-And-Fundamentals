using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = 2 * n - 1;
            int lineCounter = 0;

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter), new string('/', 1), new string('|', 1), new string('\\', 1));
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter), new string('\\', 1), new string('|', 1), new string('/', 1));
            for (int i = 3; i <= 2 * n + 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', pointCounter), new string('*', 1), new string('-', lineCounter));
                pointCounter--;
                lineCounter++;
            }
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
            for (int i = 1; i <= 2 * n + 1; i++)
            {
                if (i == 2 * n + 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("*.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}", new string('*', 4 * n + 1));

        }
    }
}
