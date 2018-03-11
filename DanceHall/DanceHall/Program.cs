using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());
            double sideGr = double.Parse(Console.ReadLine());
            double lengthHallCm = lengthHall * 100;
            double widthHallCm = widthHall * 100;
            double sideGrCm = sideGr * 100;
            double areaHall = lengthHallCm * widthHallCm;
            double areaBench = areaHall / 10;
            double areaGr = sideGrCm * sideGrCm;
            double area = areaHall - areaBench - areaGr;
            double dancers = Math.Floor(area / 7040);

            Console.WriteLine(dancers);
        }
    }
}
