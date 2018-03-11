using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                if ((N1 + N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 + N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 + N2} - odd");
                }
            }
            else if (operation == "-")
            {
                if ((N1 - N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 - N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 - N2} - odd");
                }
            }
            else if (operation == "*")
            {
                if ((N1 * N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 * N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 * N2} - odd");
                }
            }
            else if (operation == "/")
            {
                if(N2 != 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 / N2:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (operation == "%")
            {
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {N1 % N2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
        }
    }
}
