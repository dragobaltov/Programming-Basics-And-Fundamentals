using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());
            double palamudPrice = priceSkumriq * 1.6;
            double safridPrice = priceCaca * 1.8;
            double midiPrice = 7.5;
            Console.WriteLine($"{palamudPrice * palamudKg + safridPrice * safridKg + midiPrice * midiKg:F2}");
        }
    }
}
