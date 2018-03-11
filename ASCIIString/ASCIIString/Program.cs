using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                short num = short.Parse(Console.ReadLine());

                Console.Write(Convert.ToChar(num));
            }
        }
    }
}
