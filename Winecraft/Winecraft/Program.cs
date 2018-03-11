using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Program
    {
        static List<int> grapePower;

        static void Main(string[] args)
        {
            grapePower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 0; i < growthDays; i++)
                {
                    BloomingGrapes();
                }

                KillWeakGrapes(growthDays);
            } while (ThereAreEnoughStrongGrapes(growthDays));

            PrintLiveGrapes();
        }

        static void BloomingGrapes()
        {
            for (int i = 0; i < grapePower.Count; i++)
            {
                if (!IsAlive(i))
                {
                    continue;
                }

                if (GreaterGrape(i))
                {
                    grapePower[i]++;
                    if (IsAlive(i - 1))
                    {
                        grapePower[i]++;
                        grapePower[i - 1]--;
                    }
                    if (IsAlive(i + 1))
                    {
                        grapePower[i]++;
                        grapePower[i + 1]--;
                    }
                }
                else if (LesserGrape(i))
                {
                    
                }
                else
                {
                    grapePower[i]++;
                }
            }
        }

        static  bool GreaterGrape(int i)
        {
            if (i <= 0 || i >= grapePower.Count - 1)
                return false;
            else
            {
                if (grapePower[i] > grapePower[i - 1] && grapePower[i] > grapePower[i + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static bool LesserGrape(int i)
        {
            if (GreaterGrape(i - 1) || GreaterGrape(i + 1))
            {
                return true;
            }

            return false;
        }

        static bool ThereAreEnoughStrongGrapes(int n)
        {
            return (grapePower.Where(a => a > n).Count() >= n);
        }
        
        static void KillWeakGrapes(int n)
        {
            for (int i = 0; i < grapePower.Count; i++)
            {
                if (grapePower[i] <= n)
                {
                    grapePower[i] = 0;
                }
            }
        }
        
        static void PrintLiveGrapes()
        {
            for (int i = 0; i < grapePower.Count; i++)
            {
                if (IsAlive(i))
                {
                    Console.Write(grapePower[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static bool IsAlive(int i)
        {
            if(i < 0 || i >= grapePower.Count)
            {
                return false;
            }

            return (grapePower[i] > 0);
        }
    }
}
