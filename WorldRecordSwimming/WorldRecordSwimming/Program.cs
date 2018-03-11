using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldRecordSwimming
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double mForS = double.Parse(Console.ReadLine());
            double resistance = Math.Floor(distance / 15) * 12.5;
            double time = distance * mForS + resistance;

            if (time < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {time - worldRecord:F2} seconds slower.");
            }

        }
    }
}
