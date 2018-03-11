using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetablesShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesKG = int.Parse(Console.ReadLine());
            int fruitsKG = int.Parse(Console.ReadLine());
            double profitLV = vegetablesPrice * vegetablesKG + fruitsPrice * fruitsKG;
            double profitEUR = profitLV / 1.94;

            Console.WriteLine($"{profitEUR}");
        }
    }
}
