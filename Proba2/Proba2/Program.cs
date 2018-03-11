using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Proba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            do
            {
                fact *= n;
                n--;
            } while (n > 1);
            Console.WriteLine(fact);
        }
    }
}
