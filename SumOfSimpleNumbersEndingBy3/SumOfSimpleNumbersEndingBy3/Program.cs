using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSimpleNumbersEndingBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (IsSimpleNumber(i) && EndsBy3(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        static bool IsSimpleNumber(int x)
        {
            bool isSimple = false;
            int num = 2;

            while (num <= x / 2 && !isSimple)
            {
                if (x % num == 0)
                    isSimple = true;
                else
                    num++;
            }

            return isSimple;
        }

        static bool EndsBy3(int x)
        {
            return (x % 10 == 3);
        }
    }
}
