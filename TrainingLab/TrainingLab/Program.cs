using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = Math.Floor(double.Parse(Console.ReadLine()) / 1.2);
            var width = Math.Floor((double.Parse(Console.ReadLine()) - 1) / 0.7);
            Console.WriteLine(length * width - 3);
        }
    }
}
