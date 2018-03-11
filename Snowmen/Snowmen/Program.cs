using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (snowmen.Count != 1)
            {
                bool countIsOne = false;

                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen[i] != -1)
                    {
                        int atackerIndex = i;
                        int targetIndex = snowmen[i];

                        if (targetIndex >= snowmen.Count)
                        {
                            targetIndex %= snowmen.Count;
                        }

                        if (atackerIndex == targetIndex)
                        {
                            Console.WriteLine($"{atackerIndex} performed harakiri");
                            snowmen[atackerIndex] = -1;
                        }
                        else if (Math.Abs(atackerIndex - targetIndex) % 2 == 0)
                        {
                            Console.WriteLine($"{atackerIndex} x {targetIndex} -> {atackerIndex} wins");
                            snowmen[targetIndex] = -1;
                        }
                        else if (Math.Abs(atackerIndex - targetIndex) % 2 == 1)
                        {
                            Console.WriteLine($"{atackerIndex} x {targetIndex} -> {targetIndex} wins");
                            snowmen[atackerIndex] = -1;
                        }

                        if (snowmen.Where(s => s != -1).ToList().Count == 1)
                        {
                            countIsOne = true;
                            break;
                        }
                    }
                }

                if (countIsOne)
                    break;

                snowmen = snowmen.Where(s => s != -1).ToList();
            }
        }
    }
}
