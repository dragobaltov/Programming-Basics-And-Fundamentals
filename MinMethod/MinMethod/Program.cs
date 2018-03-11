using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(SmallerOfTwoNumbers(a, b), c));
        }

        static int SmallerOfTwoNumbers(int a, int b)
        {
           return Math.Min(a, b);
        }
    }
}
