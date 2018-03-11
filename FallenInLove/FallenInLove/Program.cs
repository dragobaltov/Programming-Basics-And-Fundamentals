using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointEndCounter = 2 * n;
            int pointMidCounter = 0;
            int waveCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('#', 1), new string('~', waveCounter), new string('.', pointEndCounter), new string('.', pointMidCounter));
                waveCounter++;
                pointEndCounter -= 2;
                pointMidCounter += 2;
            }
            pointEndCounter = 1;
            for (int i = n + 1; i <= 2 * n + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', pointEndCounter), new string('#', 1), new string('~', waveCounter), new string('.', pointMidCounter));
                pointEndCounter += 2;
                waveCounter--;
                pointMidCounter -= 2;
            }
            for (int i = 2 * n + 2; i <= 3 * n + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 2), new string('#', 2));
            }
        }
    }
}
