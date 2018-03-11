using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumFactorial = 1;

            while (n > 1)
            {
                sumFactorial *= n;
                n--;
            }
            Console.WriteLine(sumFactorial);
        }
    }
}
