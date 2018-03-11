using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midLinesCounter = 0;
            int rightLinesCounter = 2 * n - 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}", new string('-', 3 * n), new string('*', 1), new string('-', midLinesCounter), new string('-', rightLinesCounter));
                midLinesCounter++;
                rightLinesCounter--;
            }
            for (int i = n + 1; i <= n + n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}", new string('*', 3 * n + 1), new string('-', n - 1), new string('*', 1));
            }
            int leftLinesCounter = 3 * n;
            int midLinesCounter2 = n - 1;
            int rightLinesCounter2 = n - 1;
            for (int i = n + n / 2 + 1; i <= n + 2 * (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}", new string('-', leftLinesCounter), new string('*', 1), new string('-', midLinesCounter2), new string('-', rightLinesCounter2));
                leftLinesCounter--;
                midLinesCounter2 += 2;
                rightLinesCounter2--;
            }
            Console.WriteLine("{0}{1}{2}", new string('-', leftLinesCounter), new string('*', 5 * n - (leftLinesCounter + rightLinesCounter2)), new string('-', rightLinesCounter2));
        }
    }
}
