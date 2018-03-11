using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 5)
            {
                Console.WriteLine("What are you doing?");
                n--;
                if (n == 10)
                    break;
            }
        }
    }
}
