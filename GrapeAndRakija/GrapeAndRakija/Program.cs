using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakija
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaLoze = double.Parse(Console.ReadLine());
            double grapeForM2 = double.Parse(Console.ReadLine());
            double kgBrak = double.Parse(Console.ReadLine());
            double grapeLeft = areaLoze * grapeForM2 - kgBrak;
            double grapeForRakija = grapeLeft * 0.45;
            double grapeForSale = grapeLeft * 0.55;
            double rakijaProduced = grapeForRakija / 7.5;

            Console.WriteLine($"{rakijaProduced * 9.8:F2}");
            Console.WriteLine($"{grapeForSale * 1.5:F2}");
        }
    }
}
