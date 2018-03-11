using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    if (sum >= controlNumber)
                        break;
                    counter++;
                    sum += 2 * i + 3 * j;
                }
                if (sum >= controlNumber)
                    break;
            }

            if (sum >= controlNumber)
            {
                Console.WriteLine($"{counter} moves");
                Console.WriteLine($"Score: {sum} >= {controlNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}
