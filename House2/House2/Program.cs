using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House2
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int baseHeight = height / 2;
            int roofHeight = height - baseHeight;
            int starCount = 1;

            if (height % 2 == 0)
            {
                starCount++;
            }

            for (int i = 0; i < roofHeight; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (height - starCount) / 2), new string('*', starCount));
                starCount += 2;
            }
            for (int i = 0; i < baseHeight; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string('*', height - 2));
            }
        }
    }
}
