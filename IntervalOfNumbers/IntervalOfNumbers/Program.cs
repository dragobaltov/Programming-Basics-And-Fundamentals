using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int firstNum = beginning;
            int secondNum = beginning + 1;
            int thirdNum = beginning + 2;
            int forthNum = beginning + 3;
            int fifthNum = beginning + 4;
            bool enoughNumbers = false;
            int counter = 0;

            for (int i = firstNum; i <= end; i++)
            {
                for (int j = secondNum; j <= end; j++)
                {
                    for (int k = thirdNum; k <= end; k++)
                    {
                        for (int l = forthNum; l <= end; l++)
                        {
                            for (int h = fifthNum; h <= end; h++)
                            {
                                counter++;
                                enoughNumbers = true;
                                if (i < j && j < k && k < l && l < h)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {h}");
                                }
                            }
                        }
                    }
                }
            }

            if (enoughNumbers == false)
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(counter);
        }
    }
}
