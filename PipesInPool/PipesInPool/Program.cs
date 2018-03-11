using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            if(((P1 + P2) * H) <= V )
            {
                Console.WriteLine($"The pool is {Math.Truncate(((P1 + P2) * H) / V * 100)}% full. " +
                    $"Pipe 1: {Math.Truncate((P1 * H) / ((P1 + P2) * H) * 100)}%. " +
                    $"Pipe 2: {Math.Truncate((P2 * H) / ((P1 + P2) * H) * 100)}%.");
            }
            else if(((P1 + P2) * H) > V)
            {
                Console.WriteLine($"For {H} hours the pool overflows with {((P1 + P2) * H) - V:F1} liters.");
            }
        }
    }
}
