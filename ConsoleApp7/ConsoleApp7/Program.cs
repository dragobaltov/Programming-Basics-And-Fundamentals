using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inch = double.Parse(Console.ReadLine());
            var cm = inch * 2.54;
            Console.WriteLine($"Centimeters = {cm}");
        }
    }
}
