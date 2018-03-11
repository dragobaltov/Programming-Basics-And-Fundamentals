using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string screening = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(screening == "Premiere")
            {
                Console.WriteLine($"{r * c * 12:F2}");
            }
            else if(screening == "Normal")
            {
                Console.WriteLine($"{r * c * 7.5:F2}");
            }
            else if (screening == "Discount")
            {
                Console.WriteLine($"{r * c * 5:F2}");
            }
        }
    }
    
}
