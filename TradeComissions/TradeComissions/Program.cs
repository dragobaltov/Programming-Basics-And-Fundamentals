using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            if(town == "sofia")
            {
                if(sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 0.05:F2}");
                }
                else if(sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales * 0.07:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales * 0.08:F2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 0.12:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 0.045:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales * 0.075:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales * 0.1:F2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 0.13:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 0.055:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales * 0.08:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales * 0.12:F2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 0.145:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
