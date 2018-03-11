using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElement
{
    class Program
    {
        static List<int> list;

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            list = new List<int>();
            int lastRemoved = 0;
            double averageSum = 0.0;

            while (command != "stop")
            {
                if (command == "bang")
                {
                    bool listCount = (list.Count > 0);
                    if (listCount)
                        averageSum = AverageSum();

                    lastRemoved = LastRemovedElement(averageSum);
                    FindingElementSmallerOrEqualToAverageSum(averageSum);

                    if (lastRemoved == int.MaxValue)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {averageSum}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"shot {lastRemoved}");
                    }
                    DecrementingElements();
                }
                else
                {
                    int number = Convert.ToInt32(command);
                    list.Insert(0, number);
                }
                command = Console.ReadLine();
            }

            if (command == "stop")
            {
                if (list.Count > 0)
                {
                    Console.WriteLine($"survivors: {string.Join(" ", list)}");
                }
                else
                {
                    Console.WriteLine($"you shot them all. last one was {lastRemoved}");
                }
            }
        }

        static double AverageSum()
        {
            double averageSum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                averageSum += list[i];
            }
            averageSum /= (list.Count * 1.0);

            return averageSum;
        }

        static void FindingElementSmallerOrEqualToAverageSum(double averageSum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= averageSum)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }

        static void DecrementingElements()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] -= 1;
            }
        }

        static int LastRemovedElement(double averageSum)
        {
            int lastRemoved = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= averageSum)
                {
                    lastRemoved = list[i];
                    break;
                }
            }
            
            return lastRemoved;
        }
    }
}
