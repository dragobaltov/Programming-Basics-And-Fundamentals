using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int car = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(bricks * 1.0 / (workers * car)));
        }
    }
}
