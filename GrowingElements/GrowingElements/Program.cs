using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lengthCounter = 0;
            int oldNum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                oldNum += num;
                if (num > (oldNum - num))
                {
                    lengthCounter++;
                }
                oldNum = num;
            }
            Console.WriteLine(lengthCounter);
        }
    }
}
