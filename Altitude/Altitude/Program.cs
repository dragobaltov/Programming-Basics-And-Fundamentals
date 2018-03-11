using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            long initialAltitude = Convert.ToInt64(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 1 && i == array.Length - 1)
                    break;

                if (array[i] == "up")
                {
                    initialAltitude += Convert.ToInt64(array[i + 1]);
                }
                else if (array[i] == "down")
                {
                    initialAltitude -= Convert.ToInt64(array[i + 1]);
                }

                if (initialAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    break;
                }
            }

            if (initialAltitude > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitude}m");
            }
        }
    }
}
