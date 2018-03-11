using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            double midiKG = double.Parse(Console.ReadLine());
            double pricePalamud = palamudKG * priceSkumriq * 1.6;
            double priceSafrid = safridKG * priceCaca * 1.8;
            double priceMidi = midiKG * 7.5;

            Console.WriteLine($"{pricePalamud + priceSafrid + priceMidi:F2}");
        }
    }
}
