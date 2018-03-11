using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midSpaceCounter = n - 2;
            int endSpaceCounter = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', endSpaceCounter), new string('x', 1), new string(' ', midSpaceCounter));
                endSpaceCounter++;
                midSpaceCounter -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string(' ', endSpaceCounter), new string('x', 1));
            endSpaceCounter--;
            midSpaceCounter = 1;
            for (int i = n / 2 + 2; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', endSpaceCounter), new string('x', 1), new string(' ', midSpaceCounter));
                endSpaceCounter--;
                midSpaceCounter += 2;
            }
        }
    }
}
