using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starCounter = 1;
            int lineCounter = 2 * n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', starCounter), new string('\\', 1), new string('-', lineCounter), new string('/', 1));
                starCounter++;
                lineCounter -= 2;
            }
            int endStarCounter = n / 2;
            int midStarCounter = n;
            for (int i = n + 1; i <= n + n / 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{1}{0}", new string('|', 1), new string('*', endStarCounter), new string('\\', 1), new string('*', midStarCounter), new string('/',1));
                endStarCounter++;
                midStarCounter -= 2;
            }
            starCounter = 1;
            lineCounter = 2 * n - 1;
            for (int i = n + n / 3 + 1; i <= 2 * n + n / 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', starCounter), new string('\\', 1), new string('*', lineCounter), new string('/', 1));
                starCounter++;
                lineCounter -= 2;
            }
        }
    }
}
