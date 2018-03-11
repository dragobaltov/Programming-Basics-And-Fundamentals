using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakija2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lozeArea = double.Parse(Console.ReadLine());
            double grapeM2 = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());
            double grapeMade = lozeArea * grapeM2 - brak;
            double grapeForRakija = 0.45 * grapeMade;
            double grapeForSell = 0.55 * grapeMade;
            double rakijaMade = grapeForRakija / 7.5;

            Console.WriteLine($"{rakijaMade * 9.8:F2}");
            Console.WriteLine($"{grapeForSell * 1.5:F2}");
        }
    }
}
