using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            double biggestnumber = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
                if (number > biggestnumber)
                {
                    biggestnumber = number;
                }
            }
            if (biggestnumber == sum / 2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestnumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((sum - biggestnumber) - biggestnumber)}");
            }
        }
    }
}
