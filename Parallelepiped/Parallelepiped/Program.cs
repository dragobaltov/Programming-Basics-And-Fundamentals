using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftPointCounter = 0;
            int rightPointCounter = 2 * n;
            // височина – 4 * n + 4 реда 
            // ширина – 3 * N + 1 колони

            Console.WriteLine("{0}{1}{0}{2}", new string('+', 1), new string('~', n - 2), new string('.', 2 * n + 1));
            for (int i = 2; i <= 2 * n + 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{4}", new string('|', 1), new string('.', leftPointCounter),  new string('\\', 1), new string('~', n - 2), new string('.', rightPointCounter));
                leftPointCounter++;
                rightPointCounter--;
            }
            int leftPointCounter2 = 0;
            int midPointCounter = 2 * n;
            for (int i = 2 * n + 3; i <= 4 * n + 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}", new string('.', leftPointCounter2), new string('\\', 1), new string('.', midPointCounter), new string('|', 1), new string('~', n - 2));
                leftPointCounter2++;
                midPointCounter--;
            }
            Console.WriteLine("{0}{1}{2}{1}", new string('.', 2 * n + 1), new string('+', 1), new string('~', n - 2));
        }
    }
}
