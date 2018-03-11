using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (!((n >= 100 && n <= 200) || n == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
