using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOverLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEnd = int.Parse(Console.ReadLine());
            int secondEnd = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (firstEnd < secondEnd)
            {
                if (point >= firstEnd && point <= secondEnd)
                {
                    Console.WriteLine("in");
                    if ((point - firstEnd) < (secondEnd - point))
                    {
                        Console.WriteLine(point - firstEnd);
                    }
                    else
                    {
                        Console.WriteLine(secondEnd - point);
                    }
                }
                else
                {
                    Console.WriteLine("out");
                    if (point < firstEnd)
                    {
                        Console.WriteLine(firstEnd - point);
                    }
                    else if (point > secondEnd)
                    {
                        Console.WriteLine((point - secondEnd));
                    }
                }
            }
            else
            {
                if (point >= secondEnd && point <= firstEnd)
                {
                    Console.WriteLine("in");
                    if ((point - secondEnd) < (firstEnd - point))
                    {
                        Console.WriteLine(point - secondEnd);
                    }
                    else
                    {
                        Console.WriteLine(firstEnd - point);
                    }
                }
                else
                {
                    Console.WriteLine("out");
                    if (point < secondEnd)
                    {
                        Console.WriteLine(secondEnd - point);
                    }
                    else if (point > firstEnd)
                    {
                        Console.WriteLine(point - firstEnd);
                    }
                }
            }
        }
    }
}
