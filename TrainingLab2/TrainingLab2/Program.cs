using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double lengthCM = length * 100;
            double widthCM = width * 100;
            double hallCM = 100;
            double cols = Math.Floor((widthCM - hallCM) / 70);
            double rows = Math.Floor(lengthCM / 120);

            Console.WriteLine($"{cols * rows - 3}");
        }
    }
}
