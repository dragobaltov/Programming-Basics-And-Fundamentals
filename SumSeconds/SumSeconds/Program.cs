using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;

            string secToString = String.Empty;
            if (sum < 60)
            {
                if (sum < 10)
                {
                    secToString = "0" + sum.ToString();
                }
                else
                {
                    secToString = sum.ToString();
                }
                Console.WriteLine($"0:{secToString}");
            }
            else if (sum < 120)
            {
                sum -= 60;
                if(sum < 10)
                {
                    secToString = "0" + sum.ToString();
                }
                else
                {
                    secToString = sum.ToString();
                }
                Console.WriteLine($"1:{secToString}");
            }
            else if (sum < 180)
            {
                sum -= 120;
                if (sum < 10)
                {
                    secToString = "0" + sum.ToString();
                }
                else
                {
                    secToString = sum.ToString();
                }
                Console.WriteLine($"2:{secToString}");
            }
        }
    }
}
